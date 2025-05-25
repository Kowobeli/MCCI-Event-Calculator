using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCI_Event_Calculator.Games
{
    public partial class rsrWindow : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        string tableMembers = "Members";
        string tableTeams = "Teams";
        public rsrWindow()
        {
            InitializeComponent();
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

        public void ShowData()
        {
            string showMembers = $"SELECT * FROM {tableMembers}";
            string showTeams = $"SELECT * FROM {tableTeams}";
            DataTable dtMembers = db.ExecuteConsults(showMembers);
            DataTable dtTeams = db.ExecuteConsults(showTeams);
            dtgRsr.DataSource = dtMembers.AsDataView();
            dtgTeams.DataSource = dtTeams.AsDataView();
        }

        public void ClearFields()
        {
            txtPointsPerRound.Clear();
            txtMultiplier.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
                string updateMembersRsr = $"UPDATE {tableMembers} SET RsrPoints = RsrPoints + {totalPointsRounded} WHERE id = {id}";
                string updateMembersAllPoints = $"UPDATE {tableMembers} SET Points = Points + {totalPointsRounded} WHERE id = {id}";
                string updateTeamsRsr = $@"UPDATE {tableTeams} SET RsrPoints = COALESCE(RsrPoints, 0) + {totalPointsRounded} WHERE Name = (SELECT TeamName FROM Members WHERE Id = {id} LIMIT 1)";
                string updateTeamsAllPoints = $"UPDATE {tableTeams} SET TotalPoints = COALESCE(TotalPoints, 0) + {totalPointsRounded} WHERE Name = (SELECT TeamName FROM Members WHERE Id = {id} LIMIT 1)";
                int resultado = db.ExecuteCommands(updateMembersRsr);
                int resultado2 = db.ExecuteCommands(updateMembersAllPoints);
                int resultado3 = db.ExecuteCommands(updateTeamsRsr);
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

        private void rsrWindow_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dtgPkws_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dtgRsr.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void label2_Click(object sender, EventArgs e)
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

        private void rsrWindow_Click(object sender, EventArgs e)
        {
            txtPointsPerRound.ScrollBars = ScrollBars.None;
            txtPointsPerRound.Height = 20;
        }
    }
}
