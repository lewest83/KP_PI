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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbRole.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                            string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }
            var users = DataStore.ReadUsers();
            if (users.Any(u => u.Username == txtUser.Text))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }
            var user = new User
            {
                Id = DataStore.NextUserId(),
                Username = txtUser.Text,
                Password = txtPass.Text,
                Role = (Role)Enum.Parse(typeof(Role),
                cmbRole.SelectedItem.ToString()!),
                EmployeeId = null


            };

            users.Add(user);
            DataStore.WriteUsers(users);
            MessageBox.Show("Пользователь создан.");
            this.Close();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
