using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class WorkerEditForm : Form
    {
        private string action;
        private int id = 0;

        public WorkerEditForm()
        {
            InitializeComponent();
            action = "add";
            Text = "Додавання нового робітника";
            btnAddEdit.Text = "Додати";
        }
        public WorkerEditForm(int id)
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
