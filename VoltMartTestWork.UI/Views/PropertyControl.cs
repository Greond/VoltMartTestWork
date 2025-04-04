using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoltMartTestWork.UI.Views
{
    public partial class PropertyControl : UserControl
    {
        public string LabelText { get; set; }
        public string TextBoxText { get; set; }
        public PropertyControl(string labelText)
        {
            InitializeComponent();

            LabelText = labelText;
            label1.DataContext = labelText;
            textbox1.DataContext = labelText;
        }
    }
}
