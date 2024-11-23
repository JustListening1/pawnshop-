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
    public partial class SellandLoanform : Form
    {
        private List<string> database = new List<string>();

        public SellandLoanform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddresstextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContacttextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendertextBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void cb_item_loan_sell_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loanamounttextBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            decimal loanlimit;
            if (cb_sellorloan.Text == null)
            {
                MessageBox.Show("Please select either 'sell' or 'loan'.");
                return;
            }

            decimal loanAmount;
            if (!decimal.TryParse(loanamounttextBox6.Text, out loanAmount))
            {
                MessageBox.Show("Please enter a valid amount.");
                loanamounttextBox6.Text = string.Empty;
                return;
            }

            if (cb_sellorloan.Text.ToString() == "sell")
            {
                loanlimit = 20000;
                if (loanAmount < 100 || loanAmount > loanlimit)
                {
                    MessageBox.Show($"Sell amount must be between $100 and ${loanlimit}.");
                    loanamounttextBox6.Text = string.Empty;
                    return;
                }
            }
            else if (cb_sellorloan.Text.ToString() == "loan")
            {
                loanlimit = 15000;
                if (loanAmount < 100 || loanAmount > loanlimit)
                {
                    MessageBox.Show($"Loan amount must be between $100 and ${loanlimit}.");
                    loanamounttextBox6.Text = string.Empty;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select either 'sell' or 'loan'.");
                return;
            }

            MessageBox.Show("Thank you for trusting us. Please go to our designated store to give the item and get the money.", "Information", MessageBoxButtons.OK);
        }

        private void SellandLoanform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entry = $"{NametextBox1.Text}, {AddresstextBox2.Text}, {ContacttextBox3.Text}, {gendertextBox4.Text}, {cb_sellorloan.Text}, {cb_item_loan_sell.SelectedItem}, {loanamounttextBox6.Text}";
            database.Add(entry);

            Form2 form2 = new Form2();
            form2.sellinglabel = entry;
            form2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice_page form2 = new choice_page();
            form2.Show();
            this.Hide();
        }

        private void cb_sellorloan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
