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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string BuyingLabel
        {
            set
            {
                lable_buying.Text = value;
            }
        }
        public string sellinglabel
        {
            set
            {
                label_sellloan.Text = value;
            }
        }
        internal static void SetText(string entry)
        {
            
            
        }

        private void Admindatabases_Load(object sender, EventArgs e)
        {

        }

        private void label_sellloan_Click(object sender, EventArgs e)
        {

        }

        private void lable_buying_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Front form1 = new Front();
            form1.Show();
            this.Hide();
        }
    }
}