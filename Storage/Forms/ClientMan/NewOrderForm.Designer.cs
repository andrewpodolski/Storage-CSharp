namespace Storage.Forms.ClientMan
{
    partial class NewOrderForm
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
            this.clientGoodsListPanel = new System.Windows.Forms.Panel();
            this.clientFoodTypeLabel = new System.Windows.Forms.Label();
            this.clientAddOrderBtn = new System.Windows.Forms.Button();
            this.clientGoodsTypeListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(212, 9);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(77, 25);
            this.purcOrderInfoLabel.TabIndex = 10;
            this.purcOrderInfoLabel.Text = "Товар";
            // 
            // clientGoodsListPanel
            // 
            this.clientGoodsListPanel.AutoScroll = true;
            this.clientGoodsListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientGoodsListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientGoodsListPanel.Location = new System.Drawing.Point(217, 37);
            this.clientGoodsListPanel.Name = "clientGoodsListPanel";
            this.clientGoodsListPanel.Size = new System.Drawing.Size(1195, 342);
            this.clientGoodsListPanel.TabIndex = 9;
            // 
            // clientFoodTypeLabel
            // 
            this.clientFoodTypeLabel.AutoSize = true;
            this.clientFoodTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientFoodTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.clientFoodTypeLabel.Name = "clientFoodTypeLabel";
            this.clientFoodTypeLabel.Size = new System.Drawing.Size(134, 25);
            this.clientFoodTypeLabel.TabIndex = 8;
            this.clientFoodTypeLabel.Text = "Тип товара";
            // 
            // clientAddOrderBtn
            // 
            this.clientAddOrderBtn.Location = new System.Drawing.Point(17, 385);
            this.clientAddOrderBtn.Name = "clientAddOrderBtn";
            this.clientAddOrderBtn.Size = new System.Drawing.Size(1395, 48);
            this.clientAddOrderBtn.TabIndex = 7;
            this.clientAddOrderBtn.Text = "Заказать";
            this.clientAddOrderBtn.UseVisualStyleBackColor = true;
            this.clientAddOrderBtn.Click += new System.EventHandler(this.ClientAddOrderBtn_Click);
            // 
            // clientGoodsTypeListPanel
            // 
            this.clientGoodsTypeListPanel.AutoScroll = true;
            this.clientGoodsTypeListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientGoodsTypeListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientGoodsTypeListPanel.Location = new System.Drawing.Point(17, 37);
            this.clientGoodsTypeListPanel.Name = "clientGoodsTypeListPanel";
            this.clientGoodsTypeListPanel.Size = new System.Drawing.Size(194, 342);
            this.clientGoodsTypeListPanel.TabIndex = 6;
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 438);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.clientGoodsListPanel);
            this.Controls.Add(this.clientFoodTypeLabel);
            this.Controls.Add(this.clientAddOrderBtn);
            this.Controls.Add(this.clientGoodsTypeListPanel);
            this.Name = "NewOrderForm";
            this.Text = "Оформить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel clientGoodsListPanel;
        private System.Windows.Forms.Label clientFoodTypeLabel;
        public System.Windows.Forms.Button clientAddOrderBtn;
        public System.Windows.Forms.Panel clientGoodsTypeListPanel;
    }
}