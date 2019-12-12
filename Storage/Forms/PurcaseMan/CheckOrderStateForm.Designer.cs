namespace Storage.Forms.PurcaseMan
{
    partial class CheckOrderStateForm
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
            this.purcOrderInfoPanel = new System.Windows.Forms.Panel();
            this.purcOrderListLabel = new System.Windows.Forms.Label();
            this.purcOrderListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(183, 9);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(152, 25);
            this.purcOrderInfoLabel.TabIndex = 9;
            this.purcOrderInfoLabel.Text = "Информация";
            // 
            // purcOrderInfoPanel
            // 
            this.purcOrderInfoPanel.AutoScroll = true;
            this.purcOrderInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purcOrderInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoPanel.Location = new System.Drawing.Point(188, 37);
            this.purcOrderInfoPanel.Name = "purcOrderInfoPanel";
            this.purcOrderInfoPanel.Size = new System.Drawing.Size(1219, 395);
            this.purcOrderInfoPanel.TabIndex = 8;
            // 
            // purcOrderListLabel
            // 
            this.purcOrderListLabel.AutoSize = true;
            this.purcOrderListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderListLabel.Location = new System.Drawing.Point(12, 9);
            this.purcOrderListLabel.Name = "purcOrderListLabel";
            this.purcOrderListLabel.Size = new System.Drawing.Size(76, 25);
            this.purcOrderListLabel.TabIndex = 7;
            this.purcOrderListLabel.Text = "Заказ";
            // 
            // purcOrderListPanel
            // 
            this.purcOrderListPanel.AutoScroll = true;
            this.purcOrderListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purcOrderListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderListPanel.Location = new System.Drawing.Point(17, 37);
            this.purcOrderListPanel.Name = "purcOrderListPanel";
            this.purcOrderListPanel.Size = new System.Drawing.Size(165, 395);
            this.purcOrderListPanel.TabIndex = 6;
            // 
            // CheckOrderStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 444);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.purcOrderInfoPanel);
            this.Controls.Add(this.purcOrderListLabel);
            this.Controls.Add(this.purcOrderListPanel);
            this.Name = "CheckOrderStateForm";
            this.Text = "Состояние заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel purcOrderInfoPanel;
        private System.Windows.Forms.Label purcOrderListLabel;
        public System.Windows.Forms.Panel purcOrderListPanel;
    }
}