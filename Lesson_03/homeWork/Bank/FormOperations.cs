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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class FormOperations : Form
    {
        public FormOperations() : this(new Account()) { }

        public FormOperations(Account? account)
        {
            InitializeComponent();
            this.account = account;
            this.account.OnBalanceChanged += Account_OnBalanceChanged;
            this.account.Notify += Account_Notify;
        }

        private void Account_Notify(string message)
        {
            MessageBox.Show(message);
        }

        private void FormOperations_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void textBox_Value_Validating(object sender, CancelEventArgs e)
        {
            string? input = textBox_Value.Text;
            double sum;
            string errorMessage;

            if (!InputIsValid(input, out errorMessage, out sum))
            {
                e.Cancel = true;
                textBox_Value.BackColor = Color.Pink;
                errorProvider1.SetError(textBox_Value, errorMessage);
            }
        }

        private void textBox_Value_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_Value, string.Empty);
            textBox_Value.BackColor = Color.White;
        }

        private bool InputIsValid(string input, out string errorMessage, out double value)
        {
            if (!double.TryParse(input, out value))
            {
                errorMessage = "Please enter decimal value";
                return false;
            }
            else if (value < 0)
            {
                errorMessage = "Value could not be less than zero";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        private void Account_OnBalanceChanged(double value, double balance)
        {
            using (BankContext db = new BankContext())
            {
                Account accountToUpdate = db.Accounts.First(a => a.Id == this.account.Id);
                if (accountToUpdate != null) 
                {
                    accountToUpdate.Balance = this.account.Balance;
                }

                History record = new History();
                record.Name = (value >= 0) ? "charge" : "charge-off";
                record.Amount = Math.Abs(value);
                record.Date = DateTime.Now.ToString();
                record.AccountId = this.account.Id;
                db.Histories.Add(record);
                
                db.SaveChanges();
            }
        }

        private void button_Put_Click(object sender, EventArgs e)
        {
            account.Put(Math.Round(double.Parse(textBox_Value.Text), 2));
            RefreshForm();
        }

        private void button_Take_Click(object sender, EventArgs e)
        {
            account.Take(Math.Round(double.Parse(textBox_Value.Text), 2));
            RefreshForm();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ListView_History_Draw()
        {
            listView_History.Items.Clear();
            foreach (History record in account.Histories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = record.Id.ToString();
                item.SubItems.AddRange(new []{record.Name, record.Date, record.Amount.ToString()});
                listView_History.Items.Add(item);
            }
        }

        private void RefreshForm() 
        {
            label_Account.Text = account.ToString();
            LoadHistoryFromDB();
            ListView_History_Draw();
        }

        private void LoadHistoryFromDB()
        {
            account.Histories.Clear();
            using (BankContext db = new BankContext())
            {
                account.Histories = db.Histories.Where(h => h.AccountId == account.Id).ToList();
            }
        }
    }
}
