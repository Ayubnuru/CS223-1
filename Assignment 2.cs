using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_sku_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved successfully.");
        }
    }
}
