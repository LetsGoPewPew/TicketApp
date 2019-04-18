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
            this.buttonBuy = new System.Windows.Forms.Button();
            this.NumericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.TextBoxToPay = new System.Windows.Forms.TextBox();
            this.TextBoxPricePerTicket = new System.Windows.Forms.TextBox();
            this.TextBoxTicketsAvailable = new System.Windows.Forms.TextBox();
            this.ComboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.TextBoxOrganizer = new System.Windows.Forms.TextBox();
            this.LabelTicketsAvailable = new System.Windows.Forms.Label();
            this.LabelPricePerTicket = new System.Windows.Forms.Label();
            this.LabelOrganizer = new System.Windows.Forms.Label();
            this.LabelNumberOfTickets = new System.Windows.Forms.Label();
            this.LabelToPay = new System.Windows.Forms.Label();
            this.LabelSocialEventDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(54, 351);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // NumericUpDownTickets
            // 
            this.NumericUpDownTickets.Location = new System.Drawing.Point(134, 259);
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
            // TextBoxToPay
            // 
            this.TextBoxToPay.Location = new System.Drawing.Point(105, 298);
            this.TextBoxToPay.Name = "TextBoxToPay";
            this.TextBoxToPay.ReadOnly = true;
            this.TextBoxToPay.Size = new System.Drawing.Size(75, 20);
            this.TextBoxToPay.TabIndex = 16;
            this.TextBoxToPay.Text = "0kr";
            this.TextBoxToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxPricePerTicket
            // 
            this.TextBoxPricePerTicket.Location = new System.Drawing.Point(105, 127);
            this.TextBoxPricePerTicket.Name = "TextBoxPricePerTicket";
            this.TextBoxPricePerTicket.ReadOnly = true;
            this.TextBoxPricePerTicket.Size = new System.Drawing.Size(75, 20);
            this.TextBoxPricePerTicket.TabIndex = 18;
            this.TextBoxPricePerTicket.Text = "0kr";
            this.TextBoxPricePerTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTicketsAvailable
            // 
            this.TextBoxTicketsAvailable.Location = new System.Drawing.Point(105, 104);
            this.TextBoxTicketsAvailable.Name = "TextBoxTicketsAvailable";
            this.TextBoxTicketsAvailable.ReadOnly = true;
            this.TextBoxTicketsAvailable.Size = new System.Drawing.Size(75, 20);
            this.TextBoxTicketsAvailable.TabIndex = 20;
            this.TextBoxTicketsAvailable.Text = "0/0";
            this.TextBoxTicketsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboPaymentMethod
            // 
            this.ComboPaymentMethod.FormattingEnabled = true;
            this.ComboPaymentMethod.Location = new System.Drawing.Point(12, 324);
            this.ComboPaymentMethod.Name = "ComboPaymentMethod";
            this.ComboPaymentMethod.Size = new System.Drawing.Size(168, 21);
            this.ComboPaymentMethod.TabIndex = 21;
            // 
            // TextBoxOrganizer
            // 
            this.TextBoxOrganizer.Location = new System.Drawing.Point(105, 60);
            this.TextBoxOrganizer.Name = "TextBoxOrganizer";
            this.TextBoxOrganizer.ReadOnly = true;
            this.TextBoxOrganizer.Size = new System.Drawing.Size(75, 20);
            this.TextBoxOrganizer.TabIndex = 23;
            this.TextBoxOrganizer.Text = "Organizer name";
            this.TextBoxOrganizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTicketsAvailable
            // 
            this.LabelTicketsAvailable.AutoSize = true;
            this.LabelTicketsAvailable.Location = new System.Drawing.Point(9, 107);
            this.LabelTicketsAvailable.Name = "LabelTicketsAvailable";
            this.LabelTicketsAvailable.Size = new System.Drawing.Size(90, 13);
            this.LabelTicketsAvailable.TabIndex = 24;
            this.LabelTicketsAvailable.Text = "Tickets available:";
            // 
            // LabelPricePerTicket
            // 
            this.LabelPricePerTicket.AutoSize = true;
            this.LabelPricePerTicket.Location = new System.Drawing.Point(9, 130);
            this.LabelPricePerTicket.Name = "LabelPricePerTicket";
            this.LabelPricePerTicket.Size = new System.Drawing.Size(81, 13);
            this.LabelPricePerTicket.TabIndex = 25;
            this.LabelPricePerTicket.Text = "Price per ticket:";
            // 
            // LabelOrganizer
            // 
            this.LabelOrganizer.AutoSize = true;
            this.LabelOrganizer.Location = new System.Drawing.Point(9, 63);
            this.LabelOrganizer.Name = "LabelOrganizer";
            this.LabelOrganizer.Size = new System.Drawing.Size(55, 13);
            this.LabelOrganizer.TabIndex = 26;
            this.LabelOrganizer.Text = "Organizer:";
            // 
            // LabelNumberOfTickets
            // 
            this.LabelNumberOfTickets.AutoSize = true;
            this.LabelNumberOfTickets.Location = new System.Drawing.Point(9, 261);
            this.LabelNumberOfTickets.Name = "LabelNumberOfTickets";
            this.LabelNumberOfTickets.Size = new System.Drawing.Size(93, 13);
            this.LabelNumberOfTickets.TabIndex = 27;
            this.LabelNumberOfTickets.Text = "Number of tickets:";
            // 
            // LabelToPay
            // 
            this.LabelToPay.AutoSize = true;
            this.LabelToPay.Location = new System.Drawing.Point(9, 305);
            this.LabelToPay.Name = "LabelToPay";
            this.LabelToPay.Size = new System.Drawing.Size(43, 13);
            this.LabelToPay.TabIndex = 28;
            this.LabelToPay.Text = "To pay:";
            // 
            // LabelSocialEventDescription
            // 
            this.LabelSocialEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSocialEventDescription.Location = new System.Drawing.Point(12, 9);
            this.LabelSocialEventDescription.Name = "LabelSocialEventDescription";
            this.LabelSocialEventDescription.Size = new System.Drawing.Size(776, 31);
            this.LabelSocialEventDescription.TabIndex = 29;
            this.LabelSocialEventDescription.Text = "SocialEventDescription";
            this.LabelSocialEventDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelSocialEventDescription);
            this.Controls.Add(this.LabelToPay);
            this.Controls.Add(this.LabelNumberOfTickets);
            this.Controls.Add(this.LabelOrganizer);
            this.Controls.Add(this.LabelPricePerTicket);
            this.Controls.Add(this.LabelTicketsAvailable);
            this.Controls.Add(this.TextBoxOrganizer);
            this.Controls.Add(this.ComboPaymentMethod);
            this.Controls.Add(this.TextBoxTicketsAvailable);
            this.Controls.Add(this.TextBoxPricePerTicket);
            this.Controls.Add(this.TextBoxToPay);
            this.Controls.Add(this.NumericUpDownTickets);
            this.Controls.Add(this.buttonBuy);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.NumericUpDown NumericUpDownTickets;
        private System.Windows.Forms.TextBox TextBoxToPay;
        private System.Windows.Forms.TextBox TextBoxPricePerTicket;
        private System.Windows.Forms.TextBox TextBoxTicketsAvailable;
        private System.Windows.Forms.ComboBox ComboPaymentMethod;
        private System.Windows.Forms.TextBox TextBoxOrganizer;
        private System.Windows.Forms.Label LabelTicketsAvailable;
        private System.Windows.Forms.Label LabelPricePerTicket;
        private System.Windows.Forms.Label LabelOrganizer;
        private System.Windows.Forms.Label LabelNumberOfTickets;
        private System.Windows.Forms.Label LabelToPay;
        private System.Windows.Forms.Label LabelSocialEventDescription;
    }
}