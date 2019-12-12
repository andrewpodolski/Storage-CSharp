namespace Storage.Forms.PurcaseMan
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
            this.purcOrderFromPanel = new System.Windows.Forms.Panel();
            this.purcAcceptOrderBtn = new System.Windows.Forms.Button();
            this.purcOrderFromLabel = new System.Windows.Forms.Label();
            this.purcOrderInfoPanel = new System.Windows.Forms.Panel();
            this.purcOrderInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // purcOrderFromPanel
            // 
            this.purcOrderFromPanel.AutoScroll = true;
            this.purcOrderFromPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purcOrderFromPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderFromPanel.Location = new System.Drawing.Point(12, 42);
            this.purcOrderFromPanel.Name = "purcOrderFromPanel";
            this.purcOrderFromPanel.Size = new System.Drawing.Size(165, 342);
            this.purcOrderFromPanel.TabIndex = 0;
            // 
            // purcAcceptOrderBtn
            // 
            this.purcAcceptOrderBtn.Location = new System.Drawing.Point(12, 390);
            this.purcAcceptOrderBtn.Name = "purcAcceptOrderBtn";
            this.purcAcceptOrderBtn.Size = new System.Drawing.Size(1395, 48);
            this.purcAcceptOrderBtn.TabIndex = 1;
            this.purcAcceptOrderBtn.Text = "Заказать";
            this.purcAcceptOrderBtn.UseVisualStyleBackColor = true;
            this.purcAcceptOrderBtn.Click += new System.EventHandler(this.PurcAcceptOrderBtn_Click);
            // 
            // purcOrderFromLabel
            // 
            this.purcOrderFromLabel.AutoSize = true;
            this.purcOrderFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderFromLabel.Location = new System.Drawing.Point(12, 14);
            this.purcOrderFromLabel.Name = "purcOrderFromLabel";
            this.purcOrderFromLabel.Size = new System.Drawing.Size(145, 25);
            this.purcOrderFromLabel.TabIndex = 2;
            this.purcOrderFromLabel.Text = "Поставщики";
            // 
            // purcOrderInfoPanel
            // 
            this.purcOrderInfoPanel.AutoScroll = true;
            this.purcOrderInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purcOrderInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoPanel.Location = new System.Drawing.Point(183, 42);
            this.purcOrderInfoPanel.Name = "purcOrderInfoPanel";
            this.purcOrderInfoPanel.Size = new System.Drawing.Size(1224, 342);
            this.purcOrderInfoPanel.TabIndex = 4;
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(184, 14);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(77, 25);
            this.purcOrderInfoLabel.TabIndex = 5;
            this.purcOrderInfoLabel.Text = "Товар";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 445);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.purcOrderInfoPanel);
            this.Controls.Add(this.purcOrderFromLabel);
            this.Controls.Add(this.purcAcceptOrderBtn);
            this.Controls.Add(this.purcOrderFromPanel);
            this.Name = "NewProductForm";
            this.Text = "Заказать товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel purcOrderFromPanel;
        public System.Windows.Forms.Button purcAcceptOrderBtn;
        public System.Windows.Forms.Panel purcOrderInfoPanel;
        private System.Windows.Forms.Label purcOrderFromLabel;
        private System.Windows.Forms.Label purcOrderInfoLabel;
    }
}