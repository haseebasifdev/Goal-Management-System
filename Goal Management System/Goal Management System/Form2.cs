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
    public partial class Form2 : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int work = 0;
            int self = 0;
            int social = 0;
            for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
            {
                for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                {
                    for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                    {
                        if (myserver.getRoleType(Program.index, ri) == "Work")
                        {
                            work++;
                        }
                        else if(myserver.getRoleType(Program.index, ri) == "Self")
                        {
                            self++;
                        }
                        else
                        {
                            social++;
                        }
                    }
                }
            }

            if(work > 0)
            {
                chart1.Series["Percentage"].Points.AddXY("Work", work);
            }
            if (self > 0)
            {
                chart1.Series["Percentage"].Points.AddXY("Self", self);
            }
            if (social > 0)
            {
                chart1.Series["Percentage"].Points.AddXY("Social", social);
            }
         

        }
    }
}
