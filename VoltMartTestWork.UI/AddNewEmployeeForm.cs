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
    public partial class AddNewEmployeeForm : Form
    {
        public Employee NewEmployee { get; private set; }
        public AddNewEmployeeForm()
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewEmployee = new Employee();
                NewEmployee.Firstname = textBoxFirstName.Text;
                NewEmployee.Lastname = textBoxLastName.Text;
                NewEmployee.Midlename = textBoxMidleName.Text;
                NewEmployee.Phone = textBoxPhone.Text;
                NewEmployee.Email = textBoxEmail.Text;
                NewEmployee.Birthday = DateOnly.FromDateTime(dateTimePickerBirthday.Value);
                NewEmployee.Isworking = checkBoxWork.Checked;
                NewEmployee.Ismarried = checkBoxMarried.Checked;
                NewEmployee.Nowplaceliving = textBoxPlaceLiving.Text;
                NewEmployee.Hiredate = DateOnly.FromDateTime(dateTimePickerHireDate.Value);
                //потверждаем
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
