using System.ComponentModel;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Core.Interfaces.IServices;
using VoltMartTestWork.Core.Models;
using System.Linq;
using VoltMartTestWork.Data.Repositories;

namespace VoltMartTestWork.UI
{
    public partial class Main : Form
    {
        private readonly IEmployeeService _employeeService;
        IEnumerable<Employee> Employees;
        public Main(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadData();
        }


        private async void AddButton_Click(object sender, EventArgs e)
        {
            EmployeeForm addNewEmployeeForm = new EmployeeForm();
            if (addNewEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                Employee? newEmployee = addNewEmployeeForm.SelectedEmployee;

                if (newEmployee != null)
                {
                    // Добавляем нового сотрудника
                    try
                    {
                        await _employeeService.CreateEmployee(newEmployee);
                        //Обновляем DataGridView
                        await LoadData();

                        MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void ChangeButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем выделенную строку
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Получаем объект Employee, связанный с выделенной строкой
                    Employee employeeToUpdate = (Employee)selectedRow.DataBoundItem;

                    if (employeeToUpdate != null)
                    {
                        EmployeeForm updateEmployeeForm = new EmployeeForm(employeeToUpdate);
                        if (updateEmployeeForm.ShowDialog() == DialogResult.OK)
                        {
                            // обновление
                            await _employeeService.UpdateEmployee(updateEmployeeForm.SelectedEmployee);
                            await LoadData();
                            MessageBox.Show("Сотрудник успешно обновлён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновление сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для изменения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли хотя бы одна строка
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Выходим из метода, если ничего не выбрано
            }
            try
            {
                bool multipleRowsSelected = dataGridView1.SelectedRows.Count > 1;

                string confirmationMessage = multipleRowsSelected
                ? "Вы уверены, что хотите удалить выделенных сотрудников?"
                : $"Вы уверены, что хотите удалить сотрудника '{GetEmployeeFromSelectedRow()?.Firstname} {GetEmployeeFromSelectedRow()?.Lastname}'?";

                // Запрашиваем подтверждение у пользователя
                DialogResult result = MessageBox.Show(confirmationMessage, "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаляем сотрудников
                    if (multipleRowsSelected)
                    {
                        await DeleteMultipleEmployeesAsync();
                    }
                    else
                    {
                        await DeleteSingleEmployeeAsync();
                    }

                    // Обновляем данные в DataGridView
                    await LoadData();

                    // Отображаем сообщение об успешном удалении
                    MessageBox.Show("Сотрудники успешно удалены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем ошибки
                MessageBox.Show($"Ошибка при удалении сотрудников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Employee GetEmployeeFromSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                return selectedRow.DataBoundItem as Employee;
            }
            return null;
        }
        private async Task DeleteSingleEmployeeAsync()
        {
            Employee employeeToDelete = GetEmployeeFromSelectedRow();
            if (employeeToDelete != null)
            {
                await _employeeService.DeleteEmployee(employeeToDelete); // Используем Id для удаления
            }
        }
        private async Task DeleteMultipleEmployeesAsync()
        {
            // получаем выделенные строки
            IEnumerable<DataGridViewRow> selectedRows = dataGridView1.SelectedRows.Cast<DataGridViewRow>();

            // удаляем сотрудников
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                Employee employee = selectedRow.DataBoundItem as Employee;
                if (employee != null)
                {
                    await _employeeService.DeleteEmployee(employee);
                }
            }

        }
        private async Task LoadData()
        {
            try
            {
                Employees = await _employeeService.GetEmployees();
                dataGridView1.DataSource = Employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
