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
    public partial class EditGoals : Form
    {
        int gindex;
        int rindex;
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        ServiceReference1.Goals g = new ServiceReference1.Goals();
        public EditGoals()
        {
            InitializeComponent();
        }
        public EditGoals(int ri,int gi,string roleName, string roleType)
        {
            InitializeComponent();
            
            gindex = gi;
            rindex = ri;
            label2.Text = roleName;
            label4.Text = roleType;
            txtEditGoal.Text =  myserver.getGoalName(Program.index, rindex, gindex);
            
        }

        private void EditGoals_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            g.GoalName = txtEditGoal.Text;
            myserver.editGoal(Program.index, rindex, gindex, g);
            //myserver.deleteGoal(Program.index, rindex, gindex);
            //myserver.addGoal(Program.index, rindex, txtEditGoal.Text);
            ActiveForm.Hide();
            (new Goals()).Show(); 
        }
    }
}
