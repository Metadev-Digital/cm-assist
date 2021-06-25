using System;
using System.Windows.Forms;

/*CM Assist -Tech-
 * Created: 6/25/2021
 * Updated: 6/25/2021
 * Designed by: Kevin Sherman at Metadev Digital
 * Contact at: Kevin@metadevdigital.com
 * 
 * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
 */

namespace CM_Assist
{
    public partial class frmTech : Form
    {
        public frmTech()
        {
            InitializeComponent();
        }

        public String technician { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            technician = txtInput.Text;
            this.Close();
        }

        private void frmTech_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void frmTech_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(null, null);
            }
        }
    }
}
