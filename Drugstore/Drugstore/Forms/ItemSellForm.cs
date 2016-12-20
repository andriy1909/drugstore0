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
    public partial class ItemSellForm : Form
    {
        public ItemSellForm()
        {
            InitializeComponent();
        }

        private void ItemSellForm_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.dataSetItems.Items);
            itemsBindingSource.Filter = "count>0";
            itemsBindingSource.Sort = "name DESC";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView2.Rows.Add();
            i = dataGridView2.RowCount - 1;
            dataGridView2.Rows[i].Cells[0].Value = dataGridView1.CurrentRow.Cells[0].Value;
            dataGridView2.Rows[i].Cells[1].Value = dataGridView1.CurrentRow.Cells[1].Value;
            dataGridView2.Rows[i].Cells[2].Value = numericUpDown1.Value;
            decimal sum = (int)(double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim()) * Convert.ToDouble(numericUpDown1.Value) * (1 - double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim()) / 100) * 100);
            dataGridView2.Rows[i].Cells[3].Value = (sum/100).ToString();

            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Items SET count=@valCount WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), connection);
                command.Parameters.AddWithValue("@valCount", int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim())- Convert.ToInt32(numericUpDown1.Value));

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            this.itemsTableAdapter.Fill(this.dataSetItems.Items);
            //itemsBindingSource.Filter = "count>0";
            itemsTableAdapter.SelectPl(dataSetItems.Items);
            itemsBindingSource.Sort = "name DESC";

            //dataGridView1.CurrentRow.Cells[4].Value = (int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim()) - Convert.ToInt32(numericUpDown1.Value)).ToString();

            tbTotal.Text = (double.Parse(tbTotal.Text) + double.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString().Trim())).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            int id = 0;
            if (textBox1.Text != "")
            {
                SqlConnection bd = new SqlConnection(connectString);
                bd.Open();
                SqlCommand command1 = new SqlCommand("select id id from Clients where card=" + textBox1.Text, bd);
                SqlDataReader dataReader1 = command1.ExecuteReader();
                while (dataReader1.Read())
                {
                    id = (int)dataReader1["id"];
                }
                bd.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string tm = "NULL";
                if (textBox1.Text != "")
                    tm = "@valueClient";
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Checks VALUES(@valueCasir, " + tm + ", @valueDate)", connection);
                command.Parameters.AddWithValue("@valueCasir", ((MainForm)(MdiParent)).user.id);
                if (textBox1.Text != "")
                    command.Parameters.AddWithValue("@valueClient", id);
                command.Parameters.AddWithValue("@valueDate", DateTime.Now.Date);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            

                int ch = getLastNum();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO checkItems VALUES(@valueCheck, @valueItem, @valueCount)", connection);
                    command.Parameters.AddWithValue("@valueCheck", ch);
                    command.Parameters.AddWithValue("@valueItem", int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString().Trim()));
                    command.Parameters.AddWithValue("@valueCount", int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString().Trim()));
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        

        dataGridView2.Rows.Clear();
            MessageBox.Show("До сплати: " + tbTotal.Text);
            tbTotal.Text = "0";
            textBox1.Clear();
        }

        public int getLastNum()
        {
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            int id = 0;
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("select top(1) id from [dbo].[Checks] ORDER BY id DESC", bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                id= (int)dataReader1["id"];
            }
            bd.Close();
            return id;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {            
            if (textBox2.Text.Length != 0)
            {
                itemsBindingSource.Filter = "count>0 and name like '%" + textBox2.Text.Trim() + "%' ";
            }
            else
                itemsBindingSource.Filter = "count>0";
        }

        public string getNameField(string value)
        {
            switch (value)
            {
                case "Назва":
                    return "name";
                case "Категорія":
                    return "category";
                case "Кількість":
                    return "count";
                case "Ціна":
                    return "price";
                default:
                    return "name";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort;
            if (comboBox1.Text == "▼")
                sort = "DESC";
            else
                sort = "ASC";
            itemsBindingSource.Sort = getNameField(comboBox3.Text) + " " + sort;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numericUpDown1.Maximum = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim());
            }
            catch (Exception)
            {
            }
            
        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void selectPlToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.SelectPl(this.dataSetItems.Items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.Rows[0].Selected = true;
                int i = itemsBindingSource.Find("id", textBox3.Text);
                if (i >= 0)
                    dataGridView1.Rows[i].Selected = true;
                else
                    MessageBox.Show("Не знайдено");
            }
        }
    }
}
