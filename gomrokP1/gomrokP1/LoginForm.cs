using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gomrokP1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MyInit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            //todo
            Employee user = DB.getDB().getUser(username);

            BusinessLayer.getInstance().setCurrentUser(user);
            if (user == null || user.authenticate(username, password) == false)
                this.wrongNotif.Visible = true;
            else
            {
                Program.mainForm = new MainForm();
                Program.mainForm.Show();
                Program.loginForm.Hide();
                this.clearForm();
                //Program.mainForm.customInit();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}


