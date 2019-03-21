namespace TicketApp
{
    partial class CreateSocialEventForm
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
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxSocialEventName = new System.Windows.Forms.TextBox();
            this.NumericUpDownTotalTickets = new System.Windows.Forms.NumericUpDown();
            this.ButtonCreateSocialEvent = new System.Windows.Forms.Button();
            this.NumericUpDownTicketPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTotalTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(244, 141);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCategory.TabIndex = 1;
            // 
            // TextBoxSocialEventName
            // 
            this.TextBoxSocialEventName.Location = new System.Drawing.Point(244, 167);
            this.TextBoxSocialEventName.Name = "TextBoxSocialEventName";
            this.TextBoxSocialEventName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSocialEventName.TabIndex = 2;
            // 
            // NumericUpDownTotalTickets
            // 
            this.NumericUpDownTotalTickets.Location = new System.Drawing.Point(244, 72);
            this.NumericUpDownTotalTickets.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownTotalTickets.Name = "NumericUpDownTotalTickets";
            this.NumericUpDownTotalTickets.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownTotalTickets.TabIndex = 3;
            // 
            // ButtonCreateSocialEvent
            // 
            this.ButtonCreateSocialEvent.Location = new System.Drawing.Point(244, 222);
            this.ButtonCreateSocialEvent.Name = "ButtonCreateSocialEvent";
            this.ButtonCreateSocialEvent.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateSocialEvent.TabIndex = 4;
            this.ButtonCreateSocialEvent.Text = "Create SocialEvent";
            this.ButtonCreateSocialEvent.UseVisualStyleBackColor = true;
            this.ButtonCreateSocialEvent.Click += new System.EventHandler(this.ButtonCreateSocialEvent_Click);
            // 
            // NumericUpDownTicketPrice
            // 
            this.NumericUpDownTicketPrice.Location = new System.Drawing.Point(244, 98);
            this.NumericUpDownTicketPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Name = "NumericUpDownTicketPrice";
            this.NumericUpDownTicketPrice.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownTicketPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total amount of tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price per ticket:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // CreateSocialEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownTicketPrice);
            this.Controls.Add(this.ButtonCreateSocialEvent);
            this.Controls.Add(this.NumericUpDownTotalTickets);
            this.Controls.Add(this.TextBoxSocialEventName);
            this.Controls.Add(this.TextBoxCategory);
            this.Name = "CreateSocialEventForm";
            this.Text = "CreateSocialEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTotalTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxSocialEventName;
        private System.Windows.Forms.NumericUpDown NumericUpDownTotalTickets;
        private System.Windows.Forms.Button ButtonCreateSocialEvent;
        private System.Windows.Forms.NumericUpDown NumericUpDownTicketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}