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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void addPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSoldierorm frm = new AddSoldierorm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addNotificationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();

            Application.ExitThread();
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.Show();
        }
    }
}
