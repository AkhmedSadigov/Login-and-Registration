using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Returning to the Login page... ", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Website is closing...", "Report!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
