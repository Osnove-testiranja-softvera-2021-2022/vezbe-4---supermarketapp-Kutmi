using OTS_Supermarket.Models;
using System;
using System.Windows.Forms;

namespace OTS_Supermarket
{
    public partial class Form1 : Form
    {
        public static Cart cart = new Cart();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Monitor";
            form.Show();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Keyboard";
            form.Show();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Computer";
            form.Show();
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Laptop";
            form.Show();
        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Computer chair";
            form.Show();
        }

       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
