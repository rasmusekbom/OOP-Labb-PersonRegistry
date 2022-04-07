
namespace RasmusEkbom_IndividuellLabb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPerson_btn = new System.Windows.Forms.Button();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.personct = new System.Windows.Forms.Label();
            this.ExitProgram_btn = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.AddPerson_btn);
            this.groupBox1.Controls.Add(this.lastname_txt);
            this.groupBox1.Controls.Add(this.firstname_txt);
            this.groupBox1.Controls.Add(this.FemaleButton);
            this.groupBox1.Controls.Add(this.MaleButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Person";
            // 
            // AddPerson_btn
            // 
            this.AddPerson_btn.Location = new System.Drawing.Point(122, 111);
            this.AddPerson_btn.Name = "AddPerson_btn";
            this.AddPerson_btn.Size = new System.Drawing.Size(113, 26);
            this.AddPerson_btn.TabIndex = 8;
            this.AddPerson_btn.Text = "Add Person";
            this.AddPerson_btn.UseVisualStyleBackColor = true;
            this.AddPerson_btn.Click += new System.EventHandler(this.AddPerson);
            // 
            // lastname_txt
            // 
            this.lastname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_txt.Location = new System.Drawing.Point(93, 53);
            this.lastname_txt.MaxLength = 12;
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(100, 21);
            this.lastname_txt.TabIndex = 7;
            this.lastname_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // firstname_txt
            // 
            this.firstname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_txt.Location = new System.Drawing.Point(93, 30);
            this.firstname_txt.MaxLength = 12;
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(100, 21);
            this.firstname_txt.TabIndex = 6;
            this.firstname_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleButton.Location = new System.Drawing.Point(10, 111);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(65, 17);
            this.FemaleButton.TabIndex = 5;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleButton.Location = new System.Drawing.Point(10, 88);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(52, 17);
            this.MaleButton.TabIndex = 4;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.SortBy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.listBoxPeople);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persons";
            // 
            // SortBy
            // 
            this.SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBy.FormattingEnabled = true;
            this.SortBy.Items.AddRange(new object[] {
            "Last name",
            "First name"});
            this.SortBy.Location = new System.Drawing.Point(7, 261);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(85, 21);
            this.SortBy.TabIndex = 17;
            this.SortBy.SelectedIndexChanged += new System.EventHandler(this.SortListBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sort by:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveSelectedPerson);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Merge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MergeButton);
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.ItemHeight = 15;
            this.listBoxPeople.Location = new System.Drawing.Point(8, 28);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPeople.Size = new System.Drawing.Size(237, 199);
            this.listBoxPeople.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(284, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 51);
            this.textBox3.MaxLength = 12;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.SearchFunction);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "First or lastname";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.personct);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(314, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 71);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount of Persons";
            // 
            // personct
            // 
            this.personct.AutoSize = true;
            this.personct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personct.Location = new System.Drawing.Point(65, 26);
            this.personct.Name = "personct";
            this.personct.Size = new System.Drawing.Size(26, 29);
            this.personct.TabIndex = 9;
            this.personct.Text = "0";
            // 
            // ExitProgram_btn
            // 
            this.ExitProgram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitProgram_btn.Location = new System.Drawing.Point(332, 398);
            this.ExitProgram_btn.Name = "ExitProgram_btn";
            this.ExitProgram_btn.Size = new System.Drawing.Size(116, 69);
            this.ExitProgram_btn.TabIndex = 12;
            this.ExitProgram_btn.Text = "Exit Program";
            this.ExitProgram_btn.UseVisualStyleBackColor = true;
            this.ExitProgram_btn.Click += new System.EventHandler(this.ExitProgram);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.BackColor = System.Drawing.Color.White;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(338, 230);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(97, 18);
            this.ErrorMessage.TabIndex = 13;
            this.ErrorMessage.Text = "Any Errors?";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.ErrorBox.Location = new System.Drawing.Point(284, 262);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(208, 82);
            this.ErrorBox.TabIndex = 15;
            this.ErrorBox.Text = "Nope, so far so good.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 511);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.ExitProgram_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rasmus Individuella Labb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPerson_btn;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxPeople;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label personct;
        private System.Windows.Forms.Button ExitProgram_btn;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SortBy;
    }
}

