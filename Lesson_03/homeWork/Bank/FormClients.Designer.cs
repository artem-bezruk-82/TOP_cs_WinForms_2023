using System.Configuration;

namespace Bank
{
    partial class FormClients
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
            label1 = new Label();
            button_AddClient = new Button();
            button_DeleteClient = new Button();
            listView1 = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_Name = new ColumnHeader();
            columnHeader_Surname = new ColumnHeader();
            columnHeader_Birthday = new ColumnHeader();
            columnHeader_Phone = new ColumnHeader();
            columnHeader_Email = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 45);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Clients";
            // 
            // button_AddClient
            // 
            button_AddClient.Location = new Point(35, 351);
            button_AddClient.Name = "button_AddClient";
            button_AddClient.Size = new Size(93, 23);
            button_AddClient.TabIndex = 2;
            button_AddClient.Text = "Add";
            button_AddClient.UseVisualStyleBackColor = true;
            button_AddClient.Click += button_AddClient_Click;
            // 
            // button_DeleteClient
            // 
            button_DeleteClient.Location = new Point(670, 351);
            button_DeleteClient.Name = "button_DeleteClient";
            button_DeleteClient.Size = new Size(93, 23);
            button_DeleteClient.TabIndex = 2;
            button_DeleteClient.Text = "Delete";
            button_DeleteClient.UseVisualStyleBackColor = true;
            button_DeleteClient.Enabled = true;
            button_DeleteClient.Click += button_DeleteClient_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_Name, columnHeader_Surname, columnHeader_Birthday, columnHeader_Phone, columnHeader_Email });
            listView1.Location = new Point(35, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(728, 228);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
            listView1.CheckBoxes = true;
            listView1.Activation = ItemActivation.Standard;
            listView1.ItemChecked += ListView1_ItemChecked;
            listView1.ItemActivate += ListView1_ItemActivate;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "Id";
            // 
            // columnHeader_Name
            // 
            columnHeader_Name.Text = "Name";
            columnHeader_Name.Width = 150;
            // 
            // columnHeader_Surname
            // 
            columnHeader_Surname.Text = "Surname";
            columnHeader_Surname.Width = 150;
            // 
            // columnHeader_Birthday
            // 
            columnHeader_Birthday.Text = "Birthday";
            columnHeader_Birthday.Width = 80;
            // 
            // columnHeader_Phone
            // 
            columnHeader_Phone.Text = "Phone";
            columnHeader_Phone.Width = 110;
            // 
            // columnHeader_Email
            // 
            columnHeader_Email.Text = "Email";
            columnHeader_Email.Width = 200;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button_AddClient);
            Controls.Add(button_DeleteClient);
            Controls.Add(label1);
            Name = "Clients";
            Text = "Clients";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label label1;
        private Button button_AddClient;
        private Button button_DeleteClient;
        private ListView listView1;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_Name;
        private ColumnHeader columnHeader_Surname;
        private ColumnHeader columnHeader_Birthday;
        private ColumnHeader columnHeader_Phone;
        private ColumnHeader columnHeader_Email;
        private List<DataModel.Client> clients = new List<DataModel.Client>(); 
    }
}
