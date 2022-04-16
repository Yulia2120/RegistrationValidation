using Dapper;
using RegistrationValidation.Controller;
using RegistrationValidation.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;

namespace RegistrationValidation
{
    public partial class FormBegin : Form
    {
        public FormBegin()
        {
            InitializeComponent();
            usersLBindingSource.DataSource = GetUsersClassData.GetUsersL();
         
        }


        private void butSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtBoxName.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtBoxEmail.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtBoxPass.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RegistrationController new_user = new RegistrationController();
            new_user.Registration(txtBoxName.Text, txtBoxEmail.Text, txtBoxPass.Text);
         
            usersLBindingSource.ResetBindings(false);
            usersLBindingSource.DataSource = GetUsersClassData.GetUsersL();

            
        }
        private void butSignIn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtBoxInEmail.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtBoxInPass.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                try
            {
                using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    UsersL obj = db.Query<UsersL>($"Select * from UsersL where Email = '{txtBoxInEmail.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj != null)
                    {
                            MessageBox.Show("Login successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Name = txtBoxName.Text;
                Properties.Settings.Default.Email = txtBoxEmail.Text;
                Properties.Settings.Default.Password = txtBoxPass.Text;
            }
            else
            {
                Properties.Settings.Default.Name = null;
                Properties.Settings.Default.Email = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.Remembe = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void txtBoxInEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxInEmail.Text))
            {
                e.Cancel = true;
                txtBoxInEmail.Focus();
                errorProvider.SetError(txtBoxInEmail, "Pleas enter your email!");
            }
            else
            {
                e.Cancel= false;
                errorProvider.SetError(txtBoxInEmail, null);
            }
        }

        private void txtBoxInPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxInPass.Text))
            {
                e.Cancel = true;
                txtBoxInPass.Focus();
                errorProvider.SetError(txtBoxInPass, "Pleas enter your password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxInPass, null);
            }
        }

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                e.Cancel = true;
                txtBoxName.Focus();
                errorProvider.SetError(txtBoxName, "Pleas enter your name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxName, null);
            }
        }

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                e.Cancel = true;
                txtBoxEmail.Focus();
                errorProvider.SetError(txtBoxEmail, "Pleas enter your email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxEmail, null);
            }
        }

        private void txtBoxPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPass.Text))
            {
                e.Cancel = true;
                txtBoxPass.Focus();
                errorProvider.SetError(txtBoxPass, "Pleas enter your password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxPass, null);
            }
        }
    }
}
