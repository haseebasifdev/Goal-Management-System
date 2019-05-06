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
    public partial class Form1 : Form
    {
        
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            /*ServiceReference1.Users u = new ServiceReference1.Users();
            u.UserName = textBox1.Text;
            u.Password = textBox2.Text;
            if(checkBox1.Checked)
            {
                myserver.addUsers(u, 1);
            }
            else if (checkBox2.Checked)
            {
                myserver.addUsers(u, 2);
            }
            //myserver.addUsers(u);*/
            if (checkBox1.Checked)
            {
                myserver.SignUp(1, textBox1.Text.ToString(), textBox2.Text.ToString());
            }
            else if (checkBox2.Checked)
            {
                myserver.SignUp(2, textBox1.Text.ToString(), textBox2.Text.ToString());
            }
            label3.Text = "Signed up Successfully!";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //ServiceReference1.Users u = new ServiceReference1.Users();
            //u.UserName = textBox1.Text;
            //u.Password = textBox2.Text;
            int[] array = new int[2];
            int flag = -1;
            /*for (i = 0; i < myserver.getCount(); ++i)
            {
                if (textBox1.Text == myserver.getUserName(i) && textBox2.Text == myserver.getPassword(i))
                {
                    flag = true;
                    break;
                }
            }*/
            array = myserver.Login(textBox1.Text, textBox2.Text);
            flag = array[0];
            Program.index = array[1];
            if (flag == 1)
            {
                this.Hide();
                (new Roles()).Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
