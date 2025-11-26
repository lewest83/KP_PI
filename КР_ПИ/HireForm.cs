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
    public partial class HireForm : Form
    {
        public string FirstName => txtFirst.Text;
        public string LastName => txtLast.Text;
        public int? DepartmentId => cmbDept.SelectedItem is DepartmentItem it ? it.Id : null;
        public DateTime HireDate => dateHire.Value.Date;
        public HireForm()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HireForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadDepartments()
        {
            foreach (var d in DataStore.ReadDepartments())
                cmbDept.Items.Add(new DepartmentItem { Id = d.Id, Name = d.Name });
            if (cmbDept.Items.Count > 0) cmbDept.SelectedIndex = 0;
        }

        class DepartmentItem
        {
            public int Id;
            public string Name = "";
            public override string ToString() => Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
