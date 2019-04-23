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
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTotalTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(325, 174);
            this.TextBoxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(132, 22);
            this.TextBoxCategory.TabIndex = 1;
            // 
            // TextBoxSocialEventName
            // 
            this.TextBoxSocialEventName.Location = new System.Drawing.Point(325, 206);
            this.TextBoxSocialEventName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxSocialEventName.Name = "TextBoxSocialEventName";
            this.TextBoxSocialEventName.Size = new System.Drawing.Size(132, 22);
            this.TextBoxSocialEventName.TabIndex = 2;
            // 
            // NumericUpDownTotalTickets
            // 
            this.NumericUpDownTotalTickets.Location = new System.Drawing.Point(325, 89);
            this.NumericUpDownTotalTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumericUpDownTotalTickets.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownTotalTickets.Name = "NumericUpDownTotalTickets";
            this.NumericUpDownTotalTickets.Size = new System.Drawing.Size(133, 22);
            this.NumericUpDownTotalTickets.TabIndex = 3;
            // 
            // ButtonCreateSocialEvent
            // 
            this.ButtonCreateSocialEvent.Location = new System.Drawing.Point(369, 283);
            this.ButtonCreateSocialEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCreateSocialEvent.Name = "ButtonCreateSocialEvent";
            this.ButtonCreateSocialEvent.Size = new System.Drawing.Size(100, 28);
            this.ButtonCreateSocialEvent.TabIndex = 4;
            this.ButtonCreateSocialEvent.Text = "Create SocialEvent";
            this.ButtonCreateSocialEvent.UseVisualStyleBackColor = true;
            this.ButtonCreateSocialEvent.Click += new System.EventHandler(this.ButtonCreateSocialEvent_Click);
            // 
            // NumericUpDownTicketPrice
            // 
            this.NumericUpDownTicketPrice.Location = new System.Drawing.Point(325, 121);
            this.NumericUpDownTicketPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumericUpDownTicketPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Name = "NumericUpDownTicketPrice";
            this.NumericUpDownTicketPrice.Size = new System.Drawing.Size(133, 22);
            this.NumericUpDownTicketPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total amount of tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price per ticket:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(234, 283);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 28);
            this.ButtonBack.TabIndex = 10;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CreateSocialEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownTicketPrice);
            this.Controls.Add(this.ButtonCreateSocialEvent);
            this.Controls.Add(this.NumericUpDownTotalTickets);
            this.Controls.Add(this.TextBoxSocialEventName);
            this.Controls.Add(this.TextBoxCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button ButtonBack;
    }
}