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
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
        }

        private void AccountantForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLOad_Click(object sender, EventArgs e)
        {
            lstPayroll.Items.Clear();
            var emps = DataStore.ReadEmployees();
            foreach (var emp in emps)
            {
                var sickDays = DataStore.ReadLeaveRequests().
                    Where(l => l.EmployeeId == emp.Id && 
                    l.Reason.Contains("боль")).Count();

                var vacations = DataStore.ReadLeaveRequests().
                    Where(l => l.EmployeeId == emp.Id && 
                    l.Reason.Contains("отпуск")).Count();

                lstPayroll.Items.Add($"{emp.Id}: " +
                    $"{emp.LastName} {emp.FirstName} — больничных заявок: " +
                    $"{sickDays}, отпускных заявок: {vacations}");
            }
        }
    }
}
