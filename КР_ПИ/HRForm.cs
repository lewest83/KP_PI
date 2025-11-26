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
    public partial class HRForm : Form
    {
        private readonly User _user;
        public HRForm(User user)
        {
            _user = user;
            InitializeComponent();

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            lstEmployees.Items.Clear();
            var emps = DataStore.ReadEmployees();
            var deps = DataStore.ReadDepartments();
            foreach (var e in emps)
            {
                var dep = deps.FirstOrDefault(d => d.Id == e.DepartmentId);
                lstEmployees.Items.Add($"{e.Id}: {e.LastName} {e.FirstName} — {(dep?.Name ?? "—")} (Принят: {e.HireDate:d})");
            }
        }

        private void HRForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            var f = new HireForm();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var emps = DataStore.ReadEmployees();
                var emp = new Employee
                {
                    Id = DataStore.NextEmployeeId(),
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    DepartmentId = f.DepartmentId,
                    HireDate = f.HireDate
                };
                emps.Add(emp);
                DataStore.WriteEmployees(emps);
                LoadEmployees();
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }
            var text = lstEmployees.SelectedItem.ToString();
            var id = int.Parse(text!.Split(':')[0]);
            var emps = DataStore.ReadEmployees();
            var emp = emps.FirstOrDefault(x => x.Id == id);
            if (emp == null) return;
            emp.TerminationDate = DateTime.Now;
            DataStore.WriteEmployees(emps);
            LoadEmployees();
            MessageBox.Show("Сотрудник уволен (дата занесена)");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var emps = DataStore.ReadEmployees();
            var active = emps.Count(e => e.TerminationDate == null);
            var deps = DataStore.ReadDepartments();
            string report = $"Всего активных сотрудников: {active}\n";
            foreach (var d in deps)
            {
                var count = emps.Count(e => e.DepartmentId == d.Id);
                report += $"{d.Name}: {count}\n";
            }
            MessageBox.Show(report, "Отчёт по персоналу");
        }
    }
}
