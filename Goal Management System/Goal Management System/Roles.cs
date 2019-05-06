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
    public partial class Roles : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Work");
            comboBox1.Items.Add("Self");
            comboBox1.Items.Add("Social");
        }
        void dataShow()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < myserver.getRoleCount(Program.index); i++)
            {
                dataGridView1.Rows.Add(myserver.getRoleName(Program.index, i ), myserver.getRoleType(Program.index, i));
            }
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            var myRole = new ServiceReference1.Roles();
            myRole.RoleName = txtRoleName.Text;
            myRole.RoleType = comboBox1.SelectedItem.ToString();
            myserver.addRole(Program.index, myRole);
            dataShow();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                myserver.deleteRole(Program.index, e.RowIndex);
                dataShow();
            }
            if (e.ColumnIndex == 3)
            {
                var r = new ServiceReference1.Roles();
                r.RoleName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                r.RoleType = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Hide();
                (new EditRoles(r, e.RowIndex)).Show();


                /*var r = new ServiceReference1.Roles();
                r.RoleName = myserver.getRoleName(Program.index, e.RowIndex);
                r.RoleType = myserver.getRoleType(Program.index, e.RowIndex);
                EditRoles er = new EditRoles(r,e.RowIndex);
                ActiveForm.Hide();
                er.Show();*/
            }
            if (e.ColumnIndex == 4)
            {
                this.Hide();
                (new Goals(e.RowIndex)).Show();
            }

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
