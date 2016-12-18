using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            lbErrors.ForeColor = Color.Black;
            lbErrors.Text = "З'єднання з базою данних...";
            lbErrors.Visible = true;
            bool check1 = true;
            try
            {
                SqlConnection bd = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;");
                bd.Open();
                string sql = "SELECT Workers.id, Workers.name, [surname], [lastname], [login], [password], Posada.name as 'posada' " +
                            "FROM Workers INNER JOIN Posada " +
                            "ON Workers.posada = Posada.id";
                SqlCommand command1 = new SqlCommand(sql, bd);
                SqlDataReader dataReader1 = command1.ExecuteReader();

                User user = new User();
                while (dataReader1.Read())
                {
                    if (dataReader1["login"].ToString().Trim() == tbLogin.Text.Trim())
                        if (dataReader1["password"].ToString().Trim() == tbPassword.Text.Trim())
                            if (dataReader1["posada"].ToString().Trim() == "Директор" ||
                                dataReader1["posada"].ToString().Trim() == "Менеджер" ||
                                dataReader1["posada"].ToString().Trim() == "Аптекар")
                            {
                                check1 = false;
                                lbErrors.Visible = false;

                                user = new User(int.Parse(dataReader1["id"].ToString()),
                                    dataReader1["surname"].ToString().Trim(),
                                    dataReader1["name"].ToString().Trim(),
                                    dataReader1["lastname"].ToString().Trim(),
                                    dataReader1["posada"].ToString().Trim());
                                mainForm.user = user;
                                break;
                            }
                }
                bd.Close();
                if (check1)
                {
                    lbErrors.Visible = true;
                    lbErrors.ForeColor = Color.Red;
                    lbErrors.Text = "Введеий невірний логін або пароль";
                }
                else
                {
                    Hide();
                    MessageBox.Show("Ласкаво просимо, " + user.getUserName() + "!", "Здійснено вхід", MessageBoxButtons.OK);
                    mainForm.openStartForm();
                    mainForm.miLogin.Visible = false;
                    mainForm.miSetting.DropDownItems[0].Visible = true;
                    mainForm.miSetting.DropDownItems[1].Visible = true;
                    Close();
                }
            }
            catch (Exception)
            {
                lbErrors.Visible = true;
                lbErrors.ForeColor = Color.Red;
                lbErrors.Text = "Помилка з'єднання з базою даних";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCheck.PerformClick();
        }
    }
}
