using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КР_ПИ
{
    public partial class EmployeeForm : Form
    {
        private readonly User _user;
        public EmployeeForm(User user)
        {
            InitializeComponent();
            _user = user;

            LoadMyInfo();
        }

        private void LoadMyInfo()
        {
            if (_user.EmployeeId == null)
            {
                lblInfo.Text = "Вас нет в базе.";
                return;
            }

            var emp = DataStore.ReadEmployees().
                FirstOrDefault(e => e.Id == _user.EmployeeId);

            if (emp == null)
            {
                lblInfo.Text = "Сотрудник не найден.";
                return;
            }
            var dep = DataStore.ReadDepartments().
                FirstOrDefault(d => d.Id == emp.DepartmentId);

            lblInfo.Text = $"Сотрудник: {emp.LastName} {emp.FirstName}\nОтдел: {dep?.Name}\nПринят: {emp.HireDate:d}";
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            var f = new ApplyLeaveForm(_user);
            f.ShowDialog();
        }
    }
}
