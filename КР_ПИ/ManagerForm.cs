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
    public partial class ManagerForm : Form
    {
        private readonly User _user;
        public ManagerForm(User user)
        {
            _user = user;
            InitializeComponent();

            LoadDepartmentEmployees();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDepartmentEmployees()
        {
            var reqs = DataStore.ReadLeaveRequests().
                Where(l => l.Status == LeaveStatus.Pending).ToList();
            foreach (var r in reqs)
            {
                var emp = DataStore.ReadEmployees().
                    FirstOrDefault(e => e.Id == r.EmployeeId);
                lstDeptEmployees.Items.Add($"Req {r.Id}: " +
                    $"{emp?.LastName} {emp?.FirstName} " +
                    $"({r.StartDate:d} - {r.EndDate:d}) — {r.Reason}");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lstDeptEmployees.SelectedItem == null) 
            { 
                MessageBox.Show("Выберите заявку"); 
                return; 
            }
            var text = lstDeptEmployees.SelectedItem.ToString();
            var id = int.Parse(text!.Split(':')[0].Split(' ')[1]);
            var reqs = DataStore.ReadLeaveRequests();
            var req = reqs.FirstOrDefault(x => x.Id == id);
            if (req == null) return;
            req.Status = LeaveStatus.Approved;
            DataStore.WriteLeaveRequests(reqs);
            MessageBox.Show("Заявка согласована");
            lstDeptEmployees.Items.Remove(lstDeptEmployees.SelectedItem);
        }
    }
}
