using Dapper;
using RegistrationValidation.Controller;
using RegistrationValidation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            RegistrationController new_user = new RegistrationController();
            new_user.Registration(txtBoxName.Text, txtBoxEmail.Text, txtBoxPass.Text);
            usersLBindingSource.ResetBindings(false);
            usersLBindingSource.DataSource = GetUsersClassData.GetUsersL();

            //usersLBindingSource.EndEdit();
            //if (new_user != null)
            //{
            //    ValidationContext context = new ValidationContext(new_user, null, null);
            //    IList<ValidationResult> errors = new List<ValidationResult>();
            //    if (!Validator.TryValidateObject(new_user, context, errors, true))
            //    {
            //        foreach (ValidationResult result in errors)
            //        {
            //            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }

            }   

        private void butSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxInEmail.Text))
            {
                MessageBox.Show(this, "Pleas enter your email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxInEmail.Focus();
                return;
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
                        if (obj.Password == txtBoxInPass.Text)
                        {
                            MessageBox.Show("Login successfully!");
                          
                        }
                        else
                        {
                            MessageBox.Show(this, "Your username and password don't match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Your username and password don't match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
