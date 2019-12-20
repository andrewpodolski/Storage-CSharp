namespace Storage.Forms.Shopkeeper
{
    partial class NewProductForm
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
            this.purcOrderInfoLabel = new System.Windows.Forms.Label();
            this.skReadyGoodsListPanel = new System.Windows.Forms.Panel();
            this.skReadyGoodsLabel = new System.Windows.Forms.Label();
            this.clientAddOrderBtn = new System.Windows.Forms.Button();
            this.skStorageListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(212, 9);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(77, 25);
            this.purcOrderInfoLabel.TabIndex = 15;
            this.purcOrderInfoLabel.Text = "Товар";
            // 
            // skReadyGoodsListPanel
            // 
            this.skReadyGoodsListPanel.AutoScroll = true;
            this.skReadyGoodsListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skReadyGoodsListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skReadyGoodsListPanel.Location = new System.Drawing.Point(217, 37);
            this.skReadyGoodsListPanel.Name = "skReadyGoodsListPanel";
            this.skReadyGoodsListPanel.Size = new System.Drawing.Size(1195, 342);
            this.skReadyGoodsListPanel.TabIndex = 14;
            // 
            // skReadyGoodsLabel
            // 
            this.skReadyGoodsLabel.AutoSize = true;
            this.skReadyGoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skReadyGoodsLabel.Location = new System.Drawing.Point(12, 9);
            this.skReadyGoodsLabel.Name = "skReadyGoodsLabel";
            this.skReadyGoodsLabel.Size = new System.Drawing.Size(79, 25);
            this.skReadyGoodsLabel.TabIndex = 13;
            this.skReadyGoodsLabel.Text = "Склад";
            // 
            // clientAddOrderBtn
            // 
            this.clientAddOrderBtn.Location = new System.Drawing.Point(17, 385);
            this.clientAddOrderBtn.Name = "clientAddOrderBtn";
            this.clientAddOrderBtn.Size = new System.Drawing.Size(1395, 48);
            this.clientAddOrderBtn.TabIndex = 12;
            this.clientAddOrderBtn.Text = "Оформить";
            this.clientAddOrderBtn.UseVisualStyleBackColor = true;
            this.clientAddOrderBtn.Click += new System.EventHandler(this.ClientAddOrderBtn_Click);
            // 
            // skStorageListPanel
            // 
            this.skStorageListPanel.AutoScroll = true;
            this.skStorageListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skStorageListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skStorageListPanel.Location = new System.Drawing.Point(17, 37);
            this.skStorageListPanel.Name = "skStorageListPanel";
            this.skStorageListPanel.Size = new System.Drawing.Size(194, 342);
            this.skStorageListPanel.TabIndex = 11;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 444);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.skReadyGoodsListPanel);
            this.Controls.Add(this.skReadyGoodsLabel);
            this.Controls.Add(this.clientAddOrderBtn);
            this.Controls.Add(this.skStorageListPanel);
            this.Name = "NewProductForm";
            this.Text = "Оформить новый товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel skReadyGoodsListPanel;
        private System.Windows.Forms.Label skReadyGoodsLabel;
        public System.Windows.Forms.Button clientAddOrderBtn;
        public System.Windows.Forms.Panel skStorageListPanel;
    }
}