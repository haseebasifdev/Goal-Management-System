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
    public partial class Tasks : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        int rindex = -1;
        int gindex = -1;
        public Tasks()
        {
            InitializeComponent();
        }
        public Tasks(int ri, int gi)
        {
            InitializeComponent();
            rindex = ri;
            gindex = gi;
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < myserver.getRoleCount(Program.index); ++i)
            {
                for (int j = 0; j<myserver.getGoalCount(Program.index, i); ++j)
                {
                    cmbGoalName.Items.Add(myserver.getGoalName(Program.index, i, j));

                }
            }
            if (gindex != -1)
            {
                cmbGoalName.SelectedItem = myserver.getGoalName(Program.index, rindex, gindex);
                lblRoleName.Text = myserver.getRoleName(Program.index, rindex);
                lblRoleType.Text = myserver.getRoleType(Program.index, rindex);
            }
        }

        private void CmbGoalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            rindex = myserver.getRoleIndex(Program.index, cmbGoalName.SelectedItem.ToString());
            gindex = myserver.getGoalIndex(Program.index, cmbGoalName.SelectedItem.ToString());
            // index = cmbGoalName.SelectedIndex;
            lblRoleName.Text = myserver.getRoleName(Program.index, rindex);
            lblRoleType.Text = myserver.getRoleType(Program.index, rindex);
            taskDataShow();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gindex = myserver.getGoalIndex(Program.index, cmbGoalName.SelectedItem.ToString());
            rindex = myserver.getRoleIndex(Program.index, cmbGoalName.SelectedItem.ToString());
            var t = new ServiceReference1.Tasks();
            t.TaskName = txtTaskName.Text;
            t.TaskTime = dateTimePicker1.Value;
            myserver.addTask(Program.index, rindex, gindex, t);
            taskDataShow();
        }


        void taskDataShow()
        {
            DataGridViewTasks.Rows.Clear();
            for (int i = 0; i < myserver.getTasksCount(Program.index, rindex,gindex); i++)
            {
                DataGridViewTasks.Rows.Add(myserver.getTaskName(Program.index, rindex, gindex, i),myserver.getTaskDate(Program.index, rindex, gindex, i));
            }
        }

        private void DataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                myserver.deleteTask(Program.index, rindex, gindex, e.RowIndex);
                taskDataShow();
            }
            if(e.ColumnIndex == 3)
            {
                ActiveForm.Hide();
                (new EditTasks(myserver.getRoleIndex(Program.index, cmbGoalName.SelectedItem.ToString()), cmbGoalName.SelectedIndex, e.RowIndex)).Show();
            }
        }
    }
}
