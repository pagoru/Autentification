namespace Autentification
{
    partial class Form
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Login_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login_Username = new System.Windows.Forms.Label();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.txt_Login_Password = new System.Windows.Forms.TextBox();
            this.lbl_Register_Password = new System.Windows.Forms.Label();
            this.txt_Register_Password = new System.Windows.Forms.TextBox();
            this.lbl_Register_Username = new System.Windows.Forms.Label();
            this.txt_Register_Username = new System.Windows.Forms.TextBox();
            this.lbl_Register_RePassword = new System.Windows.Forms.Label();
            this.txt_Register_RePassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(6, 208);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(167, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Login_Password);
            this.groupBox1.Controls.Add(this.txt_Login_Password);
            this.groupBox1.Controls.Add(this.lbl_Login_Username);
            this.groupBox1.Controls.Add(this.txt_Login_Username);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Register_RePassword);
            this.groupBox2.Controls.Add(this.txt_Register_RePassword);
            this.groupBox2.Controls.Add(this.lbl_Register_Password);
            this.groupBox2.Controls.Add(this.txt_Register_Password);
            this.groupBox2.Controls.Add(this.lbl_Register_Username);
            this.groupBox2.Controls.Add(this.txt_Register_Username);
            this.groupBox2.Controls.Add(this.btn_Register);
            this.groupBox2.Location = new System.Drawing.Point(197, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(6, 208);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(167, 23);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Login_Username
            // 
            this.txt_Login_Username.Location = new System.Drawing.Point(6, 42);
            this.txt_Login_Username.Name = "txt_Login_Username";
            this.txt_Login_Username.Size = new System.Drawing.Size(167, 20);
            this.txt_Login_Username.TabIndex = 1;
            // 
            // lbl_Login_Username
            // 
            this.lbl_Login_Username.Location = new System.Drawing.Point(6, 16);
            this.lbl_Login_Username.Name = "lbl_Login_Username";
            this.lbl_Login_Username.Size = new System.Drawing.Size(167, 23);
            this.lbl_Login_Username.TabIndex = 2;
            this.lbl_Login_Username.Text = "Username";
            this.lbl_Login_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.Location = new System.Drawing.Point(6, 65);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(167, 23);
            this.lbl_Login_Password.TabIndex = 4;
            this.lbl_Login_Password.Text = "Password";
            this.lbl_Login_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Login_Password
            // 
            this.txt_Login_Password.Location = new System.Drawing.Point(6, 91);
            this.txt_Login_Password.Name = "txt_Login_Password";
            this.txt_Login_Password.PasswordChar = '*';
            this.txt_Login_Password.Size = new System.Drawing.Size(167, 20);
            this.txt_Login_Password.TabIndex = 3;
            // 
            // lbl_Register_Password
            // 
            this.lbl_Register_Password.Location = new System.Drawing.Point(6, 65);
            this.lbl_Register_Password.Name = "lbl_Register_Password";
            this.lbl_Register_Password.Size = new System.Drawing.Size(167, 23);
            this.lbl_Register_Password.TabIndex = 8;
            this.lbl_Register_Password.Text = "Password";
            this.lbl_Register_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Register_Password
            // 
            this.txt_Register_Password.Location = new System.Drawing.Point(6, 91);
            this.txt_Register_Password.Name = "txt_Register_Password";
            this.txt_Register_Password.PasswordChar = '*';
            this.txt_Register_Password.Size = new System.Drawing.Size(167, 20);
            this.txt_Register_Password.TabIndex = 7;
            // 
            // lbl_Register_Username
            // 
            this.lbl_Register_Username.Location = new System.Drawing.Point(6, 16);
            this.lbl_Register_Username.Name = "lbl_Register_Username";
            this.lbl_Register_Username.Size = new System.Drawing.Size(167, 23);
            this.lbl_Register_Username.TabIndex = 6;
            this.lbl_Register_Username.Text = "Username";
            this.lbl_Register_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Register_Username
            // 
            this.txt_Register_Username.Location = new System.Drawing.Point(6, 42);
            this.txt_Register_Username.Name = "txt_Register_Username";
            this.txt_Register_Username.Size = new System.Drawing.Size(167, 20);
            this.txt_Register_Username.TabIndex = 5;
            // 
            // lbl_Register_RePassword
            // 
            this.lbl_Register_RePassword.Location = new System.Drawing.Point(6, 114);
            this.lbl_Register_RePassword.Name = "lbl_Register_RePassword";
            this.lbl_Register_RePassword.Size = new System.Drawing.Size(167, 23);
            this.lbl_Register_RePassword.TabIndex = 10;
            this.lbl_Register_RePassword.Text = "Repeat Password";
            this.lbl_Register_RePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Register_RePassword
            // 
            this.txt_Register_RePassword.Location = new System.Drawing.Point(6, 140);
            this.txt_Register_RePassword.Name = "txt_Register_RePassword";
            this.txt_Register_RePassword.PasswordChar = '*';
            this.txt_Register_RePassword.Size = new System.Drawing.Size(167, 20);
            this.txt_Register_RePassword.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Autentification Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.TextBox txt_Login_Password;
        private System.Windows.Forms.Label lbl_Login_Username;
        private System.Windows.Forms.TextBox txt_Login_Username;
        private System.Windows.Forms.Label lbl_Register_RePassword;
        private System.Windows.Forms.TextBox txt_Register_RePassword;
        private System.Windows.Forms.Label lbl_Register_Password;
        private System.Windows.Forms.TextBox txt_Register_Password;
        private System.Windows.Forms.Label lbl_Register_Username;
        private System.Windows.Forms.TextBox txt_Register_Username;
    }
}

