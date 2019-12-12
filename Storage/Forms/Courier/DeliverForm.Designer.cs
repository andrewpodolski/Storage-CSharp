namespace Storage.Forms.Courier
{
    partial class DeliverForm
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
            this.delGoodsList = new System.Windows.Forms.Panel();
            this.purcOrderFromLabel = new System.Windows.Forms.Label();
            this.deliverBtn = new System.Windows.Forms.Button();
            this.delClientList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // purcOrderInfoLabel
            // 
            this.purcOrderInfoLabel.AutoSize = true;
            this.purcOrderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderInfoLabel.Location = new System.Drawing.Point(184, 10);
            this.purcOrderInfoLabel.Name = "purcOrderInfoLabel";
            this.purcOrderInfoLabel.Size = new System.Drawing.Size(77, 25);
            this.purcOrderInfoLabel.TabIndex = 10;
            this.purcOrderInfoLabel.Text = "Товар";
            // 
            // delGoodsList
            // 
            this.delGoodsList.AutoScroll = true;
            this.delGoodsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delGoodsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delGoodsList.Location = new System.Drawing.Point(183, 38);
            this.delGoodsList.Name = "delGoodsList";
            this.delGoodsList.Size = new System.Drawing.Size(1224, 342);
            this.delGoodsList.TabIndex = 9;
            // 
            // purcOrderFromLabel
            // 
            this.purcOrderFromLabel.AutoSize = true;
            this.purcOrderFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purcOrderFromLabel.Location = new System.Drawing.Point(12, 10);
            this.purcOrderFromLabel.Name = "purcOrderFromLabel";
            this.purcOrderFromLabel.Size = new System.Drawing.Size(90, 25);
            this.purcOrderFromLabel.TabIndex = 8;
            this.purcOrderFromLabel.Text = "Клиент";
            // 
            // deliverBtn
            // 
            this.deliverBtn.Location = new System.Drawing.Point(12, 386);
            this.deliverBtn.Name = "deliverBtn";
            this.deliverBtn.Size = new System.Drawing.Size(1395, 48);
            this.deliverBtn.TabIndex = 7;
            this.deliverBtn.Text = "Доставить";
            this.deliverBtn.UseVisualStyleBackColor = true;
            this.deliverBtn.Click += new System.EventHandler(this.DeliverBtn_Click);
            // 
            // delClientList
            // 
            this.delClientList.AutoScroll = true;
            this.delClientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delClientList.Location = new System.Drawing.Point(12, 38);
            this.delClientList.Name = "delClientList";
            this.delClientList.Size = new System.Drawing.Size(165, 342);
            this.delClientList.TabIndex = 6;
            // 
            // DeliverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 450);
            this.Controls.Add(this.purcOrderInfoLabel);
            this.Controls.Add(this.delGoodsList);
            this.Controls.Add(this.purcOrderFromLabel);
            this.Controls.Add(this.deliverBtn);
            this.Controls.Add(this.delClientList);
            this.Name = "DeliverForm";
            this.Text = "Доставить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purcOrderInfoLabel;
        public System.Windows.Forms.Panel delGoodsList;
        private System.Windows.Forms.Label purcOrderFromLabel;
        public System.Windows.Forms.Button deliverBtn;
        public System.Windows.Forms.Panel delClientList;
    }
}