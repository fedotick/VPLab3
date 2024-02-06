using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLab3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == GlobalVariables.Username && password == GlobalVariables.Password)
            {
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.FormClosed += AnotherForm_FormClosed;
                this.Hide();
                welcomeForm.Show();
            }
        }

        private void AnotherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.FormClosed += AnotherForm_FormClosed;
            this.Hide(); 
            registrationForm.Show();
        }

        internal void SetCredentials(string username, string password)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
        }
    }
}
