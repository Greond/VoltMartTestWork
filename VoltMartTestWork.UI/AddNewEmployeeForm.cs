using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            dateTimePickerHireDate.ShowCheckBox = true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //устанавливаем свойства в обьект
                SetNewEmployee();
                // валидируем обьект перед его сохранением
                if (!ValidateEmployee(NewEmployee))
                {
                    // если валидация не пролшла успешно возвращаемся
                    return;
                }
                else
                {
                    //потверждаем
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetNewEmployee()
        {
            NewEmployee = new Employee();
            NewEmployee.Firstname = string.IsNullOrEmpty(textBoxFirstName.Text) ? null : textBoxFirstName.Text;
            NewEmployee.Lastname = string.IsNullOrEmpty(textBoxLastName.Text) ? null : textBoxLastName.Text;
            NewEmployee.Midlename = string.IsNullOrEmpty(textBoxMidleName.Text) ? null : textBoxMidleName.Text;
            NewEmployee.Phone = string.IsNullOrEmpty(textBoxPhone.Text) ? null : textBoxPhone.Text;
            NewEmployee.Email = string.IsNullOrEmpty(textBoxEmail.Text) ? null : textBoxEmail.Text;
            NewEmployee.Birthday = dateTimePickerBirthday.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerBirthday.Value);
            NewEmployee.Isworking = checkBoxWork.Checked;
            NewEmployee.Ismarried = checkBoxMarried.Checked;
            NewEmployee.Nowplaceliving = string.IsNullOrEmpty(textBoxPlaceLiving.Text) ? null : textBoxPlaceLiving.Text;
            NewEmployee.Hiredate = dateTimePickerHireDate.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerHireDate.Value);
        }
        private bool ValidateEmployee(Employee employee)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(employee);
            bool isValid = Validator.TryValidateObject(employee, context, results, true);
            if (!isValid)
            {
                // Отображаем ошибки валидации
                string errorMessage = string.Join(Environment.NewLine, results.Select(v => v.ErrorMessage));
                MessageBox.Show($"Ошибка валидации: {errorMessage}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
