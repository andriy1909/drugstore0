using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ClientEditForm : Form
    {
        private string action;
        private int id = 0;

        public ClientEditForm()
        {
            InitializeComponent();
            action = "add";
            Text = "Додавання нового клієнта";
            btnAddEdit.Text = "Додати";
        }
        public ClientEditForm(int id)
        {
            InitializeComponent();
            this.id = id;
            action = "edit";
            Text = "Редагування";
            btnAddEdit.Text = "Редагувати";
        }
        private void add()
        {
        }
        private void edit()
        {

        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (action == "edit")
                edit();
            else
                add();
        }
    }
}
