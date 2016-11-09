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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
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
                                
                                    user= new User(int.Parse(dataReader1["id"].ToString()),
                                    dataReader1["name"].ToString().Trim(),
                                    dataReader1["surname"].ToString().Trim(),
                                    dataReader1["lastname"].ToString().Trim(),
                                    dataReader1["posada"].ToString().Trim());
                                ((MainForm)MdiParent).user = user;
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
                    MessageBox.Show("Ласкаво просимо, "+user.getUserName()+"!", "Здійснено вхід", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch (Exception)
            {
                lbErrors.Visible = true;
                lbErrors.ForeColor = Color.Red;
                lbErrors.Text ="Помилка з'єднання з базою даних";
            }
        }
    }
}
