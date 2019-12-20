namespace Storage.Forms.Shopkeeper
{
    partial class NewLotForm
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
            this.reqList = new System.Windows.Forms.Panel();
            this.skReadyGoodsLabel = new System.Windows.Forms.Label();
            this.addLotBtn = new System.Windows.Forms.Button();
            this.storageListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(212, 13);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(77, 25);
            this.purcOrderInfoLabel.TabIndex = 20;
            this.purcOrderInfoLabel.Text = "Товар";
            // 
            // reqList
            // 
            this.reqList.AutoScroll = true;
            this.reqList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqList.Location = new System.Drawing.Point(217, 41);
            this.reqList.Name = "reqList";
            this.reqList.Size = new System.Drawing.Size(1195, 342);
            this.reqList.TabIndex = 19;
            // 
            // skReadyGoodsLabel
            // 
            this.skReadyGoodsLabel.AutoSize = true;
            this.skReadyGoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skReadyGoodsLabel.Location = new System.Drawing.Point(12, 9);
            this.skReadyGoodsLabel.Name = "skReadyGoodsLabel";
            this.skReadyGoodsLabel.Size = new System.Drawing.Size(79, 25);
            this.skReadyGoodsLabel.TabIndex = 18;
            this.skReadyGoodsLabel.Text = "Склад";
            // 
            // addLotBtn
            // 
            this.addLotBtn.Location = new System.Drawing.Point(17, 390);
            this.addLotBtn.Name = "addLotBtn";
            this.addLotBtn.Size = new System.Drawing.Size(1395, 48);
            this.addLotBtn.TabIndex = 17;
            this.addLotBtn.Text = "Оформить";
            this.addLotBtn.UseVisualStyleBackColor = true;
            this.addLotBtn.Click += new System.EventHandler(this.AddLotBtn_Click);
            // 
            // storageListPanel
            // 
            this.storageListPanel.AutoScroll = true;
            this.storageListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storageListPanel.Location = new System.Drawing.Point(17, 41);
            this.storageListPanel.Name = "storageListPanel";
            this.storageListPanel.Size = new System.Drawing.Size(194, 342);
            this.storageListPanel.TabIndex = 16;
            // 
            // NewLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 450);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.reqList);
            this.Controls.Add(this.skReadyGoodsLabel);
            this.Controls.Add(this.addLotBtn);
            this.Controls.Add(this.storageListPanel);
            this.Name = "NewLotForm";
            this.Text = "Формировать партию товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel reqList;
        private System.Windows.Forms.Label skReadyGoodsLabel;
        public System.Windows.Forms.Button addLotBtn;
        public System.Windows.Forms.Panel storageListPanel;
    }
}