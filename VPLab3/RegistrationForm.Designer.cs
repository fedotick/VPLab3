namespace VPLab3
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtNativeLanguage = new System.Windows.Forms.TextBox();
            this.checkBoxRo = new System.Windows.Forms.CheckBox();
            this.checkBoxEn = new System.Windows.Forms.CheckBox();
            this.checkBoxDe = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(299, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(299, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(299, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(299, 149);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(156, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Checked = true;
            this.radioButtonF.Location = new System.Drawing.Point(299, 176);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 1;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(336, 175);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 1;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateOfBirth.Location = new System.Drawing.Point(299, 198);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(156, 20);
            this.dateOfBirth.TabIndex = 2;
            // 
            // txtNativeLanguage
            // 
            this.txtNativeLanguage.Location = new System.Drawing.Point(299, 224);
            this.txtNativeLanguage.Name = "txtNativeLanguage";
            this.txtNativeLanguage.Size = new System.Drawing.Size(156, 20);
            this.txtNativeLanguage.TabIndex = 3;
            // 
            // checkBoxRo
            // 
            this.checkBoxRo.AutoSize = true;
            this.checkBoxRo.Location = new System.Drawing.Point(299, 250);
            this.checkBoxRo.Name = "checkBoxRo";
            this.checkBoxRo.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRo.TabIndex = 4;
            this.checkBoxRo.Text = "Romanian";
            this.checkBoxRo.UseVisualStyleBackColor = true;
            // 
            // checkBoxEn
            // 
            this.checkBoxEn.AutoSize = true;
            this.checkBoxEn.Location = new System.Drawing.Point(299, 273);
            this.checkBoxEn.Name = "checkBoxEn";
            this.checkBoxEn.Size = new System.Drawing.Size(60, 17);
            this.checkBoxEn.TabIndex = 4;
            this.checkBoxEn.Text = "English";
            this.checkBoxEn.UseVisualStyleBackColor = true;
            // 
            // checkBoxDe
            // 
            this.checkBoxDe.AutoSize = true;
            this.checkBoxDe.Location = new System.Drawing.Point(299, 296);
            this.checkBoxDe.Name = "checkBoxDe";
            this.checkBoxDe.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDe.TabIndex = 4;
            this.checkBoxDe.Text = "German";
            this.checkBoxDe.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(299, 319);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Location = new System.Drawing.Point(357, 345);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(33, 13);
            this.linkLabelLogin.TabIndex = 6;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.checkBoxDe);
            this.Controls.Add(this.checkBoxEn);
            this.Controls.Add(this.checkBoxRo);
            this.Controls.Add(this.txtNativeLanguage);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.TextBox txtNativeLanguage;
        private System.Windows.Forms.CheckBox checkBoxRo;
        private System.Windows.Forms.CheckBox checkBoxEn;
        private System.Windows.Forms.CheckBox checkBoxDe;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}