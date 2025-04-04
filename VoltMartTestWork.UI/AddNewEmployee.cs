using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.UI
{
    public partial class AddNewEmployee : Form
    {
        public Employee NewEmployee { get; private set; }
        public AddNewEmployee()
        {
            InitializeComponent();
        }
        private void InitializePropertiess<T>()
        {
            Type type = typeof(T);
            List<PropertyInfo> properties = type.GetProperties().ToList();
            foreach (PropertyInfo property in properties)
            {
                Label label = new Label();
                label.Text = property.Name;
                label.Tag = property;
            } 
        }
        
    }
}
