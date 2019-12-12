namespace Storage.Forms
{
    partial class LogsForm
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
            this.write = new System.Windows.Forms.Button();
            this.parametrs = new System.Windows.Forms.ComboBox();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // write
            // 
            this.write.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.write.Location = new System.Drawing.Point(12, 12);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(776, 44);
            this.write.TabIndex = 0;
            this.write.Text = "Записать";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.Write_Click);
            // 
            // parametrs
            // 
            this.parametrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parametrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parametrs.FormattingEnabled = true;
            this.parametrs.Items.AddRange(new object[] {
            "Все. (Без параметров)"});
            this.parametrs.Location = new System.Drawing.Point(12, 62);
            this.parametrs.Name = "parametrs";
            this.parametrs.Size = new System.Drawing.Size(776, 32);
            this.parametrs.TabIndex = 1;
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(12, 100);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(776, 29);
            this.input.TabIndex = 2;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 136);
            this.Controls.Add(this.input);
            this.Controls.Add(this.parametrs);
            this.Controls.Add(this.write);
            this.Name = "LogsForm";
            this.Text = "Логи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button write;
        public System.Windows.Forms.ComboBox parametrs;
        public System.Windows.Forms.TextBox input;
    }
}