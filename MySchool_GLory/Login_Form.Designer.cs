namespace MySchool_GLory
{
    partial class Login_Form
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
            this.button_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.Login_Area = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Login_Area.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(272, 263);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 35);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(131, 137);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(216, 34);
            this.textBox_Username.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(20, 209);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(83, 18);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(131, 199);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(216, 34);
            this.textBox_password.TabIndex = 4;
            // 
            // Login_Area
            // 
            this.Login_Area.Controls.Add(this.button1);
            this.Login_Area.Controls.Add(this.label2);
            this.Login_Area.Controls.Add(this.button_Login);
            this.Login_Area.Controls.Add(this.textBox_password);
            this.Login_Area.Controls.Add(this.label1);
            this.Login_Area.Controls.Add(this.Password);
            this.Login_Area.Controls.Add(this.textBox_Username);
            this.Login_Area.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Area.Location = new System.Drawing.Point(88, 22);
            this.Login_Area.Name = "Login_Area";
            this.Login_Area.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login_Area.Size = new System.Drawing.Size(441, 352);
            this.Login_Area.TabIndex = 5;
            this.Login_Area.TabStop = false;
            this.Login_Area.Text = "Login Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your credentials below to login:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(628, 424);
            this.Controls.Add(this.Login_Area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Login_Area.ResumeLayout(false);
            this.Login_Area.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.GroupBox Login_Area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}