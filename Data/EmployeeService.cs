namespace BlazorDataFormCRUD.Data
{
    public class EmployeeCrud
    {
        private List<EmployeeDetails> _employees = new List<EmployeeDetails>
    {
        new EmployeeDetails { Id = 1, Name = "John Doe", DateOfBirth=new DateOnly(1990,01,19), Designation = "Software Engineer", Salary = 50000 },
        new EmployeeDetails { Id = 2, Name = "Jane Doe", DateOfBirth=new DateOnly(1987,11,25), Designation = "Senior Software Engineer", Salary = 60000 }
    };

        public IEnumerable<EmployeeDetails> GetAllEmployees()
        {
            return _employees;
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(EmployeeDetails employee)
        {
            employee.Id = _employees.Count + 1;
            _employees.Add(employee);
        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            var existingEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                employee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Designation = employee.Designation;
                existingEmployee.Salary = employee.Salary;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
