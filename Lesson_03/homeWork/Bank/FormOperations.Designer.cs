using Bank.DataModel;

namespace Bank
{
    partial class FormOperations
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
            label_Account = new Label();
            textBox_Value = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label_Value = new Label();
            button_Put = new Button();
            button_Take = new Button();
            button_Ok = new Button();
            label_History = new Label();
            listView_History = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_Type = new ColumnHeader();
            columnHeader_Amount = new ColumnHeader();
            columnHeader_Timestamp = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label_Account
            // 
            label_Account.AutoSize = true;
            label_Account.Location = new Point(12, 9);
            label_Account.Name = "label_Account";
            label_Account.Size = new Size(38, 15);
            label_Account.TabIndex = 0;
            label_Account.Text = "label1";
            // 
            // textBox_Value
            // 
            textBox_Value.Location = new Point(175, 6);
            textBox_Value.Name = "textBox_Value";
            textBox_Value.Size = new Size(108, 23);
            textBox_Value.TabIndex = 1;
            textBox_Value.Validating += textBox_Value_Validating;
            textBox_Value.Validated += textBox_Value_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label_Value
            // 
            label_Value.AutoSize = true;
            label_Value.Location = new Point(131, 9);
            label_Value.Name = "label_Value";
            label_Value.Size = new Size(38, 15);
            label_Value.TabIndex = 2;
            label_Value.Text = "Value:";
            // 
            // button_Put
            // 
            button_Put.Location = new Point(298, 6);
            button_Put.Name = "button_Put";
            button_Put.Size = new Size(75, 23);
            button_Put.TabIndex = 3;
            button_Put.Text = "Put";
            button_Put.UseVisualStyleBackColor = true;
            button_Put.Click += button_Put_Click;
            // 
            // button_Take
            // 
            button_Take.Location = new Point(379, 6);
            button_Take.Name = "button_Take";
            button_Take.Size = new Size(75, 23);
            button_Take.TabIndex = 4;
            button_Take.Text = "Take";
            button_Take.UseVisualStyleBackColor = true;
            button_Take.Click += button_Take_Click;
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(379, 61);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 5;
            button_Ok.Text = "OK";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // label_History
            // 
            label_History.AutoSize = true;
            label_History.Location = new Point(217, 83);
            label_History.Name = "label_History";
            label_History.Size = new Size(45, 15);
            label_History.TabIndex = 7;
            label_History.Text = "History";
            // 
            // listView_History
            // 
            listView_History.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_Type, columnHeader_Amount, columnHeader_Timestamp });
            listView_History.Location = new Point(12, 101);
            listView_History.Name = "listView_History";
            listView_History.Size = new Size(442, 196);
            listView_History.TabIndex = 8;
            listView_History.UseCompatibleStateImageBehavior = false;
            listView_History.View = View.Details;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "Id";
            // 
            // columnHeader_Type
            // 
            columnHeader_Type.Text = "Operation";
            columnHeader_Type.Width = 70;
            // 
            // columnHeader_Amount
            // 
            columnHeader_Amount.DisplayIndex = 3;
            columnHeader_Amount.Text = "Timestamp";
            columnHeader_Amount.Width = 120;
            // 
            // columnHeader_Timestamp
            // 
            columnHeader_Timestamp.DisplayIndex = 2;
            columnHeader_Timestamp.Text = "Amount";
            columnHeader_Timestamp.Width = 180;
            // 
            // FormOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 309);
            Controls.Add(listView_History);
            Controls.Add(label_History);
            Controls.Add(button_Ok);
            Controls.Add(button_Take);
            Controls.Add(button_Put);
            Controls.Add(label_Value);
            Controls.Add(textBox_Value);
            Controls.Add(label_Account);
            Name = "FormOperations";
            Text = "FormOperations";
            Load += FormOperations_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Account;

        private Account account;
        private TextBox textBox_Value;
        private ErrorProvider errorProvider1;
        private Label label_Value;
        private Button button_Take;
        private Button button_Put;
        private Button button_Ok;
        private ListView listView_History;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_Type;
        private ColumnHeader columnHeader_Timestamp;
        private Label label_History;
        private ColumnHeader columnHeader_Amount;
    }
}