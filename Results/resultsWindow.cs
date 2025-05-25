using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCI_Event_Calculator
{
    public partial class resultsWindow : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        string tableMembers = "Members";
        string tableTeams = "Teams";
        public resultsWindow()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            string showMembers = $"SELECT * FROM {tableMembers}";
            string showTeams = $"SELECT * FROM {tableTeams}";
            DataTable dtMembers = db.ExecuteConsults(showMembers);
            DataTable dtTeams = db.ExecuteConsults(showTeams);
            dtgMembers.DataSource = dtMembers.AsDataView();
            dtgTeams.DataSource = dtTeams.AsDataView();

            if (dtgMembers.Columns.Contains("Id"))
            dtgMembers.Columns["Id"].Visible = true;
            dtgMembers.Columns["BbPoints"].Visible = true;
            dtgMembers.Columns["HitwPoints"].Visible = true;
            dtgMembers.Columns["PkwsPoints"].Visible = true;
            dtgMembers.Columns["RsrPoints"].Visible = true;
            dtgMembers.Columns["SbPoints"].Visible = true;
            dtgMembers.Columns["TgttosPoints"].Visible = true;

            dtgTeams.Columns["Id"].Visible = true;
            dtgTeams.Columns["BbPoints"].Visible = true;
            dtgTeams.Columns["HitwPoints"].Visible = true;
            dtgTeams.Columns["PkwsPoints"].Visible = true;
            dtgTeams.Columns["RsrPoints"].Visible = true;
            dtgTeams.Columns["SbPoints"].Visible = true;
            dtgTeams.Columns["TgttosPoints"].Visible = true;
        }

        private void resultsWindow_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnBb_Click(object sender, EventArgs e)
        {

            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";

            

            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = true;
                dtgMembers.Columns["HitwPoints"].Visible = false;
                dtgMembers.Columns["PkwsPoints"].Visible = false;
                dtgMembers.Columns["RsrPoints"].Visible = false;
                dtgMembers.Columns["SbPoints"].Visible = false;
                dtgMembers.Columns["TgttosPoints"].Visible = false;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = true;
                dtgTeams.Columns["HitwPoints"].Visible = false;
                dtgTeams.Columns["PkwsPoints"].Visible = false;
                dtgTeams.Columns["RsrPoints"].Visible = false;
                dtgTeams.Columns["SbPoints"].Visible = false;
                dtgTeams.Columns["TgttosPoints"].Visible = false;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnAsc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHitw_Click(object sender, EventArgs e)
        {
            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";



            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = false;
                dtgMembers.Columns["HitwPoints"].Visible = true;
                dtgMembers.Columns["PkwsPoints"].Visible = false;
                dtgMembers.Columns["RsrPoints"].Visible = false;
                dtgMembers.Columns["SbPoints"].Visible = false;
                dtgMembers.Columns["TgttosPoints"].Visible = false;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = false;
                dtgTeams.Columns["HitwPoints"].Visible = true;
                dtgTeams.Columns["PkwsPoints"].Visible = false;
                dtgTeams.Columns["RsrPoints"].Visible = false;
                dtgTeams.Columns["SbPoints"].Visible = false;
                dtgTeams.Columns["TgttosPoints"].Visible = false;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void btnPkws_Click(object sender, EventArgs e)
        {
            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";



            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = false;
                dtgMembers.Columns["HitwPoints"].Visible = false;
                dtgMembers.Columns["PkwsPoints"].Visible = true;
                dtgMembers.Columns["RsrPoints"].Visible = false;
                dtgMembers.Columns["SbPoints"].Visible = false;
                dtgMembers.Columns["TgttosPoints"].Visible = false;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = false;
                dtgTeams.Columns["HitwPoints"].Visible = false;
                dtgTeams.Columns["PkwsPoints"].Visible = true;
                dtgTeams.Columns["RsrPoints"].Visible = false;
                dtgTeams.Columns["SbPoints"].Visible = false;
                dtgTeams.Columns["TgttosPoints"].Visible = false;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void btnRsr_Click(object sender, EventArgs e)
        {
            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";



            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = false;
                dtgMembers.Columns["HitwPoints"].Visible = false;
                dtgMembers.Columns["PkwsPoints"].Visible = false;
                dtgMembers.Columns["RsrPoints"].Visible = true;
                dtgMembers.Columns["SbPoints"].Visible = false;
                dtgMembers.Columns["TgttosPoints"].Visible = false;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = false;
                dtgTeams.Columns["HitwPoints"].Visible = false;
                dtgTeams.Columns["PkwsPoints"].Visible = false;
                dtgTeams.Columns["RsrPoints"].Visible = true;
                dtgTeams.Columns["SbPoints"].Visible = false;
                dtgTeams.Columns["TgttosPoints"].Visible = false;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void btnSb_Click(object sender, EventArgs e)
        {
            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";



            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = false;
                dtgMembers.Columns["HitwPoints"].Visible = false;
                dtgMembers.Columns["PkwsPoints"].Visible = false;
                dtgMembers.Columns["RsrPoints"].Visible = false;
                dtgMembers.Columns["SbPoints"].Visible = true;
                dtgMembers.Columns["TgttosPoints"].Visible = false;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = false;
                dtgTeams.Columns["HitwPoints"].Visible = false;
                dtgTeams.Columns["PkwsPoints"].Visible = false;
                dtgTeams.Columns["RsrPoints"].Visible = false;
                dtgTeams.Columns["SbPoints"].Visible = true;
                dtgTeams.Columns["TgttosPoints"].Visible = false;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string order = rdbAsc.Checked ? "ASC" : "DESC";


            string select = $@"Select * from {tableMembers} order by Bbpoints {order}";



            if (dtgMembers.Columns.Contains("Id"))
            {
                dtgMembers.Columns["Id"].Visible = false;
                dtgMembers.Columns["BbPoints"].Visible = false;
                dtgMembers.Columns["HitwPoints"].Visible = false;
                dtgMembers.Columns["PkwsPoints"].Visible = false;
                dtgMembers.Columns["RsrPoints"].Visible = false;
                dtgMembers.Columns["SbPoints"].Visible = false;
                dtgMembers.Columns["TgttosPoints"].Visible = true;

                dtgTeams.Columns["Id"].Visible = false;
                dtgTeams.Columns["BbPoints"].Visible = false;
                dtgTeams.Columns["HitwPoints"].Visible = false;
                dtgTeams.Columns["PkwsPoints"].Visible = false;
                dtgTeams.Columns["RsrPoints"].Visible = false;
                dtgTeams.Columns["SbPoints"].Visible = false;
                dtgTeams.Columns["TgttosPoints"].Visible = true;
            }

            dtgMembers.DataSource = db.ExecuteConsults(select).AsDataView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var otherForm = new mainScreen();
            otherForm.Show();
            this.Hide();
        }
    }
}
