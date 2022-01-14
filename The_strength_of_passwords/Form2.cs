using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_strength_of_passwords
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {         
            this.Close();
        }

        public void blank()
        {
            string ServiceSite;
            string Login;
            string Password;

            if (tbService.Text == "") { ServiceSite = ""; }
            else { ServiceSite = "Service/Site: " + tbService.Text + "\n"; }
            if (tbLogin.Text == "") { Login = ""; }
            else { Login = "Login: " + tbLogin.Text + "\n"; }
            if (tbNewPassword.Text == "") { Password = ""; }
            else { Password = "Password: " + tbNewPassword.Text; }
            rtbForSwapData.Text = ServiceSite + Login + Password + "\n\n──────────── • ✤ • ────────────\n\n";
        }

        public void SwapForForm1()
        {
            Form1 f1 = new Form1();
            f1.getdata = rtbForSwapData.Text;
            //f1.rtbMainData.Text = f1.rtbMainData.Text + f1.getdata;
            this.Hide();
            f1.Visible = true;
            MessageBox.Show("Your data has been saved!", "Successful operation!");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            blank();
            SwapForForm1();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            if (MessageBox.Show("The data will not be saved if you exit now.\nAre you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                f1.Visible = false;
            }
            else
            { 
                e.Cancel = false;
                f1.Visible = true;
            }
        }
    }
}

