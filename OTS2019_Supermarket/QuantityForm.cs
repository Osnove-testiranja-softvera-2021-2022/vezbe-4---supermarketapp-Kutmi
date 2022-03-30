using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS_Supermarket
{
    public partial class QuantityForm : Form
    {
        public QuantityForm()
        {
            InitializeComponent();
            tbxInput.Visible = false;
        }

        private void rbtnAddOne_CheckedChanged(object sender, EventArgs e)
        {
            tbxInput.Visible = false;
        }

        private void rbtnAddMultiptle_CheckedChanged(object sender, EventArgs e)
        {
            tbxInput.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void QuantityForm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
