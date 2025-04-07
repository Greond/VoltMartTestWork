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
    public partial class EmployeeForm : Form
    {
        public Employee SelectedEmployee { get; private set; }

        public EmployeeForm() // при добавлении нового
        {
            InitializeComponent();

            SelectedEmployee = new Employee();

            SaveButton.BackColor = Color.FromArgb(128, 255, 128);
        }
        public EmployeeForm(Employee employee) // при изменение уже существующего
        {
            InitializeComponent();

            SelectedEmployee = employee;

            SaveButton.BackColor = Color.FromArgb(255, 255, 128);

            SetEmployeeToForm(employee);
        }
        private void SaveButton_Click(object sender, EventArgs e) 
        {
            try
            {
                //валидацию монжо перенести в Service при необходимости
                //устанавливаем свойства в обьект
                SetEmployee();
                // валидируем обьект перед его сохранением
                if (!ValidateEmployee(SelectedEmployee))
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
        private void SetEmployeeToForm(Employee employee)
        {
            textBoxFirstName.Text = employee.Firstname;
            textBoxLastName.Text = employee.Lastname;
            textBoxMidleName.Text = employee.Midlename ?? string.Empty; // Обработка null для Midlename
            textBoxPhone.Text = employee.Phone ?? string.Empty;          // Обработка null для Phone
            textBoxEmail.Text = employee.Email ?? string.Empty; //null для Email

            if (employee.Birthday.HasValue)
            {
                dateTimePickerBirthday.Checked = true;
                dateTimePickerBirthday.Value = employee.Birthday.Value.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dateTimePickerBirthday.Checked = false;
            }
            checkBoxWork.Checked = employee.Isworking ?? false;
            checkBoxMarried.Checked = employee.Ismarried ?? false;
            textBoxPlaceLiving.Text = employee.Nowplaceliving ?? string.Empty;
            if (employee.Hiredate.HasValue)
            {
                dateTimePickerHireDate.Checked = true;
                dateTimePickerHireDate.Value = employee.Hiredate.Value.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dateTimePickerHireDate.Checked = false;
            }

        }
        private void SetEmployee()
        {
            SelectedEmployee.Firstname = string.IsNullOrEmpty(textBoxFirstName.Text) ? null : textBoxFirstName.Text;
            SelectedEmployee.Lastname = string.IsNullOrEmpty(textBoxLastName.Text) ? null : textBoxLastName.Text;
            SelectedEmployee.Midlename = string.IsNullOrEmpty(textBoxMidleName.Text) ? null : textBoxMidleName.Text;
            SelectedEmployee.Phone = string.IsNullOrEmpty(textBoxPhone.Text) ? null : textBoxPhone.Text;
            SelectedEmployee.Email = string.IsNullOrEmpty(textBoxEmail.Text) ? null : textBoxEmail.Text;
            SelectedEmployee.Birthday = dateTimePickerBirthday.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerBirthday.Value);
            SelectedEmployee.Isworking = checkBoxWork.Checked;
            SelectedEmployee.Ismarried = checkBoxMarried.Checked;
            SelectedEmployee.Nowplaceliving = string.IsNullOrEmpty(textBoxPlaceLiving.Text) ? null : textBoxPlaceLiving.Text;
            SelectedEmployee.Hiredate = dateTimePickerHireDate.Checked != true ? null : DateOnly.FromDateTime(dateTimePickerHireDate.Value);
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
