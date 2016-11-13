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
            getClientData(id);  
        }
        private void add()
        {
            Clients clients = new Clients();
            clients.setClient(tbCard.Text, tbSurname.Text, tbName.Text, tbLastname.Text, maskedPhobeToPhone(tbPhone.Text), tbEmail.Text, checkBoxEmail.Checked, dateBirth.Value, dateRegistr.Value, radioButtonMan.Checked);
            clients.insertClient();
            MessageBox.Show("Додано клієнта!", "", MessageBoxButtons.OK);
            Close();
        }
        private void edit()
        {
            Clients clients = new Clients();
            clients.setClient(tbCard.Text, tbSurname.Text, tbName.Text, tbLastname.Text, maskedPhobeToPhone(tbPhone.Text), tbEmail.Text, checkBoxEmail.Checked, dateBirth.Value, dateRegistr.Value, radioButtonMan.Checked);
            clients.updateClient(id);
            MessageBox.Show("Клієнта змінено!", "", MessageBoxButtons.OK);
            Close();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (action == "edit")
                edit();
            else
                add();
        }
        
        public string maskedPhobeToPhone(string maskedPhone)
        {
            maskedPhone = tbPhone.Text.Remove(0, 4);
            maskedPhone = maskedPhone.Remove(5, 1);
            maskedPhone = maskedPhone.Remove(8, 1);
            maskedPhone = maskedPhone.Remove(4, 1);
            maskedPhone = maskedPhone.Remove(0, 1);
            return maskedPhone;
        }

        private void getClientData(int id)
        {
            Clients client = new Clients();
            client.getDataClient(id);
            tbCard.Text = client.getCard();
            tbSurname.Text = client.getSurname();
            tbName.Text = client.getName();
            tbLastname.Text = client.getLastname();
            tbPhone.Text = client.getPhone();
            tbEmail.Text = client.getEmail();
            checkBoxEmail.Checked = client.getCheckEmail();
            dateBirth.Value = client.getDateBirth();
            dateRegistr.Value = client.getDateRegistr();
            if (client.getGender())
                radioButtonMan.Checked = true;
            else
                radioButtonWoman.Checked = true;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.TextLength > 0)
                checkBoxEmail.Enabled = true;
            else
                checkBoxEmail.Enabled = false;
        }
    }
}
