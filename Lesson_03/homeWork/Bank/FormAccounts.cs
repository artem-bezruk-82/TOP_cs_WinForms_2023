using Bank.DataModel;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormAccounts : Form
    {


        public FormAccounts(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        public FormAccounts() : this(new DataModel.Client()) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_ClientData.Text = client.ToString();
            RefreshForm();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddAccoutToDB();
            RefreshForm();
        }

        private void ListView_Accounts_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection selectedItems =
                this.listView_Accounts.SelectedItems;
            if (selectedItems.Count == 1)
            {
                int accountId = int.Parse(selectedItems[0].Text);
                Account? account = client.Accounts.FirstOrDefault(a => a.Id == accountId);
                if (account != null)
                {
                    FormOperations formOperations = new FormOperations(account);
                    if (formOperations.ShowDialog() == DialogResult.OK) 
                    {
                        RefreshForm();
                    }
                }
            }
        }

        private void ListView_Accounts_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (listView_Accounts.CheckedItems.Count > 0)
            {
                button_Delete.Enabled = true;
                button_Add.Enabled = false;
            }
            else
            {
                button_Delete.Enabled = false;
                button_Add.Enabled = true;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string prompt = $"{listView_Accounts.CheckedItems.Count} accounts are going to be deleted. Are you sure?";
            if (listView_Accounts.CheckedItems.Count > 0)
            {
                if (MessageBox.Show(prompt, "Delete operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    int clientsDeleted = DeleteAccountFromDB(GetCheckedAccountIdArray());
                    RefreshForm();
                    MessageBox.Show($"{clientsDeleted} accounts deleted");
                }
            }
        }

        private void ListView_Accounts_Draw()
        {
            listView_Accounts.Items.Clear();
            foreach (Account account in client.Accounts)
            {
                ListViewItem item = new ListViewItem();
                item.Text = account.Id.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, account.Balance.ToString()));
                listView_Accounts.Items.Add(item);
            }
        }

        private void LoadAccountsFromDB()
        {
            client.Accounts.Clear();
            using (BankContext db = new BankContext())
            {
                client.Accounts = db.Accounts.Where(a => a.ClientId == client.Id).ToList();
            }
        }

        private void AddAccoutToDB()
        {
            using (BankContext db = new BankContext())
            {
                Account account = new Account();
                account.ClientId = client.Id;
                db.Accounts.Add(account);
                db.SaveChanges();
            }
        }

        private int[] GetCheckedAccountIdArray()
        {
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedItems =
                this.listView_Accounts.CheckedItems;
            List<int> accoutIdList = new List<int>();
            foreach (ListViewItem checkedItem in checkedItems)
            {
                accoutIdList.Add(int.Parse(checkedItem.Text));
            }
            return accoutIdList.ToArray();
        }

        private int DeleteAccountFromDB(int[] indices)
        {
            int counter = 0;
            using (BankContext db = new BankContext())
            {
                foreach (int index in indices)
                {
                    Account? account = db.Accounts.FirstOrDefault(a => a.Id == index);
                    if (account != null)
                    {
                        db.Accounts.Remove(account);
                        counter++;
                    }
                }
                db.SaveChanges();
            }
            return counter;
        }

        private void RefreshForm() 
        {
            LoadAccountsFromDB();
            ListView_Accounts_Draw();
        }
    }
}
