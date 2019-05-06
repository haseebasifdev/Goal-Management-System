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
    public partial class EditTasks : Form
    {
        int rindex;
        int gindex;
        int tindex;
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        ServiceReference1.Tasks t = new ServiceReference1.Tasks();
        public EditTasks()
        {
            InitializeComponent();
        }
        public EditTasks(int ri, int gi, int ti)
        {
            InitializeComponent();
            rindex = ri;
            gindex = gi;
            tindex = ti;
            
            t.TaskName = myserver.getTaskName(Program.index, rindex, gindex, tindex);
            txtEditTaskName.Text = t.TaskName;
            t.TaskTime = myserver.getTaskDate(Program.index, rindex, gindex, tindex);
            dateTimePicker1.Value = t.TaskTime;

        }
        private void EditTasks_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            t.TaskName = txtEditTaskName.Text;
            t.TaskTime = dateTimePicker1.Value;
            myserver.editTask(Program.index, rindex, gindex, tindex, t);
            //myserver.deleteTask(Program.index, rindex, gindex, tindex);
            //myserver.addTask(Program.index, rindex, gindex, t);
            (new Tasks()).Show();
        }
    }
}
