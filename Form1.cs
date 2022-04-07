using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;


namespace RasmusEkbom_IndividuellLabb
{
    public partial class Form1 : Form
    {
        static int personAmount = 0;
        private List<Person> peopleList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPerson(object sender, EventArgs e) // Adderar en person.
        {
            try
            {
                if (MaleButton.Checked && firstname_txt.Text != "" && lastname_txt.Text != "")
                {
                    var newMale = new Male(firstname_txt.Text, lastname_txt.Text);
                    peopleList.Add(newMale);
                    UpdateListAndAddToCounter();

                }
                else if (FemaleButton.Checked && firstname_txt.Text != "" && lastname_txt.Text != "")
                {
                    var newFemale = new Female(firstname_txt.Text, lastname_txt.Text);
                    peopleList.Add(newFemale);
                    UpdateListAndAddToCounter();

                }
                else if (firstname_txt.Text.Length == 0 || lastname_txt.Text.Length == 0) // Ser till så både för- samt efternamn är skrivet.
                {
                    ErrorBox.Text = "You need to enter a full name.";
                    ErrorBox.ForeColor = Color.Red;
                }
            }
            catch { ErrorBox.Text = "You need to enter a full name."; }
        }

        private void UpdateListAndAddToCounter() // Rensar firstname samt lastname-textboxen, och adderar även 1 till Person-räknaren.
        {
            try
            {
                peopleList.Sort();
                listBoxPeople.Items.Clear();
                foreach (var people in peopleList)
                {
                    listBoxPeople.Items.Add(people);
                }
                personAmount++;
                personct.Text = personAmount.ToString();
                firstname_txt.Text = "";
                lastname_txt.Text = "";
                NoErrors();
            }
            catch { ErrorBox.Text = "Error."; }
        }

        private void NoErrors()
        {
            ErrorBox.Text = "Nope, so far so good.";
            ErrorBox.ForeColor = Color.DarkGreen;
        }
        private void AddPeopleCt() //Sorderar Person-listan samt adderar 1 till Person-räknaren.
        {
            personAmount++;
            personct.Text = personAmount.ToString();
            peopleList.Sort();
        }

        private void ExitProgram(object sender, EventArgs e) // Avslutar programmet.
        {
            Application.Exit();
        }

        private void OnlyLetters(object sender, KeyPressEventArgs e) // Ser till så att användaren endast kan skriva med bokstäver.
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void RemoveSelectedPerson(object sender, EventArgs e) // Tar bort vald person ur listBoxen samt ur Person-list.
        {
            try
            {
                if (listBoxPeople.SelectedItems.Count == 1)
                {
                    if (listBoxPeople.Items.Count > 0)
                    {
                        for (int i = 0; i < listBoxPeople.Items.Count; i++)
                        {
                            if (listBoxPeople.GetSelected(i) == true)
                            {
                                Person p = listBoxPeople.SelectedItem as Person;
                                peopleList.Remove(p);
                                listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
                                personAmount--;
                                personct.Text = personAmount.ToString();
                                NoErrors();
                            }
                        } 
                    }
                }
                else if (listBoxPeople.SelectedItems.Count != 1)
                {
                    ErrorBox.Text = "Select only one Person to remove. And think through it carefully!";
                    ErrorBox.ForeColor = Color.Red;
                }
            }
            catch { ErrorBox.Text = "The list is empty, no people to remove."; ErrorBox.ForeColor = Color.Red; }
        }

        private void MergeButton(object sender, EventArgs e) // Male + Female = Child-merge med IF-satser som kollar så det är rätt antal personer samt en av varje kön.
        {
            try
            {
                if (listBoxPeople.SelectedItems.Count != 2 || listBoxPeople.SelectedItems.Count > 2)
                {
                    ErrorBox.Text = "Select one female and one male in the list to make a child.";
                    ErrorBox.ForeColor = Color.Red;
                }
                else if (listBoxPeople.SelectedItems.Count == 2)
                {
                    if (listBoxPeople.SelectedItems[0] is Female mom && listBoxPeople.SelectedItems[1] is Male dad)
                    {
                        var child = mom + dad;
                        peopleList.Add(child);
                        AddChildAndSortList();
                        AddPeopleCt();
                        NoErrors();
                    }

                    else if (listBoxPeople.SelectedItems[1] is Female mom2 && listBoxPeople.SelectedItems[0] is Male dad2)
                    {
                        var child = mom2 + dad2;
                        peopleList.Add(child);
                        AddChildAndSortList();
                        AddPeopleCt();
                        NoErrors();
                    }

                    else if (listBoxPeople.SelectedItems[1] is Child || listBoxPeople.SelectedItems[0] is Child)
                    {
                        ErrorBox.Text = "That would NOT be okay.";
                        ErrorBox.ForeColor = Color.Red;
                    }
                }
            }
            catch { ErrorBox.Text = "You need to select one male and one female to proceed with this."; ErrorBox.ForeColor = Color.Red; }
        }
        private void AddChildAndSortList() // Sorterar listan efter att merge har gjorts.
        {
            peopleList.Sort();
            listBoxPeople.Items.Clear();
            foreach (var people in peopleList)
            {
                listBoxPeople.Items.Add(people);
            }
        }
        private void SearchFunction(object sender, EventArgs e) // LINQ Query syntax för att söka på förnamn samt efternamn.
        {
            try
            {
                if (textBox3.Text != "")
                {

                    var peopleSearch = from p in peopleList
                                       where p.FirstName.ToLower().Contains(textBox3.Text.ToLower()) || p.LastName.ToLower().Contains(textBox3.Text.ToLower())
                                       select p;

                    listBoxPeople.Items.Clear();
                    foreach (var person in peopleSearch)
                    {
                        listBoxPeople.Items.Add(person);
                    }
                }

                else if (textBox3.Text == "")
                {
                    listBoxPeople.Items.Clear();
                    foreach (var person in peopleList)
                    {
                        listBoxPeople.Items.Add(person);
                    }
                }
                
            }

            catch { ErrorBox.Text = "No person with that letter/name was found."; }

        }
        private void SortListBox(object sender, EventArgs e) // Sorterar listBoxen efter efternamns-ordning.
        {
            try
            {
                if (SortBy.SelectedIndex == 0)
                {
                    listBoxPeople.Items.Clear();
                    foreach (var person in peopleList)
                    {
                        listBoxPeople.Items.Add(person);
                    }
                }
                if (SortBy.SelectedIndex == 1) // Sorterar listBoxen efter förnamns-ordning.
                {
                    var firstnameSort = from p in peopleList
                                        orderby p.FirstName, p.LastName descending
                                        select p;

                    listBoxPeople.Items.Clear();
                    foreach (var person in firstnameSort)
                    {
                        listBoxPeople.Items.Add(person);
                    }
                }
            }
            catch { ErrorBox.Text = "Something went wrong. Please restart the program."; }
            }
        }
    }

