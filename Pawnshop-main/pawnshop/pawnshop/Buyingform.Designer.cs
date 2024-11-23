using System;

namespace pawnshop
{
    partial class Buyingform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyingform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chb_iphone = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chb_shark = new System.Windows.Forms.CheckBox();
            this.chb_A53 = new System.Windows.Forms.CheckBox();
            this.chb_redmi = new System.Windows.Forms.CheckBox();
            this.chb_red = new System.Windows.Forms.CheckBox();
            this.chb_rog = new System.Windows.Forms.CheckBox();
            this.chb_S23 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_done = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.bt_total = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 133);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "CURRENT STACK";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(825, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 132);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chb_iphone
            // 
            this.chb_iphone.AutoSize = true;
            this.chb_iphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_iphone.Location = new System.Drawing.Point(0, 17);
            this.chb_iphone.Margin = new System.Windows.Forms.Padding(2);
            this.chb_iphone.Name = "chb_iphone";
            this.chb_iphone.Size = new System.Drawing.Size(176, 29);
            this.chb_iphone.TabIndex = 0;
            this.chb_iphone.Text = "iphone X ₱7,500";
            this.chb_iphone.UseVisualStyleBackColor = true;
            this.chb_iphone.CheckedChanged += new System.EventHandler(this.chb_iphone_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chb_shark);
            this.panel2.Controls.Add(this.chb_A53);
            this.panel2.Controls.Add(this.chb_redmi);
            this.panel2.Controls.Add(this.chb_red);
            this.panel2.Controls.Add(this.chb_rog);
            this.panel2.Controls.Add(this.chb_S23);
            this.panel2.Controls.Add(this.chb_iphone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 531);
            this.panel2.TabIndex = 13;
            // 
            // chb_shark
            // 
            this.chb_shark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chb_shark.Location = new System.Drawing.Point(2, 280);
            this.chb_shark.Margin = new System.Windows.Forms.Padding(2);
            this.chb_shark.Name = "chb_shark";
            this.chb_shark.Size = new System.Drawing.Size(286, 39);
            this.chb_shark.TabIndex = 0;
            this.chb_shark.Text = "Xiaomi Black Shark 5 ₱30,000";
            this.chb_shark.CheckedChanged += new System.EventHandler(this.chb_shark_CheckedChanged_1);
            // 
            // chb_A53
            // 
            this.chb_A53.AutoSize = true;
            this.chb_A53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_A53.Location = new System.Drawing.Point(2, 245);
            this.chb_A53.Margin = new System.Windows.Forms.Padding(2);
            this.chb_A53.Name = "chb_A53";
            this.chb_A53.Size = new System.Drawing.Size(300, 29);
            this.chb_A53.TabIndex = 5;
            this.chb_A53.Text = "Samsung Galaxy A53 ₱15,000";
            this.chb_A53.UseVisualStyleBackColor = true;
            this.chb_A53.CheckedChanged += new System.EventHandler(this.chb_A53_CheckedChanged);
            // 
            // chb_redmi
            // 
            this.chb_redmi.AutoSize = true;
            this.chb_redmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_redmi.Location = new System.Drawing.Point(2, 200);
            this.chb_redmi.Margin = new System.Windows.Forms.Padding(2);
            this.chb_redmi.Name = "chb_redmi";
            this.chb_redmi.Size = new System.Drawing.Size(253, 29);
            this.chb_redmi.TabIndex = 4;
            this.chb_redmi.Text = "Xiaomi Redmi 9A. ₱4,000";
            this.chb_redmi.UseVisualStyleBackColor = true;
            this.chb_redmi.CheckedChanged += new System.EventHandler(this.chb_redmi_CheckedChanged);
            // 
            // chb_red
            // 
            this.chb_red.AutoSize = true;
            this.chb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_red.Location = new System.Drawing.Point(2, 151);
            this.chb_red.Margin = new System.Windows.Forms.Padding(2);
            this.chb_red.Name = "chb_red";
            this.chb_red.Size = new System.Drawing.Size(253, 29);
            this.chb_red.TabIndex = 3;
            this.chb_red.Text = "Red Magic 8 Pro ₱30,000";
            this.chb_red.UseVisualStyleBackColor = true;
            this.chb_red.CheckedChanged += new System.EventHandler(this.chb_red_CheckedChanged);
            // 
            // chb_rog
            // 
            this.chb_rog.AutoSize = true;
            this.chb_rog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_rog.Location = new System.Drawing.Point(2, 109);
            this.chb_rog.Margin = new System.Windows.Forms.Padding(2);
            this.chb_rog.Name = "chb_rog";
            this.chb_rog.Size = new System.Drawing.Size(292, 29);
            this.chb_rog.TabIndex = 2;
            this.chb_rog.Text = "ASUS ROG Phone 5 ₱35,000";
            this.chb_rog.UseVisualStyleBackColor = true;
            this.chb_rog.CheckedChanged += new System.EventHandler(this.chb_rog_CheckedChanged);
            // 
            // chb_S23
            // 
            this.chb_S23.AutoSize = true;
            this.chb_S23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_S23.Location = new System.Drawing.Point(2, 61);
            this.chb_S23.Margin = new System.Windows.Forms.Padding(2);
            this.chb_S23.Name = "chb_S23";
            this.chb_S23.Size = new System.Drawing.Size(322, 29);
            this.chb_S23.TabIndex = 1;
            this.chb_S23.Text = "Samsung Galaxy S23 Ultra ₱40k ";
            this.chb_S23.UseVisualStyleBackColor = true;
            this.chb_S23.CheckedChanged += new System.EventHandler(this.chb_S23_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(346, 150);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(217, 29);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.Text = "personalized gold bar";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(358, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "5g 18karat  ₱23,139";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(346, 221);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(198, 29);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "Bracelet Rose Gold";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(358, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "18karat  ₱12,426";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(346, 301);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(146, 29);
            this.checkBox10.TabIndex = 18;
            this.checkBox10.Text = "Ring Bi-Color";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(358, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "18karat  ₱14,140";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(346, 378);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(175, 29);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "Earring Tri-Color";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(358, 483);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "18karat  ₱8,570";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(346, 454);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(214, 29);
            this.checkBox12.TabIndex = 22;
            this.checkBox12.Text = "Necklace White Gold";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(358, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = " 14karat  ₱38,686";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(618, 150);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 354);
            this.listBox1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(769, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_done
            // 
            this.bt_done.BackColor = System.Drawing.Color.Lime;
            this.bt_done.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_done.ForeColor = System.Drawing.Color.Black;
            this.bt_done.Location = new System.Drawing.Point(608, 575);
            this.bt_done.Margin = new System.Windows.Forms.Padding(2);
            this.bt_done.Name = "bt_done";
            this.bt_done.Size = new System.Drawing.Size(104, 31);
            this.bt_done.TabIndex = 27;
            this.bt_done.Text = "DONE";
            this.bt_done.UseVisualStyleBackColor = false;
            this.bt_done.Click += new System.EventHandler(this.bt_done_Click);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTotalAmount.Location = new System.Drawing.Point(721, 521);
            this.labelTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(155, 25);
            this.labelTotalAmount.TabIndex = 29;
            this.labelTotalAmount.Text = "_____________";
            this.labelTotalAmount.Click += new System.EventHandler(this.labelTotalAmount_Click);
            // 
            // bt_total
            // 
            this.bt_total.BackColor = System.Drawing.Color.Lime;
            this.bt_total.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_total.ForeColor = System.Drawing.Color.Black;
            this.bt_total.Location = new System.Drawing.Point(591, 515);
            this.bt_total.Margin = new System.Windows.Forms.Padding(2);
            this.bt_total.Name = "bt_total";
            this.bt_total.Size = new System.Drawing.Size(104, 31);
            this.bt_total.TabIndex = 30;
            this.bt_total.Text = "TotAL";
            this.bt_total.UseVisualStyleBackColor = false;
            this.bt_total.Click += new System.EventHandler(this.bt_total_Click);
            // 
            // Buyingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 664);
            this.Controls.Add(this.bt_total);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.bt_done);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Buyingform";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Buyingform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chb_shark_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_iphone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chb_rog;
        private System.Windows.Forms.CheckBox chb_S23;
        private System.Windows.Forms.CheckBox chb_shark;
        private System.Windows.Forms.CheckBox chb_A53;
        private System.Windows.Forms.CheckBox chb_redmi;
        private System.Windows.Forms.CheckBox chb_red;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_done;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Button bt_total;
    }
}