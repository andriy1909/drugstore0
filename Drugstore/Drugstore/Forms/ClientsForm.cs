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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            dataGridView1.DataSource = Clients.getAllClients().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientEditForm addClientForm = new ClientEditForm();
            addClientForm.TopLevel = false;
            addClientForm.MdiParent = (MainForm)Parent.Parent;
            addClientForm.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ClientEditForm addClientForm = new ClientEditForm(index);
            addClientForm.TopLevel = false;
            addClientForm.MdiParent = (MainForm)Parent.Parent;
            addClientForm.Show();

            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Видалити запис?", "Видалення", MessageBoxButtons.YesNo);
            if(DialogResult==DialogResult.Yes) 
                Clients.deleteId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            update();
        }
    }
}
