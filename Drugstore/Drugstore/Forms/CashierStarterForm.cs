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
    public partial class CashierStarterForm : Form
    {
        public CashierStarterForm()
        {
            InitializeComponent();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            ItemsForm form = new ItemsForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            ItemSellForm form = new ItemSellForm();
            form.TopLevel = false;
            form.MdiParent = (MainForm)Parent.Parent;
            form.Show();
            Close();
        }
    }
}
