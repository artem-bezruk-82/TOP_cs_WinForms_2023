using System.Windows.Forms;

namespace Questionnaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewItem_Name = new ListViewItem();
            listViewSubItem_Name = new ListViewItem.ListViewSubItem();
            listViewItem_Surname = new ListViewItem();
            listViewSubItem_Surname = new ListViewItem.ListViewSubItem();
            listViewItem_Birthday = new ListViewItem();
            listViewSubItem_Birthday = new ListViewItem.ListViewSubItem();
            listViewItem_Email = new ListViewItem();
            listViewSubItem_Email = new ListViewItem.ListViewSubItem();
            listViewItem_Phone = new ListViewItem();
            listViewSubItem_Phone = new ListViewItem.ListViewSubItem();
            listViewItem_Gender = new ListViewItem();
            listViewSubItem_Gender = new ListViewItem.ListViewSubItem();
            label_Name = new Label();
            textBox_Name = new TextBox();
            label_Surname = new Label();
            textBox_Surname = new TextBox();
            dateTimePicker_Birthday = new DateTimePicker();
            textBox_Email = new TextBox();
            label_Email = new Label();
            label_Birthday = new Label();
            errorProvider1 = new ErrorProvider(components);
            listView_Preview = new ListView();
            columnHeader_Property = new ColumnHeader();
            columnHeader_Value = new ColumnHeader();
            maskedTextBox_Phone = new MaskedTextBox();
            groupBox_Gender = new GroupBox();
            radioButton_Female = new RadioButton();
            radioButton_Male = new RadioButton();
            label_Phone = new Label();
            button_Apply = new Button();
            button_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_Gender.SuspendLayout();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(73, 69);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(39, 15);
            label_Name.TabIndex = 2;
            label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(73, 43);
            textBox_Name.Name = "Name";
            textBox_Name.Size = new Size(146, 23);
            textBox_Name.TabIndex = 4;
            textBox_Name.Validating += textBox_Name_Validating;
            textBox_Name.Validated += textBox_Name_Validated;
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Location = new Point(73, 114);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(54, 15);
            label_Surname.TabIndex = 3;
            label_Surname.Text = "Surname";
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(73, 88);
            textBox_Surname.Name = "Surname";
            textBox_Surname.Size = new Size(146, 23);
            textBox_Surname.TabIndex = 5;
            textBox_Surname.Validating += textBox_Surname_Validating;
            textBox_Surname.Validated += textBox_Surname_Validated;
            // 
            // dateTimePicker_Birthday
            // 
            dateTimePicker_Birthday.Location = new Point(73, 141);
            dateTimePicker_Birthday.MaxDate = DateTime.Now;
            dateTimePicker_Birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker_Birthday.Name = "Birthday";
            dateTimePicker_Birthday.Size = new Size(146, 23);
            dateTimePicker_Birthday.TabIndex = 6;
            dateTimePicker_Birthday.ValueChanged += dateTimePicker_Birthday_ValueChanged;
            dateTimePicker_Birthday.Validating += dateTimePicker_Birthday_Validating;
            dateTimePicker_Birthday.Validated += dateTimePicker_Birthday_Validated;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(72, 196);
            textBox_Email.Name = "Email";
            textBox_Email.Size = new Size(147, 23);
            textBox_Email.TabIndex = 9;
            textBox_Email.Validating += textBox_Email_Validating;
            textBox_Email.Validated += textBox_Email_Validated;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(72, 222);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(41, 15);
            label_Email.TabIndex = 10;
            label_Email.Text = "E-mail";
            // 
            // label_Birthday
            // 
            label_Birthday.AutoSize = true;
            label_Birthday.Location = new Point(73, 167);
            label_Birthday.Name = "label_Birthday";
            label_Birthday.Size = new Size(51, 15);
            label_Birthday.TabIndex = 7;
            label_Birthday.Text = "Birthday";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Location = new Point(73, 278);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(41, 15);
            label_Phone.TabIndex = 12;
            label_Phone.Text = "Phone";
            // 
            // maskedTextBox_Phone
            // 
            maskedTextBox_Phone.Location = new Point(72, 252);
            maskedTextBox_Phone.Mask = "+7(999)000-00-00";
            maskedTextBox_Phone.Name = "Phone";
            maskedTextBox_Phone.Size = new Size(146, 23);
            maskedTextBox_Phone.TabIndex = 11;
            maskedTextBox_Phone.Validating += maskedTextBox_Phone_Validating;
            maskedTextBox_Phone.Validated += maskedTextBox_Phone_Validated;
            // 
            // groupBox_Gender
            // 
            groupBox_Gender.Controls.Add(radioButton_Female);
            groupBox_Gender.Controls.Add(radioButton_Male);
            groupBox_Gender.Location = new Point(73, 309);
            groupBox_Gender.Name = "Gender";
            groupBox_Gender.Size = new Size(142, 86);
            groupBox_Gender.TabIndex = 15;
            groupBox_Gender.TabStop = false;
            groupBox_Gender.Text = "Gender";
            groupBox_Gender.Validating += groupBox_Gender_Validating;
            groupBox_Gender.Validated += groupBox_Gender_Validated;
            // 
            // radioButton_Female
            // 
            radioButton_Female.AutoSize = true;
            radioButton_Female.Location = new Point(6, 57);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(61, 19);
            radioButton_Female.TabIndex = 1;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "female";
            radioButton_Female.UseVisualStyleBackColor = true;
            radioButton_Female.Click += radioButton_Female_Click;
            // 
            // radioButton_Male
            // 
            radioButton_Male.AutoSize = true;
            radioButton_Male.Location = new Point(6, 32);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(51, 19);
            radioButton_Male.TabIndex = 0;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "male";
            radioButton_Male.UseVisualStyleBackColor = true;
            radioButton_Male.Click += radioButton_Male_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listView_Preview
            // 
            listView_Preview.Columns.AddRange(new ColumnHeader[] { columnHeader_Property, columnHeader_Value });
            listViewItem_Name.Name = textBox_Name.Name;
            listViewItem_Name.Text = textBox_Name.Name;
            listViewSubItem_Name.Name = textBox_Name.Name;
            listViewItem_Name.SubItems.Add(listViewSubItem_Name);
            listViewItem_Surname.Name = textBox_Surname.Name;
            listViewItem_Surname.Text = textBox_Surname.Name;
            listViewSubItem_Surname.Name = textBox_Surname.Name;
            listViewItem_Surname.SubItems.Add(listViewSubItem_Surname);
            listViewItem_Birthday.Name = dateTimePicker_Birthday.Name;
            listViewItem_Birthday.Text = dateTimePicker_Birthday.Name;
            listViewSubItem_Birthday.Name = dateTimePicker_Birthday.Name;
            listViewItem_Birthday.SubItems.Add(listViewSubItem_Birthday);
            listViewItem_Email.Name = textBox_Email.Name;
            listViewItem_Email.Text = textBox_Email.Name;
            listViewSubItem_Email.Name = textBox_Email.Name;
            listViewItem_Email.SubItems.Add(listViewSubItem_Email);
            listViewItem_Phone.Name = maskedTextBox_Phone.Name;
            listViewItem_Phone.Text = maskedTextBox_Phone.Name;
            listViewSubItem_Phone.Name = maskedTextBox_Phone.Name;
            listViewItem_Phone.SubItems.Add(listViewSubItem_Phone);
            listViewItem_Gender.Name = groupBox_Gender.Text;
            listViewItem_Gender.Text = groupBox_Gender.Text;
            listViewSubItem_Gender.Name = groupBox_Gender.Text;
            listViewItem_Gender.SubItems.Add(listViewSubItem_Gender);
            listView_Preview.Items.AddRange(new ListViewItem[] { listViewItem_Name, listViewItem_Surname, listViewItem_Birthday, listViewItem_Email, listViewItem_Phone, listViewItem_Gender });
            listView_Preview.Location = new Point(314, 43);
            listView_Preview.Name = "listView_Preview";
            listView_Preview.Size = new Size(254, 207);
            listView_Preview.TabIndex = 8;
            listView_Preview.UseCompatibleStateImageBehavior = false;
            listView_Preview.View = View.Details;
            // 
            // columnHeader_Property
            // 
            columnHeader_Property.Text = "Property";
            columnHeader_Property.Width = 100;
            // 
            // columnHeader_Value
            // 
            columnHeader_Value.Text = "Value";
            columnHeader_Value.Width = 150;


            // 
            // button_Apply
            // 
            button_Apply.Location = new Point(314, 270);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(75, 23);
            button_Apply.TabIndex = 13;
            button_Apply.Text = "Apply";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button_Apply_Click;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(493, 270);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(75, 23);
            button_Save.TabIndex = 14;
            button_Save.Text = "Save as";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Enabled = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Gender);
            Controls.Add(button_Save);
            Controls.Add(button_Apply);
            Controls.Add(label_Phone);
            Controls.Add(maskedTextBox_Phone);
            Controls.Add(label_Email);
            Controls.Add(textBox_Email);
            Controls.Add(listView_Preview);
            Controls.Add(label_Birthday);
            Controls.Add(dateTimePicker_Birthday);
            Controls.Add(textBox_Surname);
            Controls.Add(textBox_Name);
            Controls.Add(label_Surname);
            Controls.Add(label_Name);
            Name = "Form1";
            Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_Gender.ResumeLayout(false);
            groupBox_Gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Name;
        private Label label_Surname;
        private TextBox textBox_Name;
        private TextBox textBox_Surname;
        private DateTimePicker dateTimePicker_Birthday;
        private Label label_Birthday;
        private ErrorProvider errorProvider1;
        private ListView listView_Preview;
        private ColumnHeader columnHeader_Property;
        private ColumnHeader columnHeader_Value;
        private ListViewItem listViewItem_Name;
        private ListViewItem.ListViewSubItem listViewSubItem_Name;
        private ListViewItem listViewItem_Surname;
        private ListViewItem.ListViewSubItem listViewSubItem_Surname;
        private ListViewItem listViewItem_Birthday;
        private ListViewItem.ListViewSubItem listViewSubItem_Birthday;
        private ListViewItem listViewItem_Email;
        private ListViewItem.ListViewSubItem listViewSubItem_Email;
        private ListViewItem listViewItem_Phone;
        private ListViewItem.ListViewSubItem listViewSubItem_Phone;
        private ListViewItem listViewItem_Gender;
        private ListViewItem.ListViewSubItem listViewSubItem_Gender;
        private Label label_Email;
        private TextBox textBox_Email;
        private MaskedTextBox maskedTextBox_Phone;
        private Label label_Phone;
        private Button button_Apply;
        private Button button_Save;
        private GroupBox groupBox_Gender;
        private RadioButton radioButton_Female;
        private RadioButton radioButton_Male;
    }
}