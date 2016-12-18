using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT surname as 'Прізвище', Name as 'Імя', lastname as 'Побатькові', SUM([Кількість]) as 'Кількість', Sum([Сума]) as 'Сума' " +
                "FROM(SELECT surname, Name, lastname, Checks.id as 'checkid' " +
                "From Workers INNER JOIN Checks " +
                "ON Workers.id = casir " +
                "WHERE posada = 5) as a INNER JOIN " +
                "(SELECT[check], COUNT(name) as 'Кількість позицій', SUM(checkItems.count) as 'Кількість', SUM(price) as 'Сума' " +
                "FROM checkItems INNER JOIN Items " +
                "ON item = Items.id " +
                "GROUP BY[check]) as b " +
                "ON a.checkid =[check] " +
                "GROUP BY surname, Name, lastname", bd);
            dataAdapter1.Fill(dataSet);
            bd.Close();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT name, SUM(checkItems.count) as 'Кількість', SUM(price) as 'Сума' " +
                "FROM checkItems INNER JOIN Items " +
                "ON item = Items.id " +
                "GROUP BY name " +
                "ORDER BY name asc", bd);
            dataAdapter1.Fill(dataSet);
            bd.Close();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
