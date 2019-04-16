namespace TicketApp
{
    partial class VerifyForm
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
            this.ComboVerificationMethod = new System.Windows.Forms.ComboBox();
            this.ButtonVerify = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboVerificationMethod
            // 
            this.ComboVerificationMethod.FormattingEnabled = true;
            this.ComboVerificationMethod.Location = new System.Drawing.Point(256, 241);
            this.ComboVerificationMethod.Name = "ComboVerificationMethod";
            this.ComboVerificationMethod.Size = new System.Drawing.Size(240, 21);
            this.ComboVerificationMethod.TabIndex = 0;
            // 
            // ButtonVerify
            // 
            this.ButtonVerify.Location = new System.Drawing.Point(378, 308);
            this.ButtonVerify.Name = "ButtonVerify";
            this.ButtonVerify.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerify.TabIndex = 1;
            this.ButtonVerify.Text = "Verify";
            this.ButtonVerify.UseVisualStyleBackColor = true;
            this.ButtonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(270, 308);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonVerify);
            this.Controls.Add(this.ComboVerificationMethod);
            this.Name = "VerifyForm";
            this.Text = "VerifyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboVerificationMethod;
        private System.Windows.Forms.Button ButtonVerify;
        private System.Windows.Forms.Button ButtonBack;
    }
}