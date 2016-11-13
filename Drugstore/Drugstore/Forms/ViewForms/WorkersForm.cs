﻿using System;
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
            dataGridView1.DataSource = Clients.getAllClients().Tables[0];
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
                Clients.deleteId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                update();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            WorkerEditForm editClientForm = new WorkerEditForm(index);
            editClientForm.TopLevel = false;
            editClientForm.MdiParent = (MainForm)Parent.Parent;
            editClientForm.FormClosing += AddEditForm_FormClosing;
            editClientForm.Show();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
