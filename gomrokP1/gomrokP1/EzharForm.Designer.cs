namespace gomrokP1
{
    partial class EzharForm
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
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.totalVal = new System.Windows.Forms.TextBox();
            this.sCountry = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.transport = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submitEzharForm = new System.Windows.Forms.Button();
            this.goodsList = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lName.Location = new System.Drawing.Point(60, 74);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(273, 31);
            this.lName.TabIndex = 0;
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fName.Location = new System.Drawing.Point(60, 25);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(273, 31);
            this.fName.TabIndex = 0;
            this.fName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ssn
            // 
            this.ssn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ssn.Location = new System.Drawing.Point(60, 126);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(273, 31);
            this.ssn.TabIndex = 0;
            // 
            // totalVal
            // 
            this.totalVal.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.totalVal.Location = new System.Drawing.Point(60, 226);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(273, 31);
            this.totalVal.TabIndex = 0;
            // 
            // sCountry
            // 
            this.sCountry.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sCountry.Location = new System.Drawing.Point(60, 278);
            this.sCountry.Name = "sCountry";
            this.sCountry.Size = new System.Drawing.Size(273, 31);
            this.sCountry.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 31);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // transport
            // 
            this.transport.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transport.Items.Add("هوایی");
            this.transport.Items.Add("زمینی");
            this.transport.Items.Add("دریایی");
            this.transport.Location = new System.Drawing.Point(60, 329);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(272, 31);
            this.transport.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(420, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(366, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(358, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "شناسه ی ملی ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(377, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاریخ اظهار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(387, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "ارزش کل ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(382, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "کشور مبدا";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(371, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "نحوه ی ورود";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(267, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "افزودن کالا";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitEzharForm
            // 
            this.submitEzharForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.submitEzharForm.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.submitEzharForm.Location = new System.Drawing.Point(60, 480);
            this.submitEzharForm.Name = "submitEzharForm";
            this.submitEzharForm.Size = new System.Drawing.Size(179, 33);
            this.submitEzharForm.TabIndex = 4;
            this.submitEzharForm.Text = "ثبت اظهار نامه";
            this.submitEzharForm.UseVisualStyleBackColor = false;
            this.submitEzharForm.Click += new System.EventHandler(this.submitEzharForm_Click);
            // 
            // goodsList
            // 
            this.goodsList.BackColor = System.Drawing.SystemColors.Menu;
            this.goodsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodsList.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.goodsList.LabelWrap = false;
            this.goodsList.Location = new System.Drawing.Point(61, 385);
            this.goodsList.Name = "goodsList";
            this.goodsList.RightToLeftLayout = true;
            this.goodsList.Size = new System.Drawing.Size(270, 71);
            this.goodsList.TabIndex = 5;
            this.goodsList.UseCompatibleStateImageBehavior = false;
            this.goodsList.View = System.Windows.Forms.View.List;
            this.goodsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(371, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "لیست کالا ها";
            // 
            // EzharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(539, 535);
            this.Controls.Add(this.goodsList);
            this.Controls.Add(this.submitEzharForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transport);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sCountry);
            this.Controls.Add(this.totalVal);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EzharForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت اظهارنامه ";
            this.Load += new System.EventHandler(this.EzharForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox totalVal;
        private System.Windows.Forms.TextBox sCountry;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DomainUpDown transport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitEzharForm;
        private System.Windows.Forms.ListView goodsList;
        private System.Windows.Forms.Label label8;
    }
}