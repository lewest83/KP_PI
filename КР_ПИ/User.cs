using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_ПИ
{
    public enum Role { HR, Manager, Accountant, Employee }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; 
        public Role Role { get; set; }
        public int? EmployeeId { get; set; } = null;
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; } = new();
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Employee> Employees { get; set; } = new();
    }

    public enum LeaveStatus { Pending, Approved, Rejected }

    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = "";
        public LeaveStatus Status { get; set; } = LeaveStatus.Pending;
    }
    public class SalaryRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime Month { get; set; }
        public decimal Gross { get; set; }
        public decimal Deductions { get; set; }
    }
}
