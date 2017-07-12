namespace MyFirstMvcDemo
{
    partial class Contacts
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_contacts = new System.Windows.Forms.Button();
            this.modify_contacts = new System.Windows.Forms.Button();
            this.add_contacts = new System.Windows.Forms.Button();
            this.query_contacts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contactsDataSet = new MyFirstMvcDemo.contactsDataSet();
            this.contactsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new MyFirstMvcDemo.contactsDataSetTableAdapters.contactsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_contacts);
            this.groupBox1.Controls.Add(this.modify_contacts);
            this.groupBox1.Controls.Add(this.add_contacts);
            this.groupBox1.Controls.Add(this.query_contacts);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件";
            // 
            // delete_contacts
            // 
            this.delete_contacts.Location = new System.Drawing.Point(524, 19);
            this.delete_contacts.Name = "delete_contacts";
            this.delete_contacts.Size = new System.Drawing.Size(75, 23);
            this.delete_contacts.TabIndex = 4;
            this.delete_contacts.Text = "删除";
            this.delete_contacts.UseVisualStyleBackColor = true;
            // 
            // modify_contacts
            // 
            this.modify_contacts.Location = new System.Drawing.Point(425, 20);
            this.modify_contacts.Name = "modify_contacts";
            this.modify_contacts.Size = new System.Drawing.Size(75, 23);
            this.modify_contacts.TabIndex = 3;
            this.modify_contacts.Text = "修改";
            this.modify_contacts.UseVisualStyleBackColor = true;
            // 
            // add_contacts
            // 
            this.add_contacts.Location = new System.Drawing.Point(331, 21);
            this.add_contacts.Name = "add_contacts";
            this.add_contacts.Size = new System.Drawing.Size(75, 23);
            this.add_contacts.TabIndex = 2;
            this.add_contacts.Text = "添加";
            this.add_contacts.UseVisualStyleBackColor = true;
            this.add_contacts.Click += new System.EventHandler(this.add_contacts_Click);
            // 
            // query_contacts
            // 
            this.query_contacts.Location = new System.Drawing.Point(229, 21);
            this.query_contacts.Name = "query_contacts";
            this.query_contacts.Size = new System.Drawing.Size(75, 23);
            this.query_contacts.TabIndex = 1;
            this.query_contacts.Text = "查找";
            this.query_contacts.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 21);
            this.textBox1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.contactsBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 71);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(726, 364);
            this.dgv.TabIndex = 1;
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "contactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsDataSetBindingSource
            // 
            this.contactsDataSetBindingSource.DataSource = this.contactsDataSet;
            this.contactsDataSetBindingSource.Position = 0;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.contactsDataSetBindingSource;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "主键";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "手机";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "联系地址";
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通信录";
            this.Load += new System.EventHandler(this.Contacts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_contacts;
        private System.Windows.Forms.Button modify_contacts;
        private System.Windows.Forms.Button add_contacts;
        private System.Windows.Forms.Button query_contacts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource contactsDataSetBindingSource;
        private contactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private contactsDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
    }
}