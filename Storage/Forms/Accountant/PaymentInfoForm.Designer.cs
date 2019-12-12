namespace Storage.Forms.Accountant
{
    partial class PaymentInfoForm
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
            this.reqInfoLabel = new System.Windows.Forms.Label();
            this.reqInfoPanel = new System.Windows.Forms.Panel();
            this.reqLabel = new System.Windows.Forms.Label();
            this.reqListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reqInfoLabel
            // 
            this.reqInfoLabel.AutoSize = true;
            this.reqInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqInfoLabel.Location = new System.Drawing.Point(183, 9);
            this.reqInfoLabel.Name = "reqInfoLabel";
            this.reqInfoLabel.Size = new System.Drawing.Size(152, 25);
            this.reqInfoLabel.TabIndex = 17;
            this.reqInfoLabel.Text = "Информация";
            // 
            // reqInfoPanel
            // 
            this.reqInfoPanel.AutoScroll = true;
            this.reqInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqInfoPanel.Location = new System.Drawing.Point(188, 37);
            this.reqInfoPanel.Name = "reqInfoPanel";
            this.reqInfoPanel.Size = new System.Drawing.Size(1207, 401);
            this.reqInfoPanel.TabIndex = 16;
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqLabel.Location = new System.Drawing.Point(12, 9);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(92, 25);
            this.reqLabel.TabIndex = 15;
            this.reqLabel.Text = "Заказы";
            // 
            // reqListPanel
            // 
            this.reqListPanel.AutoScroll = true;
            this.reqListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqListPanel.Location = new System.Drawing.Point(17, 37);
            this.reqListPanel.Name = "reqListPanel";
            this.reqListPanel.Size = new System.Drawing.Size(165, 401);
            this.reqListPanel.TabIndex = 14;
            // 
            // PaymentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 450);
            this.Controls.Add(this.reqInfoLabel);
            this.Controls.Add(this.reqInfoPanel);
            this.Controls.Add(this.reqLabel);
            this.Controls.Add(this.reqListPanel);
            this.Name = "PaymentInfoForm";
            this.Text = "Информация об оплате";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqInfoLabel;
        public System.Windows.Forms.Panel reqInfoPanel;
        private System.Windows.Forms.Label reqLabel;
        public System.Windows.Forms.Panel reqListPanel;
    }
}