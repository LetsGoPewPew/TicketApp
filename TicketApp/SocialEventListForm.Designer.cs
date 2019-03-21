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
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonCreateSocialEvent = new System.Windows.Forms.Button();
            this.ButtonVerify = new System.Windows.Forms.Button();
            this.ButtonRefreshSocialEventList = new System.Windows.Forms.Button();
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
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(668, 396);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(120, 23);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Log out";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonCreateSocialEvent
            // 
            this.ButtonCreateSocialEvent.Location = new System.Drawing.Point(668, 170);
            this.ButtonCreateSocialEvent.Name = "ButtonCreateSocialEvent";
            this.ButtonCreateSocialEvent.Size = new System.Drawing.Size(120, 23);
            this.ButtonCreateSocialEvent.TabIndex = 3;
            this.ButtonCreateSocialEvent.Text = "Create Event";
            this.ButtonCreateSocialEvent.UseVisualStyleBackColor = true;
            this.ButtonCreateSocialEvent.Visible = false;
            this.ButtonCreateSocialEvent.Click += new System.EventHandler(this.ButtonCreateSocialEvent_Click);
            // 
            // ButtonVerify
            // 
            this.ButtonVerify.Location = new System.Drawing.Point(669, 270);
            this.ButtonVerify.Name = "ButtonVerify";
            this.ButtonVerify.Size = new System.Drawing.Size(119, 23);
            this.ButtonVerify.TabIndex = 3;
            this.ButtonVerify.Text = "Verify account";
            this.ButtonVerify.UseVisualStyleBackColor = true;
            this.ButtonVerify.Visible = false;
            this.ButtonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // ButtonRefreshSocialEventList
            // 
            this.ButtonRefreshSocialEventList.Location = new System.Drawing.Point(669, 327);
            this.ButtonRefreshSocialEventList.Name = "ButtonRefreshSocialEventList";
            this.ButtonRefreshSocialEventList.Size = new System.Drawing.Size(119, 23);
            this.ButtonRefreshSocialEventList.TabIndex = 4;
            this.ButtonRefreshSocialEventList.Text = "Refresh";
            this.ButtonRefreshSocialEventList.UseVisualStyleBackColor = true;
            this.ButtonRefreshSocialEventList.Click += new System.EventHandler(this.ButtonRefreshSocialEventList_Click);
            // 
            // SocialEventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRefreshSocialEventList);
            this.Controls.Add(this.ButtonVerify);
            this.Controls.Add(this.ButtonCreateSocialEvent);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.listBoxSocialEvents);
            this.Name = "SocialEventListForm";
            this.Text = "SocialEventListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSocialEvents;
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonVerify;
        private System.Windows.Forms.Button ButtonCreateSocialEvent;
        private System.Windows.Forms.Button ButtonRefreshSocialEventList;
    }
}