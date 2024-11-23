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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string TotalPrice
        {
            set
            {
                labeltotal_price.Text = value;
            }
        }

        private void total_price_Click(object sender, EventArgs e)
        {

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            string number = ContacttextBox3.Text;
            string input = gendertextBox4.Text.Trim().ToLower();

            if (number.Length != 11 || !number.All(char.IsDigit))
            {
                MessageBox.Show("Please enter exactly 11 numeric digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContacttextBox3.Clear();
                return; 
            }

            if (input != "male" && input != "female")
            {
                MessageBox.Show("Please enter 'male' or 'female'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gendertextBox4.Clear();
                return; 
            }

            MessageBox.Show("tnx for buyying with us pls go to our designated store to get the item.", "Information", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gendertextBox4_TextChanged(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string buyinginfo = $"Name: {NametextBox1.Text}, Address:{AddresstextBox2.Text}, Contact info: {ContacttextBox3.Text}, Gender: {gendertextBox4.Text}, Amount to pay: {labeltotal_price.Text}";
            Form2 form2 = new Form2();
            form2.BuyingLabel = buyinginfo;
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buyingform form3 = new Buyingform();
            form3.Show();
            this.Hide();
        }
    }
}