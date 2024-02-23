using Bank.DataModel;

namespace Bank
{
    partial class FormAddClient
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
            components = new System.ComponentModel.Container();
            label_Name = new Label();
            label_Surname = new Label();
            label_Birthday = new Label();
            label_Phone = new Label();
            label_Email = new Label();
            textBox_Name = new TextBox();
            textBox_Surname = new TextBox();
            dateTimePicker_Birthday = new DateTimePicker();
            maskedTextBox_Phone = new MaskedTextBox();
            textBox_Email = new TextBox();
            groupBox_Gender = new GroupBox();
            radioButton_Female = new RadioButton();
            radioButton_Male = new RadioButton();
            button_Apply = new Button();
            errorProvider1 = new ErrorProvider(components);
            label_Preview = new Label();
            groupBox_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(33, 39);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(39, 15);
            label_Name.TabIndex = 0;
            label_Name.Text = "Name";
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Location = new Point(33, 92);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(54, 15);
            label_Surname.TabIndex = 1;
            label_Surname.Text = "Surname";
            // 
            // label_Birthday
            // 
            label_Birthday.AutoSize = true;
            label_Birthday.Location = new Point(33, 149);
            label_Birthday.Name = "label_Birthday";
            label_Birthday.Size = new Size(51, 15);
            label_Birthday.TabIndex = 2;
            label_Birthday.Text = "Birthday";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Location = new Point(34, 211);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(41, 15);
            label_Phone.TabIndex = 3;
            label_Phone.Text = "Phone";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(34, 267);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(41, 15);
            label_Email.TabIndex = 4;
            label_Email.Text = "E-mail";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(34, 57);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(165, 23);
            textBox_Name.TabIndex = 5;
            textBox_Name.Validating += textBox_Name_Validating;
            textBox_Name.Validated += textBox_Name_Validated;
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(33, 110);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(165, 23);
            textBox_Surname.TabIndex = 6;
            textBox_Surname.Validating += textBox_Surname_Validating;
            textBox_Surname.Validated += textBox_Surname_Validated;
            // 
            // dateTimePicker_Birthday
            // 
            dateTimePicker_Birthday.Location = new Point(34, 167);
            dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            dateTimePicker_Birthday.Size = new Size(165, 23);
            dateTimePicker_Birthday.TabIndex = 7;
            dateTimePicker_Birthday.ValueChanged += dateTimePicker_Birthday_ValueChanged;
            dateTimePicker_Birthday.Validating += dateTimePicker_Birthday_Validating;
            dateTimePicker_Birthday.Validated += dateTimePicker_Birthday_Validated;
            // 
            // maskedTextBox_Phone
            // 
            maskedTextBox_Phone.Location = new Point(33, 229);
            maskedTextBox_Phone.Mask = "+7(999)000-00-00";
            maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            maskedTextBox_Phone.Size = new Size(165, 23);
            maskedTextBox_Phone.TabIndex = 8;
            maskedTextBox_Phone.Validating += maskedTextBox_Phone_Validating;
            maskedTextBox_Phone.Validated += maskedTextBox_Phone_Validated;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(33, 285);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(166, 23);
            textBox_Email.TabIndex = 9;
            textBox_Email.Validating += textBox_Email_Validating;
            textBox_Email.Validated += textBox_Email_Validated;
            // 
            // groupBox_Gender
            // 
            groupBox_Gender.Controls.Add(radioButton_Female);
            groupBox_Gender.Controls.Add(radioButton_Male);
            groupBox_Gender.Location = new Point(34, 330);
            groupBox_Gender.Name = "groupBox_Gender";
            groupBox_Gender.Size = new Size(165, 83);
            groupBox_Gender.TabIndex = 10;
            groupBox_Gender.TabStop = false;
            groupBox_Gender.Text = "Gender";
            groupBox_Gender.Validating += groupBox_Gender_Validating;
            groupBox_Gender.Validated += groupBox_Gender_Validated;
            // 
            // radioButton_Female
            // 
            radioButton_Female.AutoSize = true;
            radioButton_Female.Location = new Point(6, 47);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(61, 19);
            radioButton_Female.TabIndex = 12;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "female";
            radioButton_Female.UseVisualStyleBackColor = true;
            radioButton_Female.Click += radioButton_Female_Click;
            // 
            // radioButton_Male
            // 
            radioButton_Male.AutoSize = true;
            radioButton_Male.Location = new Point(6, 22);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(51, 19);
            radioButton_Male.TabIndex = 11;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "male";
            radioButton_Male.UseVisualStyleBackColor = true;
            radioButton_Male.Click += radioButton_Male_Click;
            // 
            // button_Apply
            // 
            button_Apply.Location = new Point(359, 390);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(75, 23);
            button_Apply.TabIndex = 11;
            button_Apply.Text = "Apply";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // 
            // label_Preview
            // 
            label_Preview.AutoSize = true;
            label_Preview.Location = new Point(267, 39);
            label_Preview.Name = "label_Preview";
            label_Preview.Size = new Size(48, 15);
            label_Preview.TabIndex = 13;
            label_Preview.Text = "Preview";
            // 
            // FormAddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 453);
            Controls.Add(label_Preview);
            Controls.Add(button_Apply);
            Controls.Add(groupBox_Gender);
            Controls.Add(textBox_Email);
            Controls.Add(maskedTextBox_Phone);
            Controls.Add(dateTimePicker_Birthday);
            Controls.Add(textBox_Surname);
            Controls.Add(textBox_Name);
            Controls.Add(label_Email);
            Controls.Add(label_Phone);
            Controls.Add(label_Birthday);
            Controls.Add(label_Surname);
            Controls.Add(label_Name);
            Name = "FormAddClient";
            Text = "FormAddClient";
            groupBox_Gender.ResumeLayout(false);
            groupBox_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_Surname;
        private Label label_Birthday;
        private Label label_Phone;
        private Label label_Email;
        private TextBox textBox_Name;
        private TextBox textBox_Surname;
        private DateTimePicker dateTimePicker_Birthday;
        private MaskedTextBox maskedTextBox_Phone;
        private TextBox textBox_Email;
        private GroupBox groupBox_Gender;
        private RadioButton radioButton_Female;
        private RadioButton radioButton_Male;
        private Button button_Apply;
        private ErrorProvider errorProvider1;
        private Label label_Preview;
        private Client client;
    }
}