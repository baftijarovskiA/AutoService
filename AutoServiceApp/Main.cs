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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dashboard.Visible = true;
            stock.Visible = false;
            service.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto Service App\nv1.0\nDeveloped by: Albin Baftijarovski\nThe X Enterprise", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedMenu.Text = "Stock";
            dashboard.Visible = false;
            stock.Visible = true;
            service.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedMenu.Text = "Service";
            dashboard.Visible = false;
            stock.Visible = false;
            service.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedMenu.Text = "Dashboard";
            dashboard.Visible = true;
            stock.Visible = false;
            service.Visible = false;
        }

    }
}
