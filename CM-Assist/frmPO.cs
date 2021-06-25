using System;
using System.Windows.Forms;

/*CM Assist -PO- 
 * Created: 6/25/2021
 * Updated: 6/25/2021
 * Designed by: Kevin Sherman at Metadev Digital
 * Contact at: Kevin@metadevdigital.com
 * 
 * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
 */

namespace Smarti_Assist
{
    public partial class frmPO : Form
    {
        public frmPO()
        {
            InitializeComponent();
        }

        public String po { get; set; }  

        private void frmPO_Load(object sender, EventArgs e)
        {
            txtInput.Focus().Equals(true);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            po = txtInput.Text;
            this.Close();
        }

        private void frmPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(null, null);
            }
        }
    }
}
