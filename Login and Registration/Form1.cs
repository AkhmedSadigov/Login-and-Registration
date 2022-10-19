using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_and_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUsername.Text == "Enter Username" && txtPassword.Text == "Enter Password")
                {
                    MessageBox.Show("Please enter Username and Password", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Account.Login(txtUsername.Text, txtPassword.Text))
                {

                    MessageBox.Show("Login is successful!", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Information is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Sorry for the trouble!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void linkLblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Register page is downloading...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter Username";
                txtUsername.ForeColor = Color.Silver;
            }


        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            }
            catch
            {
                MessageBox.Show("Sorry for the trouble!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Website is closing...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account.RegisterAccount("admin", "12345");
        }
    }
}
