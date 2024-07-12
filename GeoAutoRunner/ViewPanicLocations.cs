using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace GeoAutoRunner
{
    public partial class ViewPanicLocations : Form
    {
        ArrayList list;
        public ViewPanicLocations(ArrayList list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void ViewPanicLocations_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lstLocations.Items.Add(list[i].ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstLocations_DoubleClick(object sender, EventArgs e)
        {
            if (lstLocations.SelectedIndices.Count > 0)
            {
                string val = lstLocations.GetItemText(lstLocations.SelectedItem);
                string q = string.Format("http://maps.google.com/maps?q=loc:{0}&z=17", val);
                Process.Start(q);
            }
        } 
    }
}
