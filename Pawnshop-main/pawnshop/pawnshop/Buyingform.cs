using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pawnshop
{
    public partial class Buyingform : Form
    {
        public Buyingform()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice_page form2 = new choice_page();
            form2.Show();
            this.Hide();
        }

        private void Buyingform_Load(object sender, EventArgs e)
        {

        }

        private void chb_iphone_CheckedChanged(object sender, EventArgs e)
        {


            if (chb_iphone.Checked)
            {
               
                listBox1.Items.Add("iphone X ₱7,500");
            }
            else
            {
                
                listBox1.Items.Remove("iphone X ₱7,500");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {

                listBox1.Items.Add("gold bar 5g 18karat ₱23,139");
            }
            else
            {

                listBox1.Items.Remove("gold bar 5g 18karat ₱23,139");
            }
        }



        private void chb_S23_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_S23.Checked)
            {

                listBox1.Items.Add("Samsung s23 ₱40,000");
            }
            else
            {

                listBox1.Items.Remove("Samsung s23 ₱40,000");
            }
        }

        private void chb_rog_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_rog.Checked)
            {

                listBox1.Items.Add("ROG ₱35,000");
            }
            else
            {

                listBox1.Items.Remove("ROG ₱35,000");
            }
        }

        private void chb_red_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_red.Checked)
            {

                listBox1.Items.Add("RedMagic ₱30,000");
            }
            else
            {

                listBox1.Items.Remove("RedMagic ₱30,000");
            }
        }

        private void chb_redmi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_redmi.Checked)
            {

                listBox1.Items.Add("Redmi ₱4,000");
            }
            else
            {

                listBox1.Items.Remove("Redmi ₱4,000");
            }
        }

        private void chb_A53_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_A53.Checked)
            {

                listBox1.Items.Add("samsung A53 ₱15,000");
            }
            else
            {

                listBox1.Items.Remove("samsung A53 ₱15,000");
            }
        }

        private void chb_shark_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_shark.Checked)
            {

                listBox1.Items.Add("Black Shark ₱30,000");
            }
            else
            {

                listBox1.Items.Remove("Black Shark ₱30,000");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {

                listBox1.Items.Add("Bracelet Rose Gold  ₱38,686");
            }
            else
            {

                listBox1.Items.Remove("Bracelet Rose Gold ₱38,686");
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {

                listBox1.Items.Add("Ring Bi-Color ₱12,426");
            }
            else
            {

                listBox1.Items.Remove("Ring Bi-Color ₱12,426");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {

                listBox1.Items.Add("Earring Tri-Color ₱14,140");
            }
            else
            {

                listBox1.Items.Remove("Earring Tri-Color ₱14,140");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {

                listBox1.Items.Add("Necklace White Gold ₱8,870");
                
            }
            else
            {

                listBox1.Items.Remove("Necklace White Gold ₱8,870");
            }
        }
        decimal total = 0;
        int itemCount = 0;

        private void bt_total_Click(object sender, EventArgs e)
        {


            foreach (var item in listBox1.Items)
            {

                string[] parts = item.ToString().Split('₱');
                if (parts.Length > 1 && decimal.TryParse(parts[1].Trim(), out decimal price))
                {
                    total += price;
                    itemCount++; 
                }
            }

            labelTotalAmount.Text = "Total Amount: ₱" + total.ToString("0.00");

        }

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void bt_done_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.TotalPrice = total.ToString("0.00");
            
            form1.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelTotalAmount.Text = "";
        }
    }
    
}
