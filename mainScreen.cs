using MCCI_Event_Calculator.Games;
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
    }
}
