using MCCI_Event_Calculator.Team_and_Members;
using MCCI_Event_Calculator.Teams_and_Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCI_Event_Calculator
{
    public partial class inputScreen : Form
    {
        public inputScreen()
        {
            InitializeComponent();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            SwitchToAnotherForm();
        }

        private void SwitchToAnotherForm()
        {
            var otherForm = new mainScreen();
            otherForm.Show();
            this.Hide();
        }

        private void txtTeams_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormTeams();
        }

        private void SwitchToAnotherFormTeams()
        {
            var otherForm = new teamsWindow();
            otherForm.Show();
            this.Hide();
        }

        private void SwitchToAnotherFormMembers()
        {
            var otherForm = new membersWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormMembers();
        }
    }
}
