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
    public partial class TovarLow : UserControl
    {
        public TovarLow()
        {
            InitializeComponent();
        }

        public TovarLow(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
