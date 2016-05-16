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
    public partial class MainForm : Form
    {
        BusinessLayer bl = null;
        public MainForm()
        {
            InitializeComponent();
            bl = BusinessLayer.getInstance();
        }

        private void submitEzhar_Click(object sender, EventArgs e)
        {
            Program.ezharForm = new EzharForm();
            Program.ezharForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            signUpForm signForm = new signUpForm();
            signForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            bl.logOut();
            this.Hide();
            Program.loginForm.Show();
        }

    }
}
