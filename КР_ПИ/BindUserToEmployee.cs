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
    public partial class BindUserToEmployee : Form
    {
        public BindUserToEmployee()
        {
            InitializeComponent();

            LoadUsers();
            LoadEmployees();
        }

        private void BindUserToEmployee_Load(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            var users = DataStore.ReadUsers()
                .Where(u => u.EmployeeId == null)   // показываем только несвязанных
                .ToList();

            cmbUsers.Items.Clear();
            foreach (var u in users)
                cmbUsers.Items.Add($"{u.Id}: {u.Username}");

            if (cmbUsers.Items.Count > 0)
                cmbUsers.SelectedIndex = 0;
        }

        private void LoadEmployees()
        {
            var employees = DataStore.ReadEmployees();

            cmbEmployees.Items.Clear();
            foreach (var e in employees)
                cmbEmployees.Items.Add($"{e.Id}: {e.LastName}");

            if (cmbEmployees.Items.Count > 0)
                cmbEmployees.SelectedIndex = 0;
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null || cmbEmployees.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя и сотрудника!");
                return;
            }

            int userId = int.Parse(cmbUsers.SelectedItem.ToString().Split(':')[0]);
            int employeeId = int.Parse(cmbEmployees.SelectedItem.ToString().Split(':')[0]);

            var users = DataStore.ReadUsers();
            var user = users.First(u => u.Id == userId);

            user.EmployeeId = employeeId;

            DataStore.WriteUsers(users);

            MessageBox.Show("Связь успешно выполнена!");

            this.Close();
        }
    }
}
