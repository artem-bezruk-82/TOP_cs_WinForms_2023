using Bank.DataModel;

namespace Bank
{
    partial class FormAccounts
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
            label_ClientData = new Label();
            listView_Accounts = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_Balance = new ColumnHeader();
            button_Add = new Button();
            button_Delete = new Button();
            label_Accounts = new Label();
            SuspendLayout();
            // 
            // label_ClientData
            // 
            label_ClientData.AutoSize = true;
            label_ClientData.Location = new Point(12, 9);
            label_ClientData.Name = "label_ClientData";
            label_ClientData.Size = new Size(38, 15);
            label_ClientData.TabIndex = 0;
            label_ClientData.Text = "label1";
            // 
            // listView_Accounts
            // 
            listView_Accounts.CheckBoxes = true;
            listView_Accounts.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_Balance });
            listView_Accounts.FullRowSelect = true;
            listView_Accounts.Location = new Point(12, 129);
            listView_Accounts.MultiSelect = false;
            listView_Accounts.Name = "listView_Accounts";
            listView_Accounts.Size = new Size(185, 129);
            listView_Accounts.TabIndex = 1;
            listView_Accounts.UseCompatibleStateImageBehavior = false;
            listView_Accounts.View = View.Details;
            listView_Accounts.Activation = ItemActivation.Standard;
            listView_Accounts.ItemChecked += ListView_Accounts_ItemChecked;
            listView_Accounts.ItemActivate += ListView_Accounts_ItemActivate;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "Id";
            // 
            // columnHeader_Balance
            // 
            columnHeader_Balance.Text = "Balance";
            columnHeader_Balance.Width = 120;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 264);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(122, 264);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 3;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // label_Accounts
            // 
            label_Accounts.AutoSize = true;
            label_Accounts.Location = new Point(72, 111);
            label_Accounts.Name = "label_Accounts";
            label_Accounts.Size = new Size(57, 15);
            label_Accounts.TabIndex = 4;
            label_Accounts.Text = "Accounts";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 350);
            Controls.Add(label_Accounts);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(listView_Accounts);
            Controls.Add(label_ClientData);
            Name = "Form1";
            Text = "FormAccounts";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ClientData;

        private Client client;
        private ListView listView_Accounts;
        private Button button_Add;
        private Button button_Delete;
        private Label label_Accounts;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_Balance;
    }
}