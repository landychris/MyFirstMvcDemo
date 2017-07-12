using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstMvcDemo
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void add_contacts_Click(object sender, EventArgs e)
        {
            AddContactsForm addContactsForm = new AddContactsForm();
            addContactsForm.Show();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“contactsDataSet.contacts”中。您可以根据需要移动或删除它。
            this.contactsTableAdapter.Fill(this.contactsDataSet.contacts);

        }
    }
}
