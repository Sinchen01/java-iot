namespace GeoAutoRunner
{
    public partial class AddSoldierorm : Form
    {
        Db obj = null;
        public AddSoldierorm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (obj.isExists(TxtSoldiersName.Text))
            {
                DialogResult res = MessageBox.Show("Soldier record already exists \n Want to delete existing record ?", "Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    obj.delrec(TxtSoldiersName.Text);
                    MessageBox.Show("Record deleted successfully, now u can click save  !!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                    return;
            }
            if (obj.saveRecord(TxtSoldiersName.Text, TxtGeo.Text, TxtOrigin.Text))
                MessageBox.Show("Record saved successfully !!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error while saving !!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            obj = new Db();

        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            if (TxtSoldiersName.Text.Length == 0)
            {
                MessageBox.Show("Please fill name and click search icon", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable buffer = obj.getPatient(TxtSoldiersName.Text);
            if (buffer.Rows.Count != 0)
            {
                TxtGeo.Text = buffer.Rows[0]["geodistance"].ToString();
                TxtOrigin.Text = buffer.Rows[0]["origin"].ToString();
            }
        }
    }
}
