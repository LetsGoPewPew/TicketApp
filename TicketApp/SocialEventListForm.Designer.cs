namespace TicketApp
{
    partial class SocialEventListForm
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
            this.listBoxSocialEvents = new System.Windows.Forms.ListBox();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSocialEvents
            // 
            this.listBoxSocialEvents.FormattingEnabled = true;
            this.listBoxSocialEvents.Location = new System.Drawing.Point(12, 12);
            this.listBoxSocialEvents.Name = "listBoxSocialEvents";
            this.listBoxSocialEvents.Size = new System.Drawing.Size(650, 407);
            this.listBoxSocialEvents.TabIndex = 0;
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Location = new System.Drawing.Point(668, 53);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(120, 23);
            this.buttonBuyTicket.TabIndex = 1;
            this.buttonBuyTicket.Text = "Buy ticket";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.ButtonBuyTicket_Click);
            // 
            // SocialEventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.listBoxSocialEvents);
            this.Name = "SocialEventListForm";
            this.Text = "SocialEventListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSocialEvents;
        private System.Windows.Forms.Button buttonBuyTicket;
    }
}