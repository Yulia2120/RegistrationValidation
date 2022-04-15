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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butForgot = new System.Windows.Forms.Button();
            this.butSignUp = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labUsername = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butSignIn = new System.Windows.Forms.Button();
            this.txtBoxInPass = new System.Windows.Forms.TextBox();
            this.labInPassword = new System.Windows.Forms.Label();
            this.txtBoxInEmail = new System.Windows.Forms.TextBox();
            this.labInEmail = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLBindingSource)).BeginInit();
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
            this.tabControl.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.txtBoxPass);
            this.tabPage1.Controls.Add(this.txtBoxEmail);
            this.tabPage1.Controls.Add(this.labEmail);
            this.tabPage1.Controls.Add(this.txtBoxName);
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
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPass.Location = new System.Drawing.Point(57, 208);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(336, 23);
            this.txtBoxPass.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxEmail.Location = new System.Drawing.Point(54, 133);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(336, 23);
            this.txtBoxEmail.TabIndex = 3;
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
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxName.Location = new System.Drawing.Point(54, 58);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(336, 23);
            this.txtBoxName.TabIndex = 1;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.butSignIn);
            this.tabPage2.Controls.Add(this.txtBoxInPass);
            this.tabPage2.Controls.Add(this.labInPassword);
            this.tabPage2.Controls.Add(this.txtBoxInEmail);
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
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // txtBoxInPass
            // 
            this.txtBoxInPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxInPass.Location = new System.Drawing.Point(56, 267);
            this.txtBoxInPass.Name = "txtBoxInPass";
            this.txtBoxInPass.PasswordChar = '*';
            this.txtBoxInPass.Size = new System.Drawing.Size(336, 23);
            this.txtBoxInPass.TabIndex = 4;
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
            // txtBoxInEmail
            // 
            this.txtBoxInEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxInEmail.Location = new System.Drawing.Point(56, 194);
            this.txtBoxInEmail.Name = "txtBoxInEmail";
            this.txtBoxInEmail.Size = new System.Drawing.Size(336, 23);
            this.txtBoxInEmail.TabIndex = 2;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(447, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.usersLBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(447, 264);
            this.dataGridView.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.usersLBindingSource;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersLBindingSource
            // 
            this.usersLBindingSource.DataSource = typeof(RegistrationValidation.Model.UsersL);
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button butSignIn;
        private System.Windows.Forms.TextBox txtBoxInPass;
        private System.Windows.Forms.Label labInPassword;
        private System.Windows.Forms.TextBox txtBoxInEmail;
        private System.Windows.Forms.Label labInEmail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersLBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

