using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public Item(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
