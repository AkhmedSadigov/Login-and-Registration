using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Login_and_Registration
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            createRandom();
        }

        private void createRandom()
        {
            txtEnter.Clear();
            Random random = new Random();
            char a = Convert.ToChar(random.Next(97, 123));
            int x = Convert.ToChar(random.Next(0, 10));
            char b = Convert.ToChar(random.Next(65, 91));
            char c = Convert.ToChar(random.Next(97, 123));
            char d = Convert.ToChar(random.Next(65, 91));
            int y = Convert.ToChar(random.Next(0, 10));

            txtRandom.Text = a.ToString() + x.ToString() + b.ToString() + c.ToString() + d.ToString() + y.ToString();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            createRandom();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtRandom.Text == txtEnter.Text)
                {
                    MessageBox.Show("Registration is complete!Please back to Main Page for Login!", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }

                else if (txtEnter.Text == "")
                {
                    MessageBox.Show("Enter the text above", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    createRandom();
                    MessageBox.Show("Dont Correct!Please Again!", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEnter.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Sorry for the trouble!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtEnter_Leave(object sender, EventArgs e)
        {
            if (txtEnter.Text == "")
            {
                txtEnter.Text = "Type Text";
                txtEnter.ForeColor = Color.Silver;
            }
        }


        private void txtEnter_Enter(object sender, EventArgs e)
        {
            if (txtEnter.Text == "Type Text")
            {
                txtEnter.Text = "";
                txtEnter.ForeColor = Color.Black;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Returning to the Register page... ", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            createRandom();
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
