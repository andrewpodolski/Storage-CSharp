namespace Storage.Forms.Accountant
{
    partial class ProviderPaymentForm
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
            this.acReqListPanel = new System.Windows.Forms.Panel();
            this.purcOrderFromLabel = new System.Windows.Forms.Label();
            this.acPayReqBtn = new System.Windows.Forms.Button();
            this.acProviderListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(183, 9);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(92, 25);
            this.purcOrderInfoLabel.TabIndex = 10;
            this.purcOrderInfoLabel.Text = "Заказы";
            // 
            // acReqListPanel
            // 
            this.acReqListPanel.AutoScroll = true;
            this.acReqListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acReqListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acReqListPanel.Location = new System.Drawing.Point(188, 37);
            this.acReqListPanel.Name = "acReqListPanel";
            this.acReqListPanel.Size = new System.Drawing.Size(1225, 342);
            this.acReqListPanel.TabIndex = 9;
            // 
            // purcOrderFromLabel
            // 
            this.purcOrderFromLabel.AutoSize = true;
            this.purcOrderFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderFromLabel.Location = new System.Drawing.Point(12, 9);
            this.purcOrderFromLabel.Name = "purcOrderFromLabel";
            this.purcOrderFromLabel.Size = new System.Drawing.Size(145, 25);
            this.purcOrderFromLabel.TabIndex = 8;
            this.purcOrderFromLabel.Text = "Поставщики";
            // 
            // acPayReqBtn
            // 
            this.acPayReqBtn.Location = new System.Drawing.Point(17, 385);
            this.acPayReqBtn.Name = "acPayReqBtn";
            this.acPayReqBtn.Size = new System.Drawing.Size(1396, 48);
            this.acPayReqBtn.TabIndex = 7;
            this.acPayReqBtn.Text = "Оплатить";
            this.acPayReqBtn.UseVisualStyleBackColor = true;
            this.acPayReqBtn.Click += new System.EventHandler(this.AcPayReqBtn_Click);
            // 
            // acProviderListPanel
            // 
            this.acProviderListPanel.AutoScroll = true;
            this.acProviderListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acProviderListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acProviderListPanel.Location = new System.Drawing.Point(17, 37);
            this.acProviderListPanel.Name = "acProviderListPanel";
            this.acProviderListPanel.Size = new System.Drawing.Size(165, 342);
            this.acProviderListPanel.TabIndex = 6;
            // 
            // ProviderPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 453);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.acReqListPanel);
            this.Controls.Add(this.purcOrderFromLabel);
            this.Controls.Add(this.acPayReqBtn);
            this.Controls.Add(this.acProviderListPanel);
            this.Name = "ProviderPaymentForm";
            this.Text = "Оплата поставщикам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel acReqListPanel;
        private System.Windows.Forms.Label purcOrderFromLabel;
        public System.Windows.Forms.Button acPayReqBtn;
        public System.Windows.Forms.Panel acProviderListPanel;
    }
}