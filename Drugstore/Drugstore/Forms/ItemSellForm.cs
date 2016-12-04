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
    public partial class ItemSellForm : Form
    {
        public ItemSellForm()
        {
            InitializeComponent();
        }

        private void ItemSellForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Items.getAllItems().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView2.Rows.Add();
            i = dataGridView2.RowCount - 1;
            dataGridView2.Rows[i].Cells[0].Value = dataGridView1.CurrentRow.Cells[1].Value;
            dataGridView2.Rows[i].Cells[1].Value = numericUpDown1.Value;
            dataGridView2.Rows[i].Cells[2].Value = (double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim()) * Convert.ToDouble(numericUpDown1.Value)).ToString();
            dataGridView1.CurrentRow.Cells[4].Value = (int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim()) - Convert.ToInt32(numericUpDown1.Value)).ToString();
            tbTotal.Text = (double.Parse(tbTotal.Text)+ double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString().Trim())).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            MessageBox.Show("До сплати: " + tbTotal.Text);
            tbTotal.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
