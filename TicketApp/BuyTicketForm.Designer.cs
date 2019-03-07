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
            this.textBoxSocialEventDescription = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.NumericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumberOfTicketsDescription = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxToPay = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxPricePerTicket = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxTicketsAvailable = new System.Windows.Forms.TextBox();
            this.ComboPaymentMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSocialEventDescription
            // 
            this.textBoxSocialEventDescription.Location = new System.Drawing.Point(12, 12);
            this.textBoxSocialEventDescription.Name = "textBoxSocialEventDescription";
            this.textBoxSocialEventDescription.ReadOnly = true;
            this.textBoxSocialEventDescription.Size = new System.Drawing.Size(776, 20);
            this.textBoxSocialEventDescription.TabIndex = 0;
            this.textBoxSocialEventDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(12, 351);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // NumericUpDownTickets
            // 
            this.NumericUpDownTickets.Location = new System.Drawing.Point(134, 261);
            this.NumericUpDownTickets.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDownTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownTickets.Name = "NumericUpDownTickets";
            this.NumericUpDownTickets.Size = new System.Drawing.Size(46, 20);
            this.NumericUpDownTickets.TabIndex = 2;
            this.NumericUpDownTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownTickets.ValueChanged += new System.EventHandler(this.NumericUpDownTickets_ValueChanged);
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
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 50);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(94, 20);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "Tickets available:";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTicketsAvailable
            // 
            this.textBoxTicketsAvailable.Location = new System.Drawing.Point(112, 50);
            this.textBoxTicketsAvailable.Name = "textBoxTicketsAvailable";
            this.textBoxTicketsAvailable.ReadOnly = true;
            this.textBoxTicketsAvailable.Size = new System.Drawing.Size(63, 20);
            this.textBoxTicketsAvailable.TabIndex = 20;
            this.textBoxTicketsAvailable.Text = "0/0";
            this.textBoxTicketsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboPaymentMethod
            // 
            this.ComboPaymentMethod.FormattingEnabled = true;
            this.ComboPaymentMethod.Location = new System.Drawing.Point(7, 324);
            this.ComboPaymentMethod.Name = "ComboPaymentMethod";
            this.ComboPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.ComboPaymentMethod.TabIndex = 21;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboPaymentMethod);
            this.Controls.Add(this.textBoxTicketsAvailable);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBoxPricePerTicket);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxToPay);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBoxNumberOfTicketsDescription);
            this.Controls.Add(this.NumericUpDownTickets);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.textBoxSocialEventDescription);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSocialEventDescription;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.NumericUpDown NumericUpDownTickets;
        private System.Windows.Forms.TextBox textBoxNumberOfTicketsDescription;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxToPay;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxPricePerTicket;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBoxTicketsAvailable;
        private System.Windows.Forms.ComboBox ComboPaymentMethod;
    }
}