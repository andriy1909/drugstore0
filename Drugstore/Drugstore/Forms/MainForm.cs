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
    public partial class MainForm : Form
    {
        public User user;

        public MainForm()
        {
            InitializeComponent();
            user = new User();
        }

        //Увійти
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm autorization = new AutorizationForm();
            autorization.TopLevel = false;
            autorization.MdiParent = this;
            autorization.Show();
        }
        //Вийти
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Змінити користувача
        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Вихід з програми
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Вікна каскадом
        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        //Вікна горизонтально
        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        //Вікна вертикально
        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        //Закрити вікно
        private void закритиВікноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                ActiveMdiChild.Close();
        }
        //Закрити всі вікна
        private void закритиВсіВікнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm c = new ClientsForm();
            c.TopLevel = false;
            c.MdiParent = this;
            c.Show();
        }

        private void менеджерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerStarterForm form = new ManagerStarterForm();
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void аптекарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierStarterForm form = new CashierStarterForm();
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void директорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorStarterForm form = new DirectorStarterForm();
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }
    }
}
