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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            string[] cols = System.IO.File.ReadAllText("settings.txt").Split(',');
            TxtTemp.Text = cols[0];
            TxtPulse.Text = cols[1];
            TxtGeo.Text = cols[2];
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Program.temp = TxtTemp.Text;
            Program.pulse = TxtPulse.Text;
            Program.distance = float.Parse(TxtGeo.Text);
            System.IO.File.WriteAllText("settings.txt", TxtTemp.Text + "," + TxtPulse.Text + ","+ TxtGeo.Text);
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
