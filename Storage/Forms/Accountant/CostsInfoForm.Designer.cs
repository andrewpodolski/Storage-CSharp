namespace Storage.Forms.Accountant
{
    partial class CostsInfoForm
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
            this.income = new System.Windows.Forms.RadioButton();
            this.costs = new System.Windows.Forms.RadioButton();
            this.logs = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Location = new System.Drawing.Point(12, 12);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(84, 17);
            this.income.TabIndex = 0;
            this.income.TabStop = true;
            this.income.Text = "Добавлены";
            this.income.UseVisualStyleBackColor = true;
            this.income.CheckedChanged += new System.EventHandler(this.Income_CheckedChanged);
            // 
            // costs
            // 
            this.costs.AutoSize = true;
            this.costs.Location = new System.Drawing.Point(103, 12);
            this.costs.Name = "costs";
            this.costs.Size = new System.Drawing.Size(88, 17);
            this.costs.TabIndex = 1;
            this.costs.TabStop = true;
            this.costs.Text = "Отправлены";
            this.costs.UseVisualStyleBackColor = true;
            this.costs.CheckedChanged += new System.EventHandler(this.Costs_CheckedChanged);
            // 
            // logs
            // 
            this.logs.AutoScroll = true;
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logs.Location = new System.Drawing.Point(12, 35);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(776, 403);
            this.logs.TabIndex = 2;
            // 
            // CostsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.costs);
            this.Controls.Add(this.income);
            this.Name = "CostsInfoForm";
            this.Text = "Информация о накладных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton income;
        private System.Windows.Forms.RadioButton costs;
        public System.Windows.Forms.Panel logs;
    }
}