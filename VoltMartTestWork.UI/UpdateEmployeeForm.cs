using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.UI
{
    public partial class UpdateEmployeeForm : Form
    {
        public Employee UpdatedEmployee;
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //устанавливаем свойства в обьект
                SetNewEmployee();
                // валидируем обьект перед его сохранением
                if (!ValidateEmployee(UpdatedEmployee))
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
            UpdatedEmployee = new Employee();
            UpdatedEmployee.Firstname = string.IsNullOrEmpty(textBoxFirstName.Text) ? null : textBoxFirstName.Text;
            UpdatedEmployee.Lastname = string.IsNullOrEmpty(textBoxLastName.Text) ? null : textBoxLastName.Text;
            UpdatedEmployee.Midlename = string.IsNullOrEmpty(textBoxMidleName.Text) ? null : textBoxMidleName.Text;
            UpdatedEmployee.Phone = string.IsNullOrEmpty(textBoxPhone.Text) ? null : textBoxPhone.Text;
            UpdatedEmployee.Email = string.IsNullOrEmpty(textBoxEmail.Text) ? null : textBoxEmail.Text;
            UpdatedEmployee.Birthday = dateTimePickerBirthday.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerBirthday.Value);
            UpdatedEmployee.Isworking = checkBoxWork.Checked;
            UpdatedEmployee.Ismarried = checkBoxMarried.Checked;
            UpdatedEmployee.Nowplaceliving = string.IsNullOrEmpty(textBoxPlaceLiving.Text) ? null : textBoxPlaceLiving.Text;
            UpdatedEmployee.Hiredate = dateTimePickerHireDate.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerHireDate.Value);
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
