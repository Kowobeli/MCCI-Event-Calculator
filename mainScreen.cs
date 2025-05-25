using MCCI_Event_Calculator.Games;
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
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void SwitchToAnotherFormBb()
        {
            var otherForm = new bbWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnBb_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormBb();
        }

        private void SwitchToAnotherFormHitw()
        {
            var otherForm = new hitwWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnHitw_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormHitw();
        }

        private void SwitchToAnotherFormPkws()
        {
            var otherForm = new pkwsWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnPkws_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormPkws();
        }

        private void SwitchToAnotherFormRsr()
        {
            var otherForm = new rsrWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnRsr_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormRsr();
        }
        
        private void SwitchToAnotherFormSb()
        {
            var otherForm = new sbWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnSb_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormSb();
        }


        private void SwitchToAnotherFormTgttos()
        {
            var otherForm = new tgttosWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnTgttos_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormTgttos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchToAnotherForm();
        }


        private void SwitchToAnotherForm()
        {
            var otherForm = new membersWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            SwitchToAnotherFormResults();
        }

        private void SwitchToAnotherFormResults()
        {
            var otherForm = new resultsWindow();
            otherForm.Show();
            this.Hide();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            var otherForm = new teamsWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            var otherForm = new membersWindow();
            otherForm.Show();
            this.Hide();
        }

        private void btnBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
// This is a simple C# Windows Forms application that serves as a main screen for a game event calculator.
// It provides buttons to navigate to different game windows (like bbWindow, hitwWindow, etc.) and team/member management windows (like teamsWindow, membersWindow).
// The application uses a DatabaseHelper class to interact with a database, allowing for the display and management of teams and members.
// The main screen also includes a button to view results, which opens a resultsWindow form.


// VAI BRASIL!!
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⢻⠉⠳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⢀⣾⠗⠀⢸⡆⠀⠪⢷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠾⢻⡧⠀⠀⠀⠀⠀⣾⠣⠀⠀⠈⢿⠀⠀⠀⠿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠃⡧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡤⠔⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡶⠋⠀⢸⣁⣤⣀⣀⣀⢸⡏⠀⠀⠀⠀⢸⡄⠀⠀⢽⣏⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣰⠇⠸⣷⣶⠀⠀⠀⠀⠀⢀⣀⣠⣤⣤⣤⣤⣀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⡉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣶⠉⠀⠀⠀⠸⠉⠀⠈⠉⠉⠿⠿⣶⣶⣀⡀⠸⡇⠀⠀⠈⣿⡉⠿⠷⣶⣆⣀⡀⠀⠀⠀⠀⠀⢰⣿⡿⠀⠀⢿⣸⢀⣀⣶⡶⠿⠏⠉⠁⠀⣀⡶⠏⢹⣇⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠄⠀⠀⢿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⣴⣾⠿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⠛⠛⠿⠶⠶⠾⠿⠶⠶⠶⠾⠿⣿⠛⠳⢦⣄⠄⠿⡚⣃⣤⠶⠟⠛⠉⠉⠀⠀⠀⠀⠀⣠⠞⠉⠀⠀⠀⣿⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⠁⠀⠀⠀⠀⠙⠂⠀⠀⠀⠀⢀⣠⡤⣖⣯⡿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣰⡟⠞⠀⠀⠈⠳⠖⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠁⠀⠀⠀⠀⠀⢸⡇
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣆⠀⠀⠀⠀⠀⠀⣀⣠⠴⠞⢯⣡⠿⠏⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣄⡤⠴⠶⠛⣿⠆⢀⣰⠟⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠃⠀⠀⠀⠀⠀⠀⠀⢸⠇
//⠀⠀⠀⠀⠀⠀⠀⠀⣄⣄⡀⠈⠓⣂⣠⠤⠖⠋⠉⡀⣰⡾⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠁⠀⠀⠀⠀⣰⣟⣠⠞⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡹⠖⠋⠉⠀⠀⠀⢀⣴⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠟⠙⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡿⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠳⣄⠀⠀⠀⣠⡴⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣇⠀⠀⢺⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠺⢚⣿⠿⠀⠀⠀⠀⠀⠀⠀⣸⢧⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠲⣠⠾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡄⠀⠘⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢦⡀⠀⠀⠀⠀⠀⠀⢀⡿⠀⠀
//⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⣠⠞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡄⠀⠈⣿⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠓⢬⣷⡀⠀⠀⠀⠀⠀⣼⠓⠀⠀
//⠀⠀⠀⠀⠀⠀⣿⡖⢒⡶⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡟⠿⣤⡀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⠃⠀⠀⢹⡇⠀⣿⠀⠀⠀⠀⢠⣶⠾⠛⠛⠿⢶⣥⡀⠀⠀⠀⠀⠀⠈⠉⠀⠀⠀⠀⠀⢰⣏⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⣀⡟⠺⣗⢤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⡀⠀⠀⠀⠀⠀⠙⠿⣷⣶⣶⣤⣤⣤⣤⣴⡀⠀⠀⠀⣏⣴⣆⡀⢸⣷⢘⣿⢠⠆⢠⡀⠁⠀⠀⠀⠀⠀⠐⠽⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡿⠈⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠉⠿⠏⠈⢶⡈⠹⢷⣆⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⡉⠉⠉⠿⠿⠉⠀⠀⠀⠀⢿⣆⢈⡹⠿⠁⠰⣿⡿⢀⡏⢀⡆⠀⠀⠀⠀⠀⠀⠀⢹⣷⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⠉⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠓⢦⣀⡉⠙⠓⠶⠦⣤⣄⣀⣀⠀⡀⠀⠀⠀⠀⣰⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⢠⠇⢠⡏⢀⡶⠀⠀⠀⠀⠀⠀⠀⠙⢯⣵⣦⡀⢰⣿⡇⠞⠑⣾⣿⣷⠀⠀⠀⠀⠀⠀⢸⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⢲⡏⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠓⠦⢤⣀⡀⠀⠀⢠⣾⣧⣄⠀⠀⣼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠋⠀⠙⠀⠼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡇⠻⣌⣿⠥⠀⠀⠘⠋⠁⠀⠀⠀⠀⠀⠀⣾⡏⠃⠀⠸⢤⡀⠀⠀⠀⢠⡟⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠒⠺⠥⣥⣸⣶⣿⣓⣠⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠣⠁⠙⠛⠃⠀⣰⠆⠠⡆⠀⣤⢀⡀⠀⣠⡿⠄⠀⠀⠀⠀⢻⡄⠀⢀⡟⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⣿⣟⠋⠁⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⢀⡴⡋⠃⠀⠀⠀⠀⠀⡼⠁⣠⡝⠁⣸⢃⡞⠁⣼⡿⠁⠀⠀⠀⠀⠀⠘⣿⠠⠟⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⢀⣰⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣾⣟⣠⣤⡴⡶⢿⡉⠀⠀⠀⣤⠀⠀⠀⠘⠁⠀⠋⠁⠘⠃⠾⠁⣰⡏⠀⠀⠀⠀⠀⠀⠀⠀⢿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠿⣾⣯⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣧⠀⠀⠀⣹⡌⠁⠀⠀⠀⣿⣯⡀⠀⠀⠀⠀⠀⠀⠀⡀⣀⣤⣦⣧⠀⠐⡷⢦⣤⣀⡀⢀⣸⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠃⣼⡆⠀⠀⠀⢠⢀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠘⣇⠀⣰⡏⠀⠀⠀⠀⠀⣭⡿⠁⠀⠀⠀⠀⠀⠀⠀⠛⠉⣴⡟⠁⠀⢀⡇⠀⠈⠙⢿⣻⠾⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠇⣰⠛⣷⠀⠀⣰⡟⠠⣷⣴⡆⠀⠀⠀⠀⠠⣿⠓⣻⣾⡏⠀⠀⠀⠀⢠⣟⣋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢾⡅⠀⠀⢀⣸⠃⢰⢿⡛⠉⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣴⠃⠀⢹⣇⣹⡿⠀⠀⠹⠿⠁⠀⠀⠘⠻⣴⣿⡞⢯⣼⡥⠚⠀⠀⠀⠀⠁⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣤⣀⣨⡿⣴⣈⣾⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢹⠇⠀⠀⠘⢻⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠲⢿⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣠⣤⠤⠶⠚⠋⠁⠀⠛⠛⠳⢤⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡏⠀⠀⠀⠀⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠿⠿⢶⣶⠾⠿⠏⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣟⡙⠛⠲⢦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣤⣰⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠇⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠋⠁⠀⠀⠀⠀⠀⠀⠉⠛⠲⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡏⡴⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠲⣄⠀⠀⠀⠀⠀⠠⣾⡃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣄⣠⡤⠴⠺⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠔⠀⠄⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠐⠢⠤⣀⣀⠀⠀⠀⠀⠀⠀⣻⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠈⣀⣀⡀⠐⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
// © 2025 Kowo and Keiked. All rights reserved.