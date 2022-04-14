namespace RegistrationValidation
{
    partial class FormBegin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labUsername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.butSignUp = new System.Windows.Forms.Button();
            this.butForgot = new System.Windows.Forms.Button();
            this.labInEmail = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labInPassword = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.butSignIn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(455, 44);
            this.panel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(455, 430);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.butForgot);
            this.tabPage1.Controls.Add(this.butSignUp);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.labPassword);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.labEmail);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.labUsername);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sign up";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.butSignIn);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.labInPassword);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.labInEmail);
            this.tabPage2.Controls.Add(this.pictureBox);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign in";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labUsername.Location = new System.Drawing.Point(53, 33);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(77, 18);
            this.labUsername.TabIndex = 0;
            this.labUsername.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(54, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 26);
            this.textBox1.TabIndex = 1;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labEmail.ForeColor = System.Drawing.Color.DimGray;
            this.labEmail.Location = new System.Drawing.Point(53, 109);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(45, 18);
            this.labEmail.TabIndex = 2;
            this.labEmail.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(54, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(57, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(336, 26);
            this.textBox3.TabIndex = 4;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPassword.ForeColor = System.Drawing.Color.DimGray;
            this.labPassword.Location = new System.Drawing.Point(57, 185);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(75, 18);
            this.labPassword.TabIndex = 5;
            this.labPassword.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(57, 264);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // butSignUp
            // 
            this.butSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.butSignUp.FlatAppearance.BorderSize = 0;
            this.butSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSignUp.ForeColor = System.Drawing.Color.White;
            this.butSignUp.Location = new System.Drawing.Point(57, 308);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(336, 38);
            this.butSignUp.TabIndex = 7;
            this.butSignUp.Text = "Sign up";
            this.butSignUp.UseVisualStyleBackColor = false;
            // 
            // butForgot
            // 
            this.butForgot.BackColor = System.Drawing.Color.White;
            this.butForgot.FlatAppearance.BorderSize = 0;
            this.butForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.butForgot.Location = new System.Drawing.Point(195, 258);
            this.butForgot.Name = "butForgot";
            this.butForgot.Size = new System.Drawing.Size(198, 31);
            this.butForgot.TabIndex = 8;
            this.butForgot.Text = "Forgot password? ";
            this.butForgot.UseVisualStyleBackColor = false;
            // 
            // labInEmail
            // 
            this.labInEmail.AutoSize = true;
            this.labInEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInEmail.ForeColor = System.Drawing.Color.DimGray;
            this.labInEmail.Location = new System.Drawing.Point(56, 170);
            this.labInEmail.Name = "labInEmail";
            this.labInEmail.Size = new System.Drawing.Size(45, 18);
            this.labInEmail.TabIndex = 1;
            this.labInEmail.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(56, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 26);
            this.textBox4.TabIndex = 2;
            // 
            // labInPassword
            // 
            this.labInPassword.AutoSize = true;
            this.labInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInPassword.ForeColor = System.Drawing.Color.DimGray;
            this.labInPassword.Location = new System.Drawing.Point(56, 243);
            this.labInPassword.Name = "labInPassword";
            this.labInPassword.Size = new System.Drawing.Size(75, 18);
            this.labInPassword.TabIndex = 3;
            this.labInPassword.Text = "Password";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(56, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(336, 26);
            this.textBox5.TabIndex = 4;
            // 
            // butSignIn
            // 
            this.butSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.butSignIn.FlatAppearance.BorderSize = 0;
            this.butSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSignIn.ForeColor = System.Drawing.Color.White;
            this.butSignIn.Location = new System.Drawing.Point(56, 328);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(336, 38);
            this.butSignIn.TabIndex = 5;
            this.butSignIn.Text = "Sign In";
            this.butSignIn.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::RegistrationValidation.Properties.Resources.user__1_;
            this.pictureBox.Location = new System.Drawing.Point(153, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(121, 112);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FormBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(455, 472);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button butForgot;
        private System.Windows.Forms.Button butSignUp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button butSignIn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labInPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labInEmail;
    }
}

