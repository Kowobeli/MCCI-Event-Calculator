using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCI_Event_Calculator.Teams_and_Members
{
    public partial class membersWindow : Form
    {
        public membersWindow()
        {
            InitializeComponent();
        }

        private void membersWindow_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dtgMembers.DataSource = db.GetAllMembers();
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

        private void dtgMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
