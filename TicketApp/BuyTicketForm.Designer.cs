namespace TicketApp
{
    partial class BuyTicketForm
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
            this.textBoxTicketInformation = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.numericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumberOfTicketsDescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxCardCode = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxExpirationMonth = new System.Windows.Forms.TextBox();
            this.textBoxExpirationYear = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxToPay = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxPricePerTicket = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTicketInformation
            // 
            this.textBoxTicketInformation.Location = new System.Drawing.Point(12, 12);
            this.textBoxTicketInformation.Name = "textBoxTicketInformation";
            this.textBoxTicketInformation.ReadOnly = true;
            this.textBoxTicketInformation.Size = new System.Drawing.Size(776, 20);
            this.textBoxTicketInformation.TabIndex = 0;
            this.textBoxTicketInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(10, 334);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // numericUpDownTickets
            // 
            this.numericUpDownTickets.Location = new System.Drawing.Point(134, 261);
            this.numericUpDownTickets.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTickets.Name = "numericUpDownTickets";
            this.numericUpDownTickets.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTickets.TabIndex = 2;
            this.numericUpDownTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTickets.ValueChanged += new System.EventHandler(this.numericUpDownTickets_ValueChanged);
            // 
            // textBoxNumberOfTicketsDescription
            // 
            this.textBoxNumberOfTicketsDescription.Location = new System.Drawing.Point(12, 260);
            this.textBoxNumberOfTicketsDescription.Name = "textBoxNumberOfTicketsDescription";
            this.textBoxNumberOfTicketsDescription.ReadOnly = true;
            this.textBoxNumberOfTicketsDescription.Size = new System.Drawing.Size(116, 20);
            this.textBoxNumberOfTicketsDescription.TabIndex = 3;
            this.textBoxNumberOfTicketsDescription.Text = "Number of tickets:";
            this.textBoxNumberOfTicketsDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Card number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Card code:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Expiration Month-Year:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(10, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "-";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(91, 160);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(247, 20);
            this.textBoxCardNumber.TabIndex = 10;
            // 
            // textBoxCardCode
            // 
            this.textBoxCardCode.Location = new System.Drawing.Point(92, 212);
            this.textBoxCardCode.Name = "textBoxCardCode";
            this.textBoxCardCode.Size = new System.Drawing.Size(124, 20);
            this.textBoxCardCode.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(246, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Ex: 04-2019";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExpirationMonth
            // 
            this.textBoxExpirationMonth.Location = new System.Drawing.Point(132, 185);
            this.textBoxExpirationMonth.Name = "textBoxExpirationMonth";
            this.textBoxExpirationMonth.Size = new System.Drawing.Size(43, 20);
            this.textBoxExpirationMonth.TabIndex = 13;
            this.textBoxExpirationMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExpirationYear
            // 
            this.textBoxExpirationYear.Location = new System.Drawing.Point(197, 185);
            this.textBoxExpirationYear.Name = "textBoxExpirationYear";
            this.textBoxExpirationYear.Size = new System.Drawing.Size(43, 20);
            this.textBoxExpirationYear.TabIndex = 14;
            this.textBoxExpirationYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 298);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "To pay:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToPay
            // 
            this.textBoxToPay.Location = new System.Drawing.Point(68, 298);
            this.textBoxToPay.Name = "textBoxToPay";
            this.textBoxToPay.ReadOnly = true;
            this.textBoxToPay.Size = new System.Drawing.Size(57, 20);
            this.textBoxToPay.TabIndex = 16;
            this.textBoxToPay.Text = "0kr";
            this.textBoxToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 76);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(87, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Price per ticket:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPricePerTicket
            // 
            this.textBoxPricePerTicket.Location = new System.Drawing.Point(105, 76);
            this.textBoxPricePerTicket.Name = "textBoxPricePerTicket";
            this.textBoxPricePerTicket.ReadOnly = true;
            this.textBoxPricePerTicket.Size = new System.Drawing.Size(70, 20);
            this.textBoxPricePerTicket.TabIndex = 18;
            this.textBoxPricePerTicket.Text = "0kr";
            this.textBoxPricePerTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPricePerTicket);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxToPay);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBoxExpirationYear);
            this.Controls.Add(this.textBoxExpirationMonth);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxCardCode);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNumberOfTicketsDescription);
            this.Controls.Add(this.numericUpDownTickets);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.textBoxTicketInformation);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTicketInformation;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.NumericUpDown numericUpDownTickets;
        private System.Windows.Forms.TextBox textBoxNumberOfTicketsDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxCardCode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxExpirationMonth;
        private System.Windows.Forms.TextBox textBoxExpirationYear;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxToPay;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxPricePerTicket;
    }
}