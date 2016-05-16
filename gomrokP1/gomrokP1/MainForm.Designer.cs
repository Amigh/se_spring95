namespace gomrokP1
{
    partial class MainForm
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
        public void customInit()
        {
            if (!BusinessLayer.getInstance().isCurrentUserAdmin())
            {
                this.registerButton.Visible = false;
            }
            else
                this.registerButton.Visible = true;
        }


        
#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitEzhar = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitEzhar
            // 
            this.submitEzhar.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.submitEzhar.Location = new System.Drawing.Point(77, 48);
            this.submitEzhar.Name = "submitEzhar";
            this.submitEzhar.Size = new System.Drawing.Size(150, 54);
            this.submitEzhar.TabIndex = 0;
            this.submitEzhar.Text = "ثبت اظهار نامه";
            this.submitEzhar.UseVisualStyleBackColor = true;
            this.submitEzhar.Click += new System.EventHandler(this.submitEzhar_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.registerButton.Location = new System.Drawing.Point(77, 108);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(150, 54);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "ثبت نام کاربر";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.logOutButton.Location = new System.Drawing.Point(77, 168);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(150, 54);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "خروج";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 363);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.submitEzhar);
            this.Name = "MainForm";
            this.Text = "سامانه ی جامع گمرک";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button submitEzhar;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button logOutButton;
    }
}