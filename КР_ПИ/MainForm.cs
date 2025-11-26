using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace КР_ПИ
{

    public partial class MainForm : Form
    {
        private readonly User _user;

        Button btnHR = new Button() { Text = "Кадровик", Left = 40, Top = 80, Width = 150 };
        Button btnManager = new Button() { Text = "Начальник отдела", Left = 40, Top = 80, Width = 150 };
        Button btnAccountant = new Button() { Text = "Бухгалтер", Left = 40, Top = 80, Width = 150 };
        Button btnEmployee = new Button() { Text = "Работник", Left = 40, Top = 80, Width = 150 };

        private Form _loginForm;
        private User _currentUser;
        public MainForm(User user, Form loginForm)
        {
            _currentUser = user;
            _loginForm = loginForm;
            _user = user;
            InitializeComponent();

            lblUser.Text = $"Пользователь: {user.Username} ({user.Role})";


            if (user.Role == Role.HR) this.Controls.Add(btnHR);
            if (user.Role == Role.Manager) this.Controls.Add(btnManager);
            if (user.Role == Role.Accountant) this.Controls.Add(btnAccountant);
            if (user.Role == Role.Employee) this.Controls.Add(btnEmployee);

            if (user.Role == Role.HR)
            {
                Button btnBind = new Button()
                {
                    Text = "Связать пользователя с сотрудником",
                    Left = 40,
                    Top = 150,
                    Width = 300
                };
                btnBind.Click += (s, e) =>
                {
                    var f = new BindUserToEmployee();
                    f.ShowDialog();
                };

                Controls.Add(btnBind);
            }

            btnHR.Click += (s, e) => { new HRForm(_user).ShowDialog(); };
            btnManager.Click += (s, e) => { new ManagerForm(_user).ShowDialog(); };
            btnAccountant.Click += (s, e) => { new AccountantForm().ShowDialog(); };
            btnEmployee.Click += (s, e) => { new EmployeeForm(_user).ShowDialog(); };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.Show();
            var login = _loginForm as LoginForm;
            if (login != null)
            {
                login.ClearFields();
            }
        }

        
    }
}
