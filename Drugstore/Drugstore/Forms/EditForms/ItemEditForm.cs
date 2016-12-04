using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ItemEditForm : Form
    {
        private string action;
        private int id = 0;

        public ItemEditForm()
        {
            InitializeComponent();
            action = "add";
            Text = "Додавання нового товара";
            btnAddEdit.Text = "Додати";
        }
        
        public ItemEditForm(int id)
        {
            InitializeComponent();
            this.id = id;
            action = "edit";
            Text = "Редагування";
            btnAddEdit.Text = "Редагувати";
            getItemData(id);
        }
        private void add()
        {
            Items item = new Items();
            item.setItem(tbName.Text, tbCategory.Text, tbText.Text, (int)numCount.Value, double.Parse(tbPrice.Text),
                double.Parse(tbDiscont.Text), pictureBox1.Image, tbPosition.Text);
            item.insertItem();
            MessageBox.Show("Додано!", "", MessageBoxButtons.OK);
            Close();
        }
        private void edit()
        {
            Items item = new Items();
            item.setItem(tbName.Text, tbCategory.Text, tbText.Text, (int)numCount.Value, double.Parse(tbPrice.Text),
                double.Parse(tbDiscont.Text), pictureBox1.Image, tbPosition.Text);
            item.updateItem(id);
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

        private void getItemData(int id)
        {
            Items item = new Items();
            item.getDataItem(id);
            tbName.Text = item.getName();
            tbCategory.Text = item.getCategory();
            tbText.Text = item.getText();
            numCount.Value = item.getCount();
            tbPrice.Text = item.getPrice().ToString();
            tbDiscont.Text = item.getDiscont().ToString();
            tbPosition.Text = item.getPosition();
            pictureBox1.Image = item.getImage2();
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
