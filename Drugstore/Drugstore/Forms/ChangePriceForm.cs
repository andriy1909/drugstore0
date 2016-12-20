using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ChangePriceForm : Form
    {
        public ChangePriceForm()
        {
            InitializeComponent();
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet3.AuditPrice". При необходимости она может быть перемещена или удалена.
            this.auditPriceTableAdapter.Fill(this.drugstoreDataSet3.AuditPrice);
        }
    }
}
