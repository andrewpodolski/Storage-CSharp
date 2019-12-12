namespace Storage.Forms.PurcaseMan
{
    partial class ProductInfoForm
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
            this.storeInfoLabel = new System.Windows.Forms.Label();
            this.storInfoPanel = new System.Windows.Forms.Panel();
            this.storeLabel = new System.Windows.Forms.Label();
            this.storeListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // storeInfoLabel
            // 
            this.storeInfoLabel.AutoSize = true;
            this.storeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeInfoLabel.Location = new System.Drawing.Point(178, 6);
            this.storeInfoLabel.Name = "storeInfoLabel";
            this.storeInfoLabel.Size = new System.Drawing.Size(152, 25);
            this.storeInfoLabel.TabIndex = 13;
            this.storeInfoLabel.Text = "Информация";
            // 
            // storInfoPanel
            // 
            this.storInfoPanel.AutoScroll = true;
            this.storInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storInfoPanel.Location = new System.Drawing.Point(183, 34);
            this.storInfoPanel.Name = "storInfoPanel";
            this.storInfoPanel.Size = new System.Drawing.Size(1198, 390);
            this.storInfoPanel.TabIndex = 12;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeLabel.Location = new System.Drawing.Point(7, 6);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(79, 25);
            this.storeLabel.TabIndex = 11;
            this.storeLabel.Text = "Склад";
            // 
            // storeListPanel
            // 
            this.storeListPanel.AutoScroll = true;
            this.storeListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storeListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeListPanel.Location = new System.Drawing.Point(12, 34);
            this.storeListPanel.Name = "storeListPanel";
            this.storeListPanel.Size = new System.Drawing.Size(165, 390);
            this.storeListPanel.TabIndex = 10;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 436);
            this.Controls.Add(this.storeInfoLabel);
            this.Controls.Add(this.storInfoPanel);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.storeListPanel);
            this.Name = "ProductInfoForm";
            this.Text = "Информация о складах";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeInfoLabel;
        public System.Windows.Forms.Panel storInfoPanel;
        private System.Windows.Forms.Label storeLabel;
        public System.Windows.Forms.Panel storeListPanel;
    }
}