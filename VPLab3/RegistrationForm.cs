using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VPLab3
{
    public partial class RegistrationForm : Form
    {
        private LoginForm loginForm;

        public RegistrationForm(LoginForm loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm; 
        }

        private bool ValidateUsername(string login)
        {
            const int minLength = 3;
            const int maxLength = 20;

            if (login.Length < minLength)
            {
                txtUsername.BackColor = Color.Red;
                return false;
            }

            if (login.Length > maxLength)
            {
                txtUsername.BackColor = Color.Red;
                return false;
            }

            string allowedCharactersPattern = "^[a-zA-Z0-9_-]+$";
            if (!Regex.IsMatch(login, allowedCharactersPattern))
            {
                txtUsername.BackColor = Color.Red;
                return false;
            }

            txtUsername.BackColor = Color.White;
            return true;
        }

        private bool ValidatePassword(string password)
        {
            const int minLength = 8;
            const int maxLength = 20;

            if (password.Length < minLength)
            {
                txtPassword.BackColor = Color.Red;
                return false;
            }

            if (password.Length > maxLength)
            {
                txtPassword.BackColor = Color.Green;
                return false;
            }

            if (!CheckPasswordComplexity(password))
            {
                txtPassword.BackColor = Color.Blue;
                return false;
            }

            txtPassword.BackColor = Color.White;
            return true;
        }

        private bool CheckPasswordComplexity(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsSymbol);
        }

        private bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                txtEmail.BackColor = Color.Red;
                return false;
            }

            txtEmail.BackColor = Color.White;
            return true;
        }

        private bool ValidateFullName(string fullName)
        {
            const int minLength = 2;
            const int maxLength = 100;

            if (fullName.Length < minLength)
            {
                txtFullName.BackColor = Color.Red;
                return false;
            }

            if (fullName.Length > maxLength)
            {
                txtFullName.BackColor = Color.Red;
                return false;
            }

            string allowedCharactersPattern = @"^[a-zA-Zа-яА-ЯЁё\s-]+$";
            if (!Regex.IsMatch(fullName, allowedCharactersPattern))
            {
                txtFullName.BackColor = Color.Red;
                return false;
            }

            txtFullName.BackColor = Color.White;
            return true;
        }

        private bool ValidateDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Today)
            {
                this.dateOfBirth.CalendarTitleBackColor = Color.Red;
                return false;
            }

            this.dateOfBirth.CalendarTitleBackColor = Color.White;
            return true;
        }

        private bool ValidateNativeLanguage(string nativeLanguage)
        {
            const int minLength = 2;
            const int maxLength = 50;

            if (nativeLanguage.Length < minLength)
            {
                txtNativeLanguage.BackColor = Color.Red;
                return false;
            }

            if (nativeLanguage.Length > maxLength)
            {
                txtNativeLanguage.BackColor = Color.Red;
                return false;
            }

            string allowedCharactersPattern = @"^[a-zA-Z\s]+$";
            if (!Regex.IsMatch(nativeLanguage, allowedCharactersPattern))
            {
                txtNativeLanguage.BackColor = Color.Red;
                return false;
            }

            txtNativeLanguage.BackColor = Color.White;
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int validations = 0;

            validations += Convert.ToInt16(ValidateUsername(txtUsername.Text));
            validations += Convert.ToInt16(ValidatePassword(txtPassword.Text));
            validations += Convert.ToInt16(ValidateEmail(txtEmail.Text));
            validations += Convert.ToInt16(ValidateFullName(txtFullName.Text));
            validations += Convert.ToInt16(ValidateDateOfBirth(dateOfBirth.Value));
            validations += Convert.ToInt16(ValidateNativeLanguage(txtNativeLanguage.Text));

            if (validations == 6)
            {
                GlobalVariables.Username = txtUsername.Text;
                GlobalVariables.Password = txtPassword.Text;

                loginForm.SetCredentials(txtUsername.Text, txtPassword.Text);
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.BackColor = Color.White;

            txtPassword.Text = "";
            txtPassword.BackColor = Color.White;

            txtEmail.Text = "";
            txtEmail.BackColor = Color.White;

            txtFullName.Text = "";
            txtFullName.BackColor = Color.White;

            radioButtonF.Checked = true;

            dateOfBirth.Value = DateTime.Today;
            dateOfBirth.CalendarTitleBackColor = Color.White;

            txtNativeLanguage.Text = "";
            txtNativeLanguage.BackColor = Color.White;

            checkBoxRo.Checked = false;
            checkBoxEn.Checked = false;
            checkBoxDe.Checked = false;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
