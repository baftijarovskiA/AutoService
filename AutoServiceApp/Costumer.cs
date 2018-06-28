using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class Costumer : UserControl
    {
        public Costumer()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewClient newClientForm = new AddNewClient();
            if (newClientForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
