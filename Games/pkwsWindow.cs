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
    public partial class pkwsWindow : Form
    {
        public pkwsWindow()
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

    }
}
