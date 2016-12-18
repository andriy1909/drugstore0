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
            string sort, sortField, findField, findValue;
            if (comboBox1.Text == "▼")
                sort = "DESC";
            else
                sort = "ASC";
            sortField = getNameField(comboBox3.Text);
            findField = getNameField(comboBox2.Text);
            findValue = textBox1.Text;

            if (findValue == "")
                dataGridView1.DataSource = Clients.getAllClients(sortField, sort).Tables[0];
            else
                dataGridView1.DataSource = Clients.getClientsByFilter(findField,findValue, sortField, sort).Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientEditForm addClientForm = new ClientEditForm();
            addClientForm.TopLevel = false;
            addClientForm.MdiParent = (MainForm)Parent.Parent;
            addClientForm.FormClosing += AddEditClientForm_FormClosing;
            addClientForm.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ClientEditForm editClientForm = new ClientEditForm(index);
            editClientForm.TopLevel = false;
            editClientForm.MdiParent = (MainForm)Parent.Parent;
            editClientForm.FormClosing += AddEditClientForm_FormClosing;
            editClientForm.Show();
        }

        private void AddEditClientForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.printWord();
            MessageBox.Show("Збережено");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.printExcel();
            MessageBox.Show("Збережено");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string getNameField(string value)
        {
            switch (value)
            {
                case "Номер картки":
                    return "card";
                case "Прізвище":
                    return "surname";
                case "Ім'я":
                    return "name";
                case "По батькові":
                    return "lastname";
                case "Дата народження":
                    return "dateBirth";
                case "Дата реєстрації":
                    return "dateRegistr";
                case "Стать":
                    return "gender";
                default:
                    return "";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
