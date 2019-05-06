using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goal_Management_System
{
    public partial class EditRoles : Form
    {
        int index;
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        ServiceReference1.Roles r = new ServiceReference1.Roles();
        public EditRoles()
        {
            InitializeComponent();
        }
        public EditRoles(ServiceReference1.Roles r, int i)
        {
            index = i;
            this.r = r;
            InitializeComponent();
            //txtEditRoleName.Text = r.RoleName;
            //cmbEditRoleType.SelectedItem = r.RoleType;
        }

        private void EditRoles_Load(object sender, EventArgs e)
        {
            cmbEditRoleType.Items.Add("Work");
            cmbEditRoleType.Items.Add("Self");
            cmbEditRoleType.Items.Add("Social");
            txtEditRoleName.Text = r.RoleName;
            cmbEditRoleType.SelectedItem = r.RoleType;
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            //var r = new ServiceReference1.Roles();
            r.RoleName = txtEditRoleName.Text;
            r.RoleType = cmbEditRoleType.SelectedItem.ToString();
            myserver.editRole(Program.index, index, r);
            //myserver.deleteRole(Program.index, index);
            //myserver.addRole(Program.index, r);
            ActiveForm.Hide();
            Roles a = new Roles();
            a.Show();
        }
    }
}
