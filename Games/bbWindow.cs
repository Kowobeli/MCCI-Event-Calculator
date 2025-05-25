using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MCCI_Event_Calculator.Games
{
    public partial class bbWindow : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        string tableMembers = "Members";
        string tableTeams = "Teams";
        public bbWindow()
        {
            InitializeComponent();
        }
        public void ShowData()
        {
            string showMembers = $"SELECT * FROM {tableMembers}";
            string showTeams = $"SELECT * FROM {tableTeams}";
            DataTable dtMembers = db.ExecuteConsults(showMembers);
            DataTable dtTeams = db.ExecuteConsults(showTeams);
            dtgBb.DataSource = dtMembers.AsDataView();
            dtgTeams.DataSource = dtTeams.AsDataView();
        }

        public void ClearFields()
        {
            txtPointsPerRound.Clear();
            txtMultiplier.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchToMainScreen();
        }

        private void SwitchToMainScreen()
        {
            var otherForm = new mainScreen();
            otherForm.Show();
            this.Hide();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lblId.Text;

            string delete = $"DELETE FROM {tableMembers} WHERE Id = {id}";
            if (id != "")
            {
                int resultado = db.ExecuteCommands(delete);
                if (resultado == 1)
                {
                    MessageBox.Show("Data deleted sucessfully!");
                    ClearFields();
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
            else
            {
                MessageBox.Show("Teams name not identified!");
            }
        }

        private void dtgBb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgBb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dtgBb.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void bbWindow_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string multiply = txtMultiplier.Text;

            int totalPointsRounds = 0;
            var lines = txtPointsPerRound.Lines;

            foreach (var line in lines)
            {
                if (int.TryParse(line.Trim(), out int value))
                {
                    totalPointsRounds += value;
                }
            }

            int totalPointsRounded = 0;
            string id = lblId.Text;

            if (float.TryParse(multiply, out float multiplyValue))
            {
                float totalPoints = totalPointsRounds * multiplyValue;
                totalPointsRounded = (int)Math.Round(totalPoints, 0);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Points, Rounds, and Multiplier.");
                return;
            }

            if (id != "")
            {
                string updateMembersBb = $"UPDATE {tableMembers} SET BbPoints = BbPoints + {totalPointsRounded} WHERE id = {id}";
                string updateMembersAllPoints = $"UPDATE {tableMembers} SET Points = Points + {totalPointsRounded} WHERE id = {id}";
                string updateTeamsBb = $@"UPDATE {tableTeams} SET BbPoints = COALESCE(BbPoints, 0) + {totalPointsRounded} WHERE Name = (SELECT TeamName FROM Members WHERE Id = {id} LIMIT 1)";
                string updateTeamsAllPoints = $"UPDATE {tableTeams} SET TotalPoints = COALESCE(TotalPoints, 0) + {totalPointsRounded} WHERE Name = (SELECT TeamName FROM Members WHERE Id = {id} LIMIT 1)";
                int resultado = db.ExecuteCommands(updateMembersBb);
                int resultado2 = db.ExecuteCommands(updateMembersAllPoints);
                int resultado3 = db.ExecuteCommands(updateTeamsBb);
                int resultado4 = db.ExecuteCommands(updateTeamsAllPoints);

                if (resultado == 1 & resultado2 == 1 & resultado3 == 1 & resultado4 == 1)
                {
                    MessageBox.Show("Data updated sucessfully!");
                    ClearFields();
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtPointsPerRound_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPointsPerRound_Click(object sender, EventArgs e)
        {
            txtPointsPerRound.ScrollBars = ScrollBars.Vertical;
            txtPointsPerRound.Height = 50;
        }

        private void txtPointsPerRound_Leave(object sender, EventArgs e)
        {
            txtPointsPerRound.ScrollBars = ScrollBars.None;
            txtPointsPerRound.Height = 20;
        }

        private void bbWindow_Click(object sender, EventArgs e)
        {
            txtPointsPerRound.ScrollBars = ScrollBars.None;
            txtPointsPerRound.Height = 20;
        }
    }
}