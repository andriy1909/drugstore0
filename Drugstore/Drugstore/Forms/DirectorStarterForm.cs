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
    public partial class DirectorStarterForm : Form
    {
        public DirectorStarterForm()
        {
            InitializeComponent();
        }

        private void btnContWorkers_Click(object sender, EventArgs e)
        {
            WorkersForm form = new WorkersForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }

        private void btnContItems_Click(object sender, EventArgs e)
        {
            ItemsForm form = new ItemsForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }

        private void btnContClients_Click(object sender, EventArgs e)
        {
            ClientsForm form = new ClientsForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }
    }
}
