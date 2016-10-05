using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace CipherTester
{
    public partial class frmMain : Form
    {
        private Cipher.CipherManager CM = new Cipher.CipherManager();        
        public frmMain()
        {
            InitializeComponent();
        }



        private void btnCipher_Click(object sender, EventArgs e)
        {
            try
            {
                txtCipher.Text = CM.Cipher(txtName.Text, txtKey.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCipherCheck_Click(object sender, EventArgs e)
        {
            if (CM.Approve(txtCipher.Text,txtName.Text ,txtKey.Text ))
            {
                MessageBox.Show("legal copy", frmMain.ActiveForm.Text  , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show("illegal copy", frmMain.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {


        }

        private void btnCipherDate_Click(object sender, EventArgs e)
        {
            try
            {
                txtCipher.Text = CM.DateCipher(txtKey.Text );
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
        }

        private void btnGetLeftDays_Click(object sender, EventArgs e)
        {
            try
            {
                txtDaysLeft.Text = CM.CipherDayLeft(txtCipher.Text, txtKey.Text).ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
        }
    }
}