using Bank.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
            InitializePeview();
            client = new DataModel.Client();
        }


        private void textBox_Name_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;
            if (!TextIsValid(textBox_Name.Text, out errorMessage))
            {
                label_Name.ForeColor = Color.Red;
                textBox_Name.BackColor = Color.Pink;
                e.Cancel = true;
                errorProvider1.SetError(textBox_Name, errorMessage);
            }
        }

        private void textBox_Name_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_Name, string.Empty);
            label_Name.ForeColor = Color.Green;
            textBox_Name.BackColor = Color.White;
            listViewSubItem_Name.Text = textBox_Name.Text;
        }

        private void textBox_Surname_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;
            if (!TextIsValid(textBox_Surname.Text, out errorMessage))
            {
                label_Surname.ForeColor = Color.Red;
                textBox_Surname.BackColor = Color.Pink;
                e.Cancel = true;
                errorProvider1.SetError(textBox_Surname, errorMessage);
            }
        }

        private void textBox_Surname_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_Surname, string.Empty);
            label_Surname.ForeColor = Color.Green;
            textBox_Surname.BackColor = Color.White;
            listViewSubItem_Surname.Text = textBox_Surname.Text;
        }

        private bool TextIsValid(string inputText, out string errorMessage)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(inputText, @"^[a-zA-Z]+$"))
            {
                if (string.IsNullOrEmpty(inputText))
                    errorMessage = "Could not be empty";
                else
                    errorMessage = "Please enter letters only";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        private void dateTimePicker_Birthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker_Birthday.Value;
            listViewSubItem_Birthday.Text = date.ToShortDateString();
        }

        private void dateTimePicker_Birthday_Validating(object sender, CancelEventArgs e)
        {
            if (!dateTimePicker_Birthday.Checked)
            {
                label_Birthday.ForeColor = Color.Red;
                errorProvider1.SetError(dateTimePicker_Birthday, "Chose date");
            }
        }

        private void dateTimePicker_Birthday_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dateTimePicker_Birthday, string.Empty);
            label_Birthday.ForeColor = Color.Green;
        }

        private void maskedTextBox_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (!maskedTextBox_Phone.MaskFull)
            {
                label_Phone.ForeColor = Color.Red;
                maskedTextBox_Phone.BackColor = Color.Pink;
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBox_Phone, "Phone number input required");
            }
        }

        private void maskedTextBox_Phone_Validated(object sender, EventArgs e)
        {
            label_Phone.ForeColor = Color.Green;
            maskedTextBox_Phone.BackColor = Color.White;
            errorProvider1.SetError(maskedTextBox_Phone, string.Empty);
            listViewSubItem_Phone.Text = maskedTextBox_Phone.Text;
        }

        private bool EmailIsValid(string address, out string errorMessage)
        {
            if (address.Length == 0)
            {
                errorMessage = "E-mail address is required.";
                return false;
            }

            if (address.IndexOf("@") > -1)
            {
                if (address.IndexOf(".", address.IndexOf("@")) > address.IndexOf("@"))
                {
                    errorMessage = string.Empty;
                    return true;
                }
            }

            errorMessage = "e-mail address must be in valid email address format.\n" +
               "For example: 'someone@example.com' ";
            return false;
        }

        private void textBox_Email_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;
            if (!EmailIsValid(textBox_Email.Text, out errorMessage))
            {
                label_Email.ForeColor = Color.Red;
                textBox_Email.BackColor = Color.Pink;
                e.Cancel = true;
                errorProvider1.SetError(textBox_Email, errorMessage);
            }
        }

        private void textBox_Email_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_Email, string.Empty);
            label_Email.ForeColor = Color.Green;
            textBox_Email.BackColor = Color.White;
            listViewSubItem_Email.Text = textBox_Email.Text;
        }

        private void radioButton_Male_Click(object sender, EventArgs e)
        {
            listViewSubItem_Gender.Text = radioButton_Male.Text;
        }

        private void radioButton_Female_Click(object sender, EventArgs e)
        {
            listViewSubItem_Gender.Text = radioButton_Female.Text;
        }

        private void groupBox_Gender_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButton_Male.Checked && !radioButton_Female.Checked)
            {
                groupBox_Gender.ForeColor = Color.Red;
                errorProvider1.SetError(groupBox_Gender, "Please state your gender");
            }
        }

        private void groupBox_Gender_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(groupBox_Gender, string.Empty);
            groupBox_Gender.ForeColor = Color.Green;
        }



        private bool PreviewIsCompleted()
        {
            foreach (ListViewItem item in listView_Preview.Items)
            {
                string errorMessage = "Could not be empty";
                string itemName = item.Text;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    string subitemText = subItem.Text;
                    if (string.IsNullOrEmpty(subitemText))
                    {
                        switch (itemName)
                        {
                            case "Name":
                                errorProvider1.SetError(textBox_Name, errorMessage);
                                break;
                            case "Surname":
                                errorProvider1.SetError(textBox_Surname, errorMessage);
                                break;
                            case "Birthday":
                                errorProvider1.SetError(dateTimePicker_Birthday, errorMessage);
                                break;
                            case "Email":
                                errorProvider1.SetError(textBox_Email, errorMessage);
                                break;
                            case "Phone":
                                errorProvider1.SetError(maskedTextBox_Phone, errorMessage);
                                break;
                            case "Gender":
                                errorProvider1.SetError(groupBox_Gender, errorMessage);
                                break;
                            default:
                                break;
                        }
                        return false;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PreviewIsCompleted())
            {
                
                client.Name = listViewSubItem_Name.Text;
                client.Surname = listViewSubItem_Surname.Text;
                client.DateOfBirth = listViewSubItem_Birthday.Text;
                client.Phone = listViewSubItem_Phone.Text;
                client.Email = listViewSubItem_Email.Text;
                client.Gender = listViewSubItem_Gender.Text;
                using (BankContext db = new BankContext()) 
                {
                    db.Add(client);
                    db.SaveChanges();
                }
                MessageBox.Show("Thank you!");
                this.Close();
            }
        }
    }
}
