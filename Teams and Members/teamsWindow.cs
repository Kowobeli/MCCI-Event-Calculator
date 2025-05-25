using MCCI_Event_Calculator.Teams_and_Members;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MCCI_Event_Calculator.Team_and_Members
{
    public partial class teamsWindow : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        string table = "Teams";

        public teamsWindow()
        {
            InitializeComponent();
        }

        private void teamsWindow_Load_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchToMainScreen();
        }

        private void SwitchToMainScreen()
        {
            var otherForm = new startScreen();
            otherForm.Show();
            this.Hide();
        }

        private void dtgTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ClearFields()
        {
            txtTeam.Clear();
        }

        public void ShowData()
        {
            string show = $"SELECT * FROM {table}";
            DataTable dt = db.ExecuteConsults(show);
            dtgTeams.DataSource = dt.AsDataView();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string team = txtTeam.Text;
            string id = lblId.Text;

            if (id != "")
            {
                string update = $"UPDATE {table} SET Name = '{team}' WHERE id = {id}";
                int resultado = db.ExecuteCommands(update);
                if (resultado == 1)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string team = txtTeam.Text;

            if (team != "")
            {
                string insert = $"INSERT INTO {table} (Name) VALUES ('{team}')";
                int resultado = db.ExecuteCommands(insert);
                if (resultado == 1)
                {
                    MessageBox.Show("Data inserted sucessfully!");
                    ClearFields();
                    ShowData();
                }
                else
                {
                    MessageBox.Show("An error occurred while inserting the data!");
                }

            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
        }

        private void dtgTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dtgTeams.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTeam.Text = dtgTeams.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string team = txtTeam.Text;
            string id = lblId.Text;

            string delete = $"DELETE FROM {table} WHERE Id = {id}";
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

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            SwitchToAnotherForm();
        }

        private void SwitchToAnotherForm()
        {
            var otherForm = new membersWindow();
            otherForm.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTeam_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
