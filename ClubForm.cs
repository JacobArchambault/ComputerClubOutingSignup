using System;
using System.Windows.Forms;

namespace ComputerClubOutingSignup
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = " ";
            foreach (string activity in lstBxEvents.SelectedItems)
            {
                result += activity + " ";
            }
            txtBxResult.Text = result;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstBxEvents.Items.Add(txtBxAddNew.Text);
            txtBxAddNew.Clear();
        }
    }
}
