using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ManagerStarterForm : Form
    {
        public ManagerStarterForm()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemsForm form = new ItemsForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm form = new ClientsForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }
    }
}
