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
    public partial class EzharForm : Form
    {
        
        private List<GoodItem> goods = new List<GoodItem>();

        public EzharForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EzharForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        public void addToGoodList(GoodItem good)
        {
            System.Windows.Forms.ListViewItem temp = new System.Windows.Forms.ListViewItem(good.getGood().getName() + " " + good.getQuntity());
            this.goodsList.Items.Add(temp);
            this.goods.Add(good);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGoodForm goodForm = new AddGoodForm();
            goodForm.Show();
        }

        private void submitEzharForm_Click(object sender, EventArgs e)
        {
            Ezhar ezhar = new Ezhar(this.fName.Text, this.lName.Text, this.ssn.Text, this.dateTimePicker1.Value, Convert.ToDouble(this.totalVal.Text), this.sCountry.Text, this.transport.Text, this.goods);
            DB.getDB().addNewEzhar(ezhar);
            this.Close();
        }
    }
}
