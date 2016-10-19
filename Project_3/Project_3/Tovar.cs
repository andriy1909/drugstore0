using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Tovar : UserControl
    {
        public Tovar()
        {
            InitializeComponent();
        }

        public Tovar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
