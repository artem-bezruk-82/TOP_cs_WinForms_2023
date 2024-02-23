using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public partial class FormAddClient : Form
    {
        private ListView? listView_Preview;
        private ColumnHeader? columnHeader_Property;
        private ColumnHeader? columnHeader_Value;
        private ListViewItem? listViewItem_Name;
        private ListViewItem.ListViewSubItem? listViewSubItem_Name;
        private ListViewItem? listViewItem_Surname;
        private ListViewItem.ListViewSubItem? listViewSubItem_Surname;
        private ListViewItem? listViewItem_Birthday;
        private ListViewItem.ListViewSubItem? listViewSubItem_Birthday;
        private ListViewItem? listViewItem_Email;
        private ListViewItem.ListViewSubItem? listViewSubItem_Email;
        private ListViewItem? listViewItem_Phone;
        private ListViewItem.ListViewSubItem? listViewSubItem_Phone;
        private ListViewItem? listViewItem_Gender;
        private ListViewItem.ListViewSubItem? listViewSubItem_Gender;

        private void InitializePeview() 
        {
            listView_Preview = new ListView();
            columnHeader_Property = new ColumnHeader();
            columnHeader_Value = new ColumnHeader();
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

            columnHeader_Property.Text = "Property";
            columnHeader_Property.Width = 80;

            columnHeader_Value.Text = "Value";
            columnHeader_Value.Width = 180;

            listViewItem_Name.Text = "Name";
            listViewItem_Surname.Text = "Surname";
            listViewItem_Birthday.Text = "Birthday";
            listViewItem_Email.Text = "Email";
            listViewItem_Phone.Text = "Phone";
            listViewItem_Gender.Text = "Gender";

            listViewSubItem_Name.Text = "";

            listViewItem_Name.SubItems.Add(listViewSubItem_Name);
            listViewItem_Surname.SubItems.Add(listViewSubItem_Surname);
            listViewItem_Birthday.SubItems.Add(listViewSubItem_Birthday);
            listViewItem_Email.SubItems.Add(listViewSubItem_Email);
            listViewItem_Phone.SubItems.Add(listViewSubItem_Phone);
            listViewItem_Gender.SubItems.Add(listViewSubItem_Gender);

            listView_Preview.Columns.AddRange(new ColumnHeader[] { columnHeader_Property, columnHeader_Value });
            listView_Preview.Items.AddRange(new ListViewItem[] {
                listViewItem_Name, listViewItem_Surname, listViewItem_Birthday,  
                listViewItem_Phone, listViewItem_Email, listViewItem_Gender 
            });
            listView_Preview.Location = new Point(267, 57);
            listView_Preview.Name = "listView_Preview";
            listView_Preview.Size = new Size(265, 251);
            listView_Preview.TabIndex = 12;
            listView_Preview.UseCompatibleStateImageBehavior = false;
            listView_Preview.View = View.Details;

            Controls.Add(listView_Preview);
        }
    }
}
