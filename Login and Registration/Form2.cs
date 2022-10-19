using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.Black;
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password";
                txtConfirmPassword.ForeColor = Color.Silver;
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsername.Text == "Enter Username" || txtPassword.Text == "Enter Password" || txtConfirmPassword.Text == "Confirm Password")
                {
                    MessageBox.Show("Please enter all the information", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords not same!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Account.RegisterAccount(txtUsername.Text, txtPassword.Text))
                {

                    MessageBox.Show("The process is ongoing!", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Sorry for the trouble!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Focus();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                    txtConfirmPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    txtConfirmPassword.PasswordChar = '*';
                }
            }
            catch
            {
                MessageBox.Show("Sorry for the trouble!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Login page is downloading...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Returning to the Login page...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Website is closing...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
