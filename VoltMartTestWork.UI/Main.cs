using System.ComponentModel;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Core.Models;
using VoltMartTestWork.Data.Repositories;

namespace VoltMartTestWork.UI
{
    public partial class Main : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        List<Employee> Employees;
        public Main(IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository;

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
                        await _employeeRepository.AddEmployeeAsync(newEmployee);
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
                            await _employeeRepository.UpdateEmployeeAsync(updateEmployeeForm.SelectedEmployee);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем выделенную строку
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Получаем объект Employee, связанный с выделенной строкой
                    Employee employeeToDelete = (Employee)selectedRow.DataBoundItem;

                    if (employeeToDelete != null)
                    {
                        //Отображаем сообщение с подтверждением удаления
                        DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника '{employeeToDelete.Firstname} {employeeToDelete.Lastname}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Удаляем сотрудника из базы данных
                            await _employeeRepository.DeleteEmployeeAsync(employeeToDelete.Id);


                            //Обновляем DataGridView
                            await LoadData();

                            MessageBox.Show("Сотрудник успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async Task LoadData()
        {
            try
            {
                Employees = await _employeeRepository.GetEmployees();
                dataGridView1.DataSource = Employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
