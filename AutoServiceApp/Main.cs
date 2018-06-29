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
            selectedMenu.Text = "Почетна";
            dashboard.Visible = true;
            costumer.Visible = false;
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
            selectedMenu.Text = "Магацин";
            dashboard.Visible = false;
            costumer.Visible = false;
            stock.Visible = true;
            service.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedMenu.Text = "Сервис";
            dashboard.Visible = false;
            costumer.Visible = false;
            stock.Visible = false;
            service.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedMenu.Text = "Почетна";
            dashboard.Visible = true;
            costumer.Visible = false;
            stock.Visible = false;
            service.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            selectedMenu.Text = "Клиенти";
            dashboard.Visible = false;
            costumer.Visible = true;
            stock.Visible = false;
            service.Visible = false;
        }
    }
}
