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

        public void openStartForm()
        {
            switch (user.access)
            {
                case 1:
                    DirectorStarterForm dform = new DirectorStarterForm();
                    dform.TopLevel = false;
                    dform.MdiParent = this;
                    dform.Show();
                    miContrDir.Visible = true;
                    break;
                case 2:
                    ManagerStarterForm mform = new ManagerStarterForm();
                    mform.TopLevel = false;
                    mform.MdiParent = this;
                    mform.Show();
                    miContrMan.Visible = true;
                    break;
                case 3:
                    CashierStarterForm cform = new CashierStarterForm();
                    cform.TopLevel = false;
                    cform.MdiParent = this;
                    cform.Show();
                    miContrCas.Visible = true;
                    break;
                default:
                    break;
            }
        }

        //Увійти
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm autorization = new AutorizationForm();
            autorization.TopLevel = false;
            autorization.MdiParent = this;
            autorization.Show();
        }
        public void logout()
        {
            miLogin.Visible = true;
            miSetting.DropDownItems[0].Visible = false;
            miSetting.DropDownItems[1].Visible = false;
            closeAllWondows();
            user = new User();
            miContrCas.Visible = false;
            miContrDir.Visible = false;
            miContrMan.Visible = false;
        }
        //Вийти
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout();
        }
        //Змінити користувача
        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout();

            AutorizationForm autorization = new AutorizationForm();
            autorization.TopLevel = false;
            autorization.MdiParent = this;
            autorization.Show();
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
            closeAllWondows();
        }
        public void closeAllWondows()
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
