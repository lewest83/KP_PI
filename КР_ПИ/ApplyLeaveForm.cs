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
    public partial class ApplyLeaveForm : Form
    {
        private readonly User _user;
        public ApplyLeaveForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void ApplyLeaveForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_user.EmployeeId == null) 
            { 
                MessageBox.Show("Не найден сотрудник"); 
                return; 
            }

            var reqs = DataStore.ReadLeaveRequests();
            var req = new LeaveRequest { Id = DataStore.NextLeaveRequestId(),
                EmployeeId = _user.EmployeeId.Value,
                StartDate = dtFrom.Value.Date,
                EndDate = dtTo.Value.Date,
                Reason = txtReason.Text };

            reqs.Add(req);
            DataStore.WriteLeaveRequests(reqs);
            MessageBox.Show("Заявка отправлена на согласование");
            this.Close();
        }
    }
}
