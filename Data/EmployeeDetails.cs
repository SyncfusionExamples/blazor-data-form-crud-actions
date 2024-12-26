using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorDataFormCRUD.Data
{
    public class EmployeeDetails
    {
        [Display(Name = "Employee ID")]
        [Editable(false)]
        [Required(ErrorMessage = "Please enter employee ID")]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Please enter employee name.")]
        public string Name { get; set; }
        [Display(Name="Employee Data Of Birth")]
        [Required(ErrorMessage = "Please enter employee date of birth.")]
        public DateOnly? DateOfBirth { get; set; }

        [Display (Name = "Employee Designation")]
        [Required(ErrorMessage = "Please enter employee designation.")]
        public string Designation { get; set; }
        [Display(Name = "Employee Salary")]
        [Required(ErrorMessage = "Please enter employee salary.")]
        public decimal Salary { get; set; }
    }
}
