using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeoAutoRunner
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

       

        void authenticate()
        {
            if (TxtUsername.Text == "admin" && TxtPassword.Text == "admin")
            {
                this.Hide();
                MainScreen scr = new MainScreen();
                scr.Show();
            }
            else
                MessageBox.Show("Invalid username/password", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( (int)e.KeyChar==13)
            authenticate();
        }

        private void PicBtn_Click_1(object sender, EventArgs e)
        {
            authenticate();
        }
    }
}
