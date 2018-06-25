using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            tbLogInPin.Text = "";
            tbLogInPin.Focus();
        }

        public bool check(string pw)
        {
            string password = "9982";
            if (password.Equals(pw))
            {
                return true;
            }
            return false;
        }

        public void log(string pw)
        {
            Main MainForm = new Main();
            this.Hide();
            if(MainForm.ShowDialog() == DialogResult.Cancel)
            {
                MainForm.Close();
                this.Close();
            }
            //if (check(pw))
            //{
            //    MessageBox.Show("Pin is correct", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    clear();
            //}
            //else
            //{
            //    MessageBox.Show("Pin didnt match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    clear();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            log(tbLogInPin.Text);
           
        }

        private void One_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            tbLogInPin.Text += "0";
        }

        private void tbLogInPin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                clear();

            } else if(e.KeyCode == Keys.Enter)
            {
                log(tbLogInPin.Text);
            }
        }
    }
}
