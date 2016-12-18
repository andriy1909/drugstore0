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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        public void update()
        {
            dataGridView1.DataSource = Workers.getAllWorkers().Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WorkerEditForm addForm = new WorkerEditForm();
            addForm.TopLevel = false;
            addForm.MdiParent = (MainForm)Parent.Parent;
            addForm.FormClosing += AddEditForm_FormClosing; ;
            addForm.Show();
        }

        private void AddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Видалити запис?", "Видалення", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Workers.deleteId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                update();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            WorkerEditForm editWorkerForm = new WorkerEditForm(index);
            editWorkerForm.TopLevel = false;
            editWorkerForm.MdiParent = (MainForm)Parent.Parent;
            editWorkerForm.FormClosing += AddEditForm_FormClosing;
            editWorkerForm.Show();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            InfoForm infoForm = new InfoForm();
            infoForm.TopLevel = false;
            infoForm.MdiParent = (MainForm)Parent.Parent;
            infoForm.Show();
        }
    }
}
