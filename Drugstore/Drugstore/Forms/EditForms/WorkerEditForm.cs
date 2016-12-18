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
            dateBirth.MaxDate = DateTime.Now;
            datePriyom.MaxDate = DateTime.Now;
            setCbPosad();
        }
        public WorkerEditForm(int id)
        {
            InitializeComponent();
            this.id = id;
            action = "edit";
            Text = "Редагування";
            getWorkerData(id);
            btnAddEdit.Text = "Редагувати";
            dateBirth.MaxDate = DateTime.Now;
            datePriyom.MaxDate = DateTime.Now;
            setCbPosad();
        }

        public void setCbPosad()
        {
            List<string> pos = Workers.getAllPosada();
            foreach (string item in pos)
            {
                cbPosada.Items.Add(item);
            }
        }

        private void add()
        {
            Workers worker = new Workers();
            worker.setWorker(tbPasport.Text, tbSurname.Text, tbName.Text, tbLastname.Text, 
                maskedPhobeToPhone(tbPhone.Text), tbEmail.Text, worker.getPosadaId(cbPosada.Text), 
                dateBirth.Value, int.Parse(tbStaj.Text), datePriyom.Value, radioButtonMan.Checked, tbLogin.Text, tbPassword.Text);
            worker.insertWorker();
            MessageBox.Show("Додано!", "", MessageBoxButtons.OK);
            Close();
        }
        private void edit()
        {
            Workers worker = new Workers();
            worker.setWorker(tbPasport.Text, tbSurname.Text, tbName.Text, tbLastname.Text,
                maskedPhobeToPhone(tbPhone.Text), tbEmail.Text, worker.getPosadaId(cbPosada.Text),
                dateBirth.Value, int.Parse(tbStaj.Text), datePriyom.Value, radioButtonMan.Checked, tbLogin.Text, tbPassword.Text);
            worker.updateWorker(id);
            MessageBox.Show("Змінено!", "", MessageBoxButtons.OK);
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

        private void getWorkerData(int id)
        {
            Workers worker = new Workers();
            worker.getDataWorker(id);
            tbPasport.Text = worker.getPasport();
            tbSurname.Text = worker.getSurname();
            tbName.Text = worker.getName();
            tbLastname.Text = worker.getLastname();
            tbPhone.Text = worker.getPhone();
            tbEmail.Text = worker.getEmail();
            cbPosada.Text = worker.getNamePosada();
            dateBirth.Value = worker.getDateBirth();
            tbStaj.Text = worker.getStage().ToString();
            datePriyom.Value = worker.getDatePriyom();
            if (worker.getGender())
                radioButtonMan.Checked = true;
            else
                radioButtonWoman.Checked = true;
            tbLogin.Text = worker.getLogin();
            tbPassword.Text = worker.getPassword();
        }
    }
}
