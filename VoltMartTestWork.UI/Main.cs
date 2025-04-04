using System.ComponentModel;
using VoltMartTestWork.Core.Interfaces;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.UI
{
    public partial class Main : Form
    {
        private readonly IEmployeeRepository _mainRepository;
        List<Employee> MainData;
        private List<Employee> _addedEmployees = new List<Employee>();
        private List<Employee> _modifiedEmployees = new List<Employee>();
        private List<Employee> _deletedEmployees = new List<Employee>();
        public Main(IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _mainRepository = employeeRepository;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadData();
            dataGridView1.DataSource = MainData;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. ���������� ����� �����������
                foreach (var employee in _addedEmployees)
                {
                    await _mainRepository.AddEmployeeAsync(employee);
                }

                // 2. ���������� ���������� �����������
                foreach (var employee in _modifiedEmployees)
                {
                    await _mainRepository.UpdateEmployeeAsync(employee);
                }

                // 3. �������� ��������� �����������
                foreach (var employee in _deletedEmployees)
                {
                    await _mainRepository.DeleteEmployeeAsync(employee.Id);
                }

                // ������� ������� ����� ��������� ����������
                _addedEmployees.Clear();
                _modifiedEmployees.Clear();
                _deletedEmployees.Clear();

                // ���������� DataGridView (������������ ������ �� ��)
                await LoadData();

                MessageBox.Show("��������� ���������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������� ���������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ���������� ��� ����� �����
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Employee newEmployee = (Employee)e.Row.DataBoundItem;
            if (newEmployee != null)
            {
                _addedEmployees.Add(newEmployee);
            }
        }

        // ���������� ��� ��������� �����
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Employee changedEmployee = (Employee)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (changedEmployee != null && !_addedEmployees.Contains(changedEmployee)) // ���������, �� �������� �� ������ �����
                {
                    if (!_modifiedEmployees.Contains(changedEmployee))
                    {
                        _modifiedEmployees.Add(changedEmployee);
                    }
                }
            }
        }

        // ���������� ��� �������� �����
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Employee deletedEmployee = (Employee)e.Row.DataBoundItem;
            if (deletedEmployee != null)
            {
                _deletedEmployees.Add(deletedEmployee);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadData()
        {
            try
            {
                MainData = await _mainRepository.GetEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
