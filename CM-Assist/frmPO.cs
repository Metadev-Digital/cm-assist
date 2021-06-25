﻿using System;
using System.Windows.Forms;

/*Smart-i Assist -PO- Version 1.0.0.5
 * Created: 6/23/2020
 * Updated: 7/9/2020
 * Designed by: Kevin Sherman at Acrelec America
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
