using Bank.DataModel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClientsFromDB();
            ListView_DrawClients();
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            FormAddClient addClient = new FormAddClient();
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                LoadClientsFromDB();
                ListView_DrawClients();
            }
        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = this.listView1.SelectedItems;
            if (selectedItems.Count == 1) 
            {
                int clientId = int.Parse(selectedItems[0].Text);
                Client? client = clients.Find(c => c.Id == clientId);
                if (client != null) 
                {
                    FormAccounts formAccounts = new FormAccounts(client);
                    formAccounts.Show();
                }
            }

        }

        private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (listView1.CheckedItems.Count > 0) 
            {
                button_DeleteClient.Enabled = true;
                button_AddClient.Enabled = false;
            } else 
            {
                button_DeleteClient.Enabled = false;
                button_AddClient.Enabled = true;
            }
        }

        private void button_DeleteClient_Click(object sender, EventArgs e) 
        {
            string prompt = $"{listView1.CheckedItems.Count} clients are going to be deleted. Are you sure?";
            if (listView1.CheckedItems.Count > 0) 
            {
                if (MessageBox.Show(prompt, "Delete operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) 
                    == DialogResult.OK) 
                {
                    int clientsDeleted = DeleteClientsFromBD(GetCheckedClientIdArray());
                    LoadClientsFromDB();
                    ListView_DrawClients();
                    MessageBox.Show($"{clientsDeleted} clients deleted");
                }
            }
        }

        private int[] GetCheckedClientIdArray() 
        {
            ListView.CheckedListViewItemCollection checkedItems = this.listView1.CheckedItems;
            List<int> clientIdList = new List<int>();
            foreach (ListViewItem checkedItem in checkedItems)
            {
                clientIdList.Add(int.Parse(checkedItem.Text));
            }
            return clientIdList.ToArray();
        }

        private void LoadClientsFromDB() 
        {
            clients.Clear();
            using (BankContext db = new BankContext())
            {
                clients = db.Clients.ToList();
            }
        }

        private int DeleteClientsFromBD(int[] indices) 
        {
            int counter = 0;  
            using (BankContext db = new BankContext()) 
            {
                foreach (int index in indices) 
                {
                    Client? client = db.Clients.FirstOrDefault(c => c.Id == index);
                    if (client != null) 
                    {
                        db.Clients.Remove(client);
                        counter++;
                    }
                }
                db.SaveChanges();
            }
            return counter;
        }

        private void ListView_DrawClients() 
        {
            listView1.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.Id.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, client.Name));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, client.Surname));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, client.DateOfBirth));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, client.Phone));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, client.Email));
                listView1.Items.Add(item);
            }
        }
    }
}
