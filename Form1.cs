using MCCI_Event_Calculator.Team_and_Members;
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
    public partial class startScreen : Form
    {
        public startScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SwitchToAnotherForm();

        }

        private void SwitchToAnotherForm()
        {
            var otherForm = new teamsWindow();
            otherForm.Show();
            this.Hide();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void startScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
