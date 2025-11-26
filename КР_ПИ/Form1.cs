namespace КР_ПИ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            cmbUsers.Items.Clear();

            var users = DataStore.ReadUsers();
            foreach (var u in users)
                cmbUsers.Items.Add(u.Username);

            if (cmbUsers.Items.Count > 0)
                cmbUsers.SelectedIndex = 0;

            txtPass.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = DataStore.ReadUsers();
            var user = users.FirstOrDefault(u => u.Username == txtUser.Text && u.Password == txtPass.Text);
            if (user == null)
            {
                MessageBox.Show("Неверное имя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            var main = new MainForm(user, this);
            //main.FormClosed += (s, e) => this.Close();
            main.Show();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem != null)
                txtUser.Text = cmbUsers.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ClearFields()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            LoadUsers();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
