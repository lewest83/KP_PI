using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace КР_ПИ
{
    public static class DataStore
    {
        //путь к папке "data" в директории приложения
        public static string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

        //настройки сериализатора JSON
        static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        //пути к файлам
        public static string UsersFile => Path.Combine(DataFolder, "users.json");
        public static string EmployeesFile => Path.Combine(DataFolder, "employees.json");
        public static string DepartmentsFile => Path.Combine(DataFolder, "departments.json");
        public static string LeaveRequestsFile => Path.Combine(DataFolder, "leaverequests.json");
        public static string SalaryRecordsFile => Path.Combine(DataFolder, "salaryrecords.json");

        //Инициализация хранилища
        public static void EnsureInitialized()
        {
            //существование папки данных и создаёт если нет
            // каждого файла: если не существует, создаёт с пустым списком
            if (!Directory.Exists(DataFolder)) Directory.CreateDirectory(DataFolder);
            if (!File.Exists(DepartmentsFile)) File.WriteAllText(DepartmentsFile, JsonSerializer.Serialize(new List<Department>(), options));
            if (!File.Exists(EmployeesFile)) File.WriteAllText(EmployeesFile, JsonSerializer.Serialize(new List<Employee>(), options));
            if (!File.Exists(UsersFile)) File.WriteAllText(UsersFile, JsonSerializer.Serialize(new List<User>(), options));
            if (!File.Exists(LeaveRequestsFile)) File.WriteAllText(LeaveRequestsFile, JsonSerializer.Serialize(new List<LeaveRequest>(), options));
            if (!File.Exists(SalaryRecordsFile)) File.WriteAllText(SalaryRecordsFile, JsonSerializer.Serialize(new List<SalaryRecord>(), options));

            //Начальные данные
            var deps = ReadDepartments();
            if (deps.Count == 0)
            {
                deps.Add(new Department { Id = 1, Name = "Отдел продаж" });
                deps.Add(new Department { Id = 2, Name = "ИТ" });
                WriteDepartments(deps);
            }

            var users = ReadUsers();
            if (users.Count == 0)
            {
                users.Add(new User { Id = 1, Username = "hr", Password = "hr123", Role = Role.HR });
                users.Add(new User { Id = 2, Username = "manager", Password = "mgr123", Role = Role.Manager });
                users.Add(new User { Id = 3, Username = "accountant", Password = "acc123", Role = Role.Accountant });
                users.Add(new User { Id = 4, Username = "worker", Password = "user123", Role = Role.Employee });
                WriteUsers(users);
            }

            var emps = ReadEmployees();
            if (emps.Count == 0)
            {
                emps.Add(new Employee { Id = 1, FirstName = "Иван", LastName = "Иванов", DepartmentId = 1, HireDate = DateTime.Parse("2020-02-01") });
                emps.Add(new Employee { Id = 2, FirstName = "Ольга", LastName = "Петрова", DepartmentId = 2, HireDate = DateTime.Parse("2021-06-15") });
                WriteEmployees(emps);
            }
        }

        //??-возвращает пустой список если null
        // Users
        public static List<User> ReadUsers() => Read<List<User>>(UsersFile) ?? new List<User>();
        public static void WriteUsers(List<User> users) => Write(UsersFile, users);

        // Departments
        public static List<Department> ReadDepartments() => Read<List<Department>>(DepartmentsFile) ?? new List<Department>();
        public static void WriteDepartments(List<Department> deps) => Write(DepartmentsFile, deps);

        // Employees
        public static List<Employee> ReadEmployees() => Read<List<Employee>>(EmployeesFile) ?? new List<Employee>();
        public static void WriteEmployees(List<Employee> emps) => Write(EmployeesFile, emps);

        // LeaveRequests
        public static List<LeaveRequest> ReadLeaveRequests() => Read<List<LeaveRequest>>(LeaveRequestsFile) ?? new List<LeaveRequest>();
        public static void WriteLeaveRequests(List<LeaveRequest> reqs) => Write(LeaveRequestsFile, reqs);

        // SalaryRecords
        public static List<SalaryRecord> ReadSalaryRecords() => Read<List<SalaryRecord>>(SalaryRecordsFile) ?? new List<SalaryRecord>();
        public static void WriteSalaryRecords(List<SalaryRecord> recs) => Write(SalaryRecordsFile, recs);


        // Mетоды чтения/записи
        static T? Read<T>(string path) //T? - обобщённый тип, который может возвращать null
        {
            try
            {
                if (!File.Exists(path)) return default; //default - значение по умолчанию для типа T (null для ссылочных типов)
                var s = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(s, options);
            }
            catch { return default; }
        }

        static void Write<T>(string path, T obj) //cериализует объект в JSON и записывает в файл
        {
            var s = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(path, s);
        }

        // Генераторы ID
        public static int NextUserId() => (ReadUsers().Select(u => u.Id).DefaultIfEmpty(0).Max()) + 1;
        public static int NextEmployeeId() => (ReadEmployees().Select(e => e.Id).DefaultIfEmpty(0).Max()) + 1;
        public static int NextDepartmentId() => (ReadDepartments().Select(d => d.Id).DefaultIfEmpty(0).Max()) + 1;
        public static int NextLeaveRequestId() => (ReadLeaveRequests().Select(l => l.Id).DefaultIfEmpty(0).Max()) + 1;
        public static int NextSalaryRecordId() => (ReadSalaryRecords().Select(s => s.Id).DefaultIfEmpty(0).Max()) + 1;

            //ReadUsers().Select(u => u.Id) - выбирает все ID пользователей
            //.DefaultIfEmpty(0) - если список пустой, возвращает 0
            //.Max() - находит максимальный ID
            //+ 1 - следующий ID
    }
}
   
