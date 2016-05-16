using System;
using System.Windows.Forms;
namespace gomrokP1
{
    partial class LoginForm
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

        public void clearForm()
        {
            this.username.Text = "نام کاربری";
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Text = "رمز عبور";
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void MyInit()
        {
            this.username.GotFocus += g_GotFocus;
            this.password.GotFocus += g_GotFocus;
        }
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.wrongNotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.login.Location = new System.Drawing.Point(102, 49);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(155, 68);
            this.login.TabIndex = 0;
            this.login.Text = "ورود";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.Location = new System.Drawing.Point(272, 49);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.Size = new System.Drawing.Size(199, 31);
            this.username.TabIndex = 1;
            this.username.Text = "نام کاربری";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(272, 86);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password.Size = new System.Drawing.Size(199, 31);
            this.password.TabIndex = 2;
            this.password.Text = "رمز عبور";
            // 
            // wrongNotif
            // 
            this.wrongNotif.AutoSize = true;
            this.wrongNotif.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.wrongNotif.ForeColor = System.Drawing.Color.OrangeRed;
            this.wrongNotif.Location = new System.Drawing.Point(293, 149);
            this.wrongNotif.Name = "wrongNotif";
            this.wrongNotif.Size = new System.Drawing.Size(178, 24);
            this.wrongNotif.TabIndex = 3;
            this.wrongNotif.Text = "نام کاربری یا پسورد غلط می باشد";
            this.wrongNotif.Visible = false;
            this.wrongNotif.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 186);
            this.Controls.Add(this.wrongNotif);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "ورود به سامانه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void g_GotFocus(object sender, EventArgs e)
        {
            var tbox = sender as TextBox;
            tbox.Text = "";
            tbox.ForeColor = System.Drawing.SystemColors.ControlText;
            tbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            if (tbox.Name == "password")
            {
                tbox.PasswordChar = '*';
            }
        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private Label wrongNotif;
    }
}

