using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCI_Event_Calculator.Team_and_Members
{
    public partial class teamsWindow : Form
    {
        public teamsWindow()
        {
            InitializeComponent();
        }

        private void teamsWindow_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dtgTeams.DataSource = db.GetAllMembers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchToMainScreen();
        }

        private void SwitchToMainScreen()
        {
            var otherForm = new inputScreen();
            otherForm.Show();
            this.Hide();
        }

        private void dtgTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
