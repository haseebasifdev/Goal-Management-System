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
    public partial class Reports : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Reports()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form2()).Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {


            cmbDuration.Items.Add("Today");
            cmbDuration.Items.Add("Week");
            cmbDuration.Items.Add("Month");
            cmbDuration.Items.Add("All");
            /* for (int i = 0; i < myserver.getRoleCount(Program.index); ++i)
            {
                for (int j = 0; j<myserver.getGoalCount(Program.index, i); ++j)
                {
                    for (int k = 0; k < myserver.getTasksCount(Program.index, i, j); ++k)
                    {
                        dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, i, j, k), myserver.getTaskDate(Program.index, i, j, k).ToString());
                    }


                }*/
        }
        private void dataShow(int duration)
        {
            DateTime date = DateTime.Today;
            switch (duration)
            {

                case 0:
                {
                        dataGridViewReport.Rows.Clear();
                        date = date.AddDays(1);
                        for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
                        {
                            for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                            {
                                for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                                {
                                    if (myserver.getTaskDate(Program.index, ri, gi, ti) < date)
                                    {
                                        dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, ri, gi, ti), myserver.getTaskDate(Program.index, ri, gi, ti), myserver.getRoleType(Program.index, ri));
                                    }
                                }
                            }
                        }
                        break;
                    }
                case 1:
                {
                        dataGridViewReport.Rows.Clear();
                        date = date.AddDays(7);
                        for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
                        {
                            for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                            {
                                for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                                {
                                    if (myserver.getTaskDate(Program.index, ri, gi, ti) < date)
                                    {
                                        dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, ri, gi, ti), myserver.getTaskDate(Program.index, ri, gi, ti), myserver.getRoleType(Program.index, ri));
                                    }
                                }
                            }
                        }
                        break;
                    }
                case 2:
                {
                        dataGridViewReport.Rows.Clear();
                        date = date.AddDays(30);
                        for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
                        {
                            for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                            {
                                for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                                {
                                    if (myserver.getTaskDate(Program.index, ri, gi, ti) < date)
                                    {
                                        dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, ri, gi, ti), myserver.getTaskDate(Program.index, ri, gi, ti), myserver.getRoleType(Program.index, ri));
                                    }
                                }
                            }
                        }
                        break;
                        /*for (int i = 0; i < 30; i++)
                        {
                            dataGridViewReport.Rows.Clear();
                            date = date.AddDays(i);
                            for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
                            {
                                for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                                {
                                    for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                                    {
                                        if (myserver.getTaskDate(Program.index, ri, gi, ti) < date)
                                        {
                                            dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, ri, gi, ti), myserver.getTaskDate(Program.index, ri, gi, ti), myserver.getRoleType(Program.index, ri));
                                        }
                                    }
                                }
                            }
                        }
                        break;*/
                    }
                case 3:
                {
                        dataGridViewReport.Rows.Clear();
                        for (int ri = 0; ri < myserver.getRoleCount(Program.index); ri++)
                        {
                            for (int gi = 0; gi < myserver.getGoalCount(Program.index, ri); gi++)
                            {
                                for (int ti = 0; ti < myserver.getTasksCount(Program.index, ri, gi); ti++)
                                {
                                    dataGridViewReport.Rows.Add(myserver.getTaskName(Program.index, ri, gi, ti), myserver.getTaskDate(Program.index, ri, gi, ti), myserver.getRoleType(Program.index, ri));
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void CmbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataShow(cmbDuration.SelectedIndex);
        }
    }
}

