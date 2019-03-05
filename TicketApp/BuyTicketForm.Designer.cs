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
            this.buttonBuy.Location = new System.Drawing.Point(481, 104);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // numericUpDownTickets
            // 
            this.numericUpDownTickets.Location = new System.Drawing.Point(134, 83);
            this.numericUpDownTickets.Name = "numericUpDownTickets";
            this.numericUpDownTickets.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTickets.TabIndex = 2;
            // 
            // textBoxNumberOfTicketsDescription
            // 
            this.textBoxNumberOfTicketsDescription.Location = new System.Drawing.Point(12, 83);
            this.textBoxNumberOfTicketsDescription.Name = "textBoxNumberOfTicketsDescription";
            this.textBoxNumberOfTicketsDescription.ReadOnly = true;
            this.textBoxNumberOfTicketsDescription.Size = new System.Drawing.Size(116, 20);
            this.textBoxNumberOfTicketsDescription.TabIndex = 3;
            this.textBoxNumberOfTicketsDescription.Text = "Number of tickets:";
            this.textBoxNumberOfTicketsDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}