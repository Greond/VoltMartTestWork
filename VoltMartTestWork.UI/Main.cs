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
                    // ��������� ������ ����������
                    try
                    {
                        await _employeeService.CreateEmployee(newEmployee);
                        //��������� DataGridView
                        await LoadData();

                        MessageBox.Show("��������� ������� ��������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������ ��� ���������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // �������� ���������� ������
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // �������� ������ Employee, ��������� � ���������� �������
                    Employee employeeToUpdate = (Employee)selectedRow.DataBoundItem;

                    if (employeeToUpdate != null)
                    {
                        EmployeeForm updateEmployeeForm = new EmployeeForm(employeeToUpdate);
                        if (updateEmployeeForm.ShowDialog() == DialogResult.OK)
                        {
                            // ����������
                            await _employeeService.UpdateEmployee(updateEmployeeForm.SelectedEmployee);
                            await LoadData();
                            MessageBox.Show("��������� ������� �������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("����������, �������� ������ ��� ���������.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            // ���������, ������� �� ���� �� ���� ������
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("����������, �������� ������ ��� ��������.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ������� �� ������, ���� ������ �� �������
            }
            try
            {
                bool multipleRowsSelected = dataGridView1.SelectedRows.Count > 1;

                string confirmationMessage = multipleRowsSelected
                ? "�� �������, ��� ������ ������� ���������� �����������?"
                : $"�� �������, ��� ������ ������� ���������� '{GetEmployeeFromSelectedRow()?.Firstname} {GetEmployeeFromSelectedRow()?.Lastname}'?";

                // ����������� ������������� � ������������
                DialogResult result = MessageBox.Show(confirmationMessage, "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // ������� �����������
                    if (multipleRowsSelected)
                    {
                        await DeleteMultipleEmployeesAsync();
                    }
                    else
                    {
                        await DeleteSingleEmployeeAsync();
                    }

                    // ��������� ������ � DataGridView
                    await LoadData();

                    // ���������� ��������� �� �������� ��������
                    MessageBox.Show("���������� ������� �������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // ������������ ������
                MessageBox.Show($"������ ��� �������� �����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                await _employeeService.DeleteEmployee(employeeToDelete); // ���������� Id ��� ��������
            }
        }
        private async Task DeleteMultipleEmployeesAsync()
        {
            // �������� ���������� ������
            IEnumerable<DataGridViewRow> selectedRows = dataGridView1.SelectedRows.Cast<DataGridViewRow>();

            // ������� �����������
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
                MessageBox.Show($"������ ��� ��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
