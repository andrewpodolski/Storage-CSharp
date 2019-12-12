namespace Storage.Forms.ClientMan
{
    partial class OrderPaymentForm
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
            this.client = new System.Windows.Forms.Label();
            this.clientOrderListPanel = new System.Windows.Forms.Panel();
            this.clientLabel = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.clientListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client.Location = new System.Drawing.Point(344, 9);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(92, 25);
            this.client.TabIndex = 15;
            this.client.Text = "Заказы";
            // 
            // clientOrderListPanel
            // 
            this.clientOrderListPanel.AutoScroll = true;
            this.clientOrderListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientOrderListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientOrderListPanel.Location = new System.Drawing.Point(349, 37);
            this.clientOrderListPanel.Name = "clientOrderListPanel";
            this.clientOrderListPanel.Size = new System.Drawing.Size(1166, 342);
            this.clientOrderListPanel.TabIndex = 14;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(12, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(106, 25);
            this.clientLabel.TabIndex = 13;
            this.clientLabel.Text = "Клиенты";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(17, 385);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(1498, 48);
            this.payBtn.TabIndex = 12;
            this.payBtn.Text = "Оплатить";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // clientListPanel
            // 
            this.clientListPanel.AutoScroll = true;
            this.clientListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientListPanel.Location = new System.Drawing.Point(17, 37);
            this.clientListPanel.Name = "clientListPanel";
            this.clientListPanel.Size = new System.Drawing.Size(326, 342);
            this.clientListPanel.TabIndex = 11;
            // 
            // OrderPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 441);
            this.Controls.Add(this.client);
            this.Controls.Add(this.clientOrderListPanel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.clientListPanel);
            this.Name = "OrderPaymentForm";
            this.Text = "Оплата заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label client;
        public System.Windows.Forms.Panel clientOrderListPanel;
        private System.Windows.Forms.Label clientLabel;
        public System.Windows.Forms.Button payBtn;
        public System.Windows.Forms.Panel clientListPanel;
    }
}