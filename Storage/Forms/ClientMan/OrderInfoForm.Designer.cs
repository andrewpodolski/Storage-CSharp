namespace Storage.Forms.ClientMan
{
    partial class OrderInfoForm
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
            this.clientInfoLabel = new System.Windows.Forms.Label();
            this.clientInfoListPanel = new System.Windows.Forms.Panel();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientListLabel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clientInfoLabel
            // 
            this.clientInfoLabel.AutoSize = true;
            this.clientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientInfoLabel.Location = new System.Drawing.Point(266, 9);
            this.clientInfoLabel.Name = "clientInfoLabel";
            this.clientInfoLabel.Size = new System.Drawing.Size(92, 25);
            this.clientInfoLabel.TabIndex = 17;
            this.clientInfoLabel.Text = "Заказы";
            // 
            // clientInfoListPanel
            // 
            this.clientInfoListPanel.AutoScroll = true;
            this.clientInfoListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientInfoListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientInfoListPanel.Location = new System.Drawing.Point(271, 37);
            this.clientInfoListPanel.Name = "clientInfoListPanel";
            this.clientInfoListPanel.Size = new System.Drawing.Size(1117, 390);
            this.clientInfoListPanel.TabIndex = 16;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(12, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(165, 25);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Пользователь";
            // 
            // clientListLabel
            // 
            this.clientListLabel.AutoScroll = true;
            this.clientListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientListLabel.Location = new System.Drawing.Point(17, 37);
            this.clientListLabel.Name = "clientListLabel";
            this.clientListLabel.Size = new System.Drawing.Size(248, 390);
            this.clientListLabel.TabIndex = 14;
            // 
            // OrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 439);
            this.Controls.Add(this.clientInfoLabel);
            this.Controls.Add(this.clientInfoListPanel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientListLabel);
            this.Name = "OrderInfoForm";
            this.Text = "Статус заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientInfoLabel;
        public System.Windows.Forms.Panel clientInfoListPanel;
        private System.Windows.Forms.Label clientLabel;
        public System.Windows.Forms.Panel clientListLabel;
    }
}