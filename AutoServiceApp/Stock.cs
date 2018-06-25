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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewProduct newProductForm = new AddNewProduct();
            if(newProductForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
