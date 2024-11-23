using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pawnshop
{
    public partial class choice_page : Form
    {
        public choice_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellandLoanform SellandLoanform = new SellandLoanform();
            SellandLoanform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Front form1 = new Front();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Buyingform form3 = new Buyingform();
            form3.Show();
            this.Hide();
        }
    }
}
