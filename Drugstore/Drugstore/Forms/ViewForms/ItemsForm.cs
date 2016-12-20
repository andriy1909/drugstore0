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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            dataGridView1.DataSource = Items.getAllItems().Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemEditForm addItemForm = new ItemEditForm();
            addItemForm.TopLevel = false;
            addItemForm.MdiParent = (MainForm)Parent.Parent;
            addItemForm.FormClosing += AddEditItemForm_FormClosing;
            addItemForm.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ItemEditForm editItemForm = new ItemEditForm(index);
            editItemForm.TopLevel = false;
            editItemForm.MdiParent = (MainForm)Parent.Parent;
            editItemForm.FormClosing += AddEditItemForm_FormClosing;
            editItemForm.Show();
        }

        private void AddEditItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Видалити запис?", "Видалення", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Items.deleteId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                update();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePriceForm form = new ChangePriceForm();
            form.ShowDialog();
        }
    }
}
