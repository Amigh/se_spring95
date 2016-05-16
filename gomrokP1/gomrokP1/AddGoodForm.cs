using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gomrokP1
{
    public partial class AddGoodForm : Form
    {
        public AddGoodForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Good good = new Good(this.kName.Text, this.pName.Text, this.weight.Text, Convert.ToDouble(this.fee.Text));
            Program.ezharForm.addToGoodList(new GoodItem(good,Convert.ToDouble(this.quntity.Text)));
            this.Close();
        }

        private void quntity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
