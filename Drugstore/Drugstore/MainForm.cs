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
            Autorization autorization = new Autorization();
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
    }
}
