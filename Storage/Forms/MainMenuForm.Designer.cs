namespace Storage
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainLabel = new System.Windows.Forms.Label();
            this.clientManTabPage = new System.Windows.Forms.TabPage();
            this.clientManPayBtn = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientListCB = new System.Windows.Forms.ComboBox();
            this.clientCheckOrderStatusBtn = new System.Windows.Forms.Button();
            this.clientNewOrderBtn = new System.Windows.Forms.Button();
            this.storkeeperTabPage = new System.Windows.Forms.TabPage();
            this.skLabel = new System.Windows.Forms.Label();
            this.skListCB = new System.Windows.Forms.ComboBox();
            this.skNewLotBtn = new System.Windows.Forms.Button();
            this.skNewProductBtn = new System.Windows.Forms.Button();
            this.accountantTabPage = new System.Windows.Forms.TabPage();
            this.acLabel = new System.Windows.Forms.Label();
            this.acListCB = new System.Windows.Forms.ComboBox();
            this.acCostsInfoBtn = new System.Windows.Forms.Button();
            this.acProviderPaymentBtn = new System.Windows.Forms.Button();
            this.acPaymentInfoBtn = new System.Windows.Forms.Button();
            this.purchaseManTabPage = new System.Windows.Forms.TabPage();
            this.purcManLabel = new System.Windows.Forms.Label();
            this.purcManListCB = new System.Windows.Forms.ComboBox();
            this.purcProductInfoBtn = new System.Windows.Forms.Button();
            this.purcCheckOrderStateBtn = new System.Windows.Forms.Button();
            this.purcNewProductBtn = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.statusBar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courierDeliverBtn = new System.Windows.Forms.Button();
            this.courierListCB = new System.Windows.Forms.ComboBox();
            this.courierLabel = new System.Windows.Forms.Label();
            this.courierTabPage = new System.Windows.Forms.TabPage();
            this.clientManTabPage.SuspendLayout();
            this.storkeeperTabPage.SuspendLayout();
            this.accountantTabPage.SuspendLayout();
            this.purchaseManTabPage.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.courierTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(11, 43);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(374, 31);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Система складского учёта";
            // 
            // clientManTabPage
            // 
            this.clientManTabPage.Controls.Add(this.clientManPayBtn);
            this.clientManTabPage.Controls.Add(this.clientLabel);
            this.clientManTabPage.Controls.Add(this.clientListCB);
            this.clientManTabPage.Controls.Add(this.clientCheckOrderStatusBtn);
            this.clientManTabPage.Controls.Add(this.clientNewOrderBtn);
            this.clientManTabPage.Location = new System.Drawing.Point(4, 34);
            this.clientManTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientManTabPage.Name = "clientManTabPage";
            this.clientManTabPage.Size = new System.Drawing.Size(1047, 486);
            this.clientManTabPage.TabIndex = 3;
            this.clientManTabPage.Text = "Менеджер по работе с клиентами";
            this.clientManTabPage.UseVisualStyleBackColor = true;
            // 
            // clientManPayBtn
            // 
            this.clientManPayBtn.Location = new System.Drawing.Point(340, 194);
            this.clientManPayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientManPayBtn.Name = "clientManPayBtn";
            this.clientManPayBtn.Size = new System.Drawing.Size(343, 63);
            this.clientManPayBtn.TabIndex = 7;
            this.clientManPayBtn.Text = "Оплатить заказ";
            this.clientManPayBtn.UseVisualStyleBackColor = true;
            this.clientManPayBtn.Click += new System.EventHandler(this.ClientManPayBtn_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(8, 4);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(112, 25);
            this.clientLabel.TabIndex = 6;
            this.clientLabel.Text = "Менеджер";
            // 
            // clientListCB
            // 
            this.clientListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientListCB.FormattingEnabled = true;
            this.clientListCB.Location = new System.Drawing.Point(8, 32);
            this.clientListCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientListCB.Name = "clientListCB";
            this.clientListCB.Size = new System.Drawing.Size(1031, 33);
            this.clientListCB.TabIndex = 5;
            // 
            // clientCheckOrderStatusBtn
            // 
            this.clientCheckOrderStatusBtn.Location = new System.Drawing.Point(340, 265);
            this.clientCheckOrderStatusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientCheckOrderStatusBtn.Name = "clientCheckOrderStatusBtn";
            this.clientCheckOrderStatusBtn.Size = new System.Drawing.Size(343, 63);
            this.clientCheckOrderStatusBtn.TabIndex = 3;
            this.clientCheckOrderStatusBtn.Text = "Посмотреть статус заказа";
            this.clientCheckOrderStatusBtn.UseVisualStyleBackColor = true;
            this.clientCheckOrderStatusBtn.Click += new System.EventHandler(this.ClientCheckOrderStatusBtn_Click);
            // 
            // clientNewOrderBtn
            // 
            this.clientNewOrderBtn.Location = new System.Drawing.Point(340, 124);
            this.clientNewOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientNewOrderBtn.Name = "clientNewOrderBtn";
            this.clientNewOrderBtn.Size = new System.Drawing.Size(343, 63);
            this.clientNewOrderBtn.TabIndex = 2;
            this.clientNewOrderBtn.Text = "Оформить заказ";
            this.clientNewOrderBtn.UseVisualStyleBackColor = true;
            this.clientNewOrderBtn.Click += new System.EventHandler(this.ClientNewOrderBtn_Click);
            // 
            // storkeeperTabPage
            // 
            this.storkeeperTabPage.Controls.Add(this.skLabel);
            this.storkeeperTabPage.Controls.Add(this.skListCB);
            this.storkeeperTabPage.Controls.Add(this.skNewLotBtn);
            this.storkeeperTabPage.Controls.Add(this.skNewProductBtn);
            this.storkeeperTabPage.Location = new System.Drawing.Point(4, 34);
            this.storkeeperTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storkeeperTabPage.Name = "storkeeperTabPage";
            this.storkeeperTabPage.Size = new System.Drawing.Size(1047, 486);
            this.storkeeperTabPage.TabIndex = 2;
            this.storkeeperTabPage.Text = "Кладовщик";
            this.storkeeperTabPage.UseVisualStyleBackColor = true;
            // 
            // skLabel
            // 
            this.skLabel.AutoSize = true;
            this.skLabel.Location = new System.Drawing.Point(8, 4);
            this.skLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skLabel.Name = "skLabel";
            this.skLabel.Size = new System.Drawing.Size(117, 25);
            this.skLabel.TabIndex = 6;
            this.skLabel.Text = "Кладовщик";
            // 
            // skListCB
            // 
            this.skListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skListCB.FormattingEnabled = true;
            this.skListCB.Location = new System.Drawing.Point(8, 32);
            this.skListCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skListCB.Name = "skListCB";
            this.skListCB.Size = new System.Drawing.Size(1031, 33);
            this.skListCB.TabIndex = 5;
            // 
            // skNewLotBtn
            // 
            this.skNewLotBtn.Location = new System.Drawing.Point(340, 265);
            this.skNewLotBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skNewLotBtn.Name = "skNewLotBtn";
            this.skNewLotBtn.Size = new System.Drawing.Size(343, 63);
            this.skNewLotBtn.TabIndex = 5;
            this.skNewLotBtn.Text = "Оформить доставку";
            this.skNewLotBtn.UseVisualStyleBackColor = true;
            this.skNewLotBtn.Click += new System.EventHandler(this.SkNewLotBtn_Click);
            // 
            // skNewProductBtn
            // 
            this.skNewProductBtn.Location = new System.Drawing.Point(340, 124);
            this.skNewProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skNewProductBtn.Name = "skNewProductBtn";
            this.skNewProductBtn.Size = new System.Drawing.Size(343, 63);
            this.skNewProductBtn.TabIndex = 3;
            this.skNewProductBtn.Text = "Оформить новый товар";
            this.skNewProductBtn.UseVisualStyleBackColor = true;
            this.skNewProductBtn.Click += new System.EventHandler(this.SkNewProductBtn_Click);
            // 
            // accountantTabPage
            // 
            this.accountantTabPage.Controls.Add(this.acLabel);
            this.accountantTabPage.Controls.Add(this.acListCB);
            this.accountantTabPage.Controls.Add(this.acCostsInfoBtn);
            this.accountantTabPage.Controls.Add(this.acProviderPaymentBtn);
            this.accountantTabPage.Controls.Add(this.acPaymentInfoBtn);
            this.accountantTabPage.Location = new System.Drawing.Point(4, 34);
            this.accountantTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountantTabPage.Name = "accountantTabPage";
            this.accountantTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountantTabPage.Size = new System.Drawing.Size(1047, 486);
            this.accountantTabPage.TabIndex = 1;
            this.accountantTabPage.Text = "Бухгалтер";
            this.accountantTabPage.UseVisualStyleBackColor = true;
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(8, 4);
            this.acLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(107, 25);
            this.acLabel.TabIndex = 9;
            this.acLabel.Text = "Бухгалтер";
            // 
            // acListCB
            // 
            this.acListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acListCB.FormattingEnabled = true;
            this.acListCB.Location = new System.Drawing.Point(8, 32);
            this.acListCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acListCB.Name = "acListCB";
            this.acListCB.Size = new System.Drawing.Size(1027, 33);
            this.acListCB.TabIndex = 8;
            // 
            // acCostsInfoBtn
            // 
            this.acCostsInfoBtn.Location = new System.Drawing.Point(340, 265);
            this.acCostsInfoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acCostsInfoBtn.Name = "acCostsInfoBtn";
            this.acCostsInfoBtn.Size = new System.Drawing.Size(343, 63);
            this.acCostsInfoBtn.TabIndex = 7;
            this.acCostsInfoBtn.Text = "Формировать накладные";
            this.acCostsInfoBtn.UseVisualStyleBackColor = true;
            this.acCostsInfoBtn.Click += new System.EventHandler(this.AcCostsInfoBtn_Click);
            // 
            // acProviderPaymentBtn
            // 
            this.acProviderPaymentBtn.Location = new System.Drawing.Point(340, 194);
            this.acProviderPaymentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acProviderPaymentBtn.Name = "acProviderPaymentBtn";
            this.acProviderPaymentBtn.Size = new System.Drawing.Size(343, 63);
            this.acProviderPaymentBtn.TabIndex = 6;
            this.acProviderPaymentBtn.Text = "Оплатить заказ поставщикам";
            this.acProviderPaymentBtn.UseVisualStyleBackColor = true;
            this.acProviderPaymentBtn.Click += new System.EventHandler(this.AcProviderPaymentBtn_Click);
            // 
            // acPaymentInfoBtn
            // 
            this.acPaymentInfoBtn.Location = new System.Drawing.Point(340, 124);
            this.acPaymentInfoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acPaymentInfoBtn.Name = "acPaymentInfoBtn";
            this.acPaymentInfoBtn.Size = new System.Drawing.Size(343, 63);
            this.acPaymentInfoBtn.TabIndex = 5;
            this.acPaymentInfoBtn.Text = "Информация об облатах";
            this.acPaymentInfoBtn.UseVisualStyleBackColor = true;
            this.acPaymentInfoBtn.Click += new System.EventHandler(this.AcPaymentInfoBtn_Click);
            // 
            // purchaseManTabPage
            // 
            this.purchaseManTabPage.Controls.Add(this.purcManLabel);
            this.purchaseManTabPage.Controls.Add(this.purcManListCB);
            this.purchaseManTabPage.Controls.Add(this.purcProductInfoBtn);
            this.purchaseManTabPage.Controls.Add(this.purcCheckOrderStateBtn);
            this.purchaseManTabPage.Controls.Add(this.purcNewProductBtn);
            this.purchaseManTabPage.Location = new System.Drawing.Point(4, 34);
            this.purchaseManTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseManTabPage.Name = "purchaseManTabPage";
            this.purchaseManTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseManTabPage.Size = new System.Drawing.Size(1047, 486);
            this.purchaseManTabPage.TabIndex = 0;
            this.purchaseManTabPage.Text = "Менеджер по закупкам";
            this.purchaseManTabPage.UseVisualStyleBackColor = true;
            // 
            // purcManLabel
            // 
            this.purcManLabel.AutoSize = true;
            this.purcManLabel.Location = new System.Drawing.Point(8, 4);
            this.purcManLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purcManLabel.Name = "purcManLabel";
            this.purcManLabel.Size = new System.Drawing.Size(112, 25);
            this.purcManLabel.TabIndex = 4;
            this.purcManLabel.Text = "Менеджер";
            // 
            // purcManListCB
            // 
            this.purcManListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purcManListCB.FormattingEnabled = true;
            this.purcManListCB.Location = new System.Drawing.Point(8, 32);
            this.purcManListCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purcManListCB.Name = "purcManListCB";
            this.purcManListCB.Size = new System.Drawing.Size(1027, 33);
            this.purcManListCB.TabIndex = 3;
            // 
            // purcProductInfoBtn
            // 
            this.purcProductInfoBtn.Location = new System.Drawing.Point(340, 265);
            this.purcProductInfoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purcProductInfoBtn.Name = "purcProductInfoBtn";
            this.purcProductInfoBtn.Size = new System.Drawing.Size(343, 63);
            this.purcProductInfoBtn.TabIndex = 2;
            this.purcProductInfoBtn.Text = "Состояние склада";
            this.purcProductInfoBtn.UseVisualStyleBackColor = true;
            this.purcProductInfoBtn.Click += new System.EventHandler(this.PurcProductInfoBtn_Click);
            // 
            // purcCheckOrderStateBtn
            // 
            this.purcCheckOrderStateBtn.Location = new System.Drawing.Point(340, 194);
            this.purcCheckOrderStateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purcCheckOrderStateBtn.Name = "purcCheckOrderStateBtn";
            this.purcCheckOrderStateBtn.Size = new System.Drawing.Size(343, 63);
            this.purcCheckOrderStateBtn.TabIndex = 1;
            this.purcCheckOrderStateBtn.Text = "Посмотреть состояние заказа";
            this.purcCheckOrderStateBtn.UseVisualStyleBackColor = true;
            this.purcCheckOrderStateBtn.Click += new System.EventHandler(this.PurcCheckOrderStateBtn_Click);
            // 
            // purcNewProductBtn
            // 
            this.purcNewProductBtn.Location = new System.Drawing.Point(340, 124);
            this.purcNewProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purcNewProductBtn.Name = "purcNewProductBtn";
            this.purcNewProductBtn.Size = new System.Drawing.Size(343, 63);
            this.purcNewProductBtn.TabIndex = 0;
            this.purcNewProductBtn.Text = "Заказать товар";
            this.purcNewProductBtn.UseVisualStyleBackColor = true;
            this.purcNewProductBtn.Click += new System.EventHandler(this.PurcNewProductBtn_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.purchaseManTabPage);
            this.mainTabControl.Controls.Add(this.accountantTabPage);
            this.mainTabControl.Controls.Add(this.storkeeperTabPage);
            this.mainTabControl.Controls.Add(this.clientManTabPage);
            this.mainTabControl.Controls.Add(this.courierTabPage);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTabControl.Location = new System.Drawing.Point(11, 78);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1055, 524);
            this.mainTabControl.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Location = new System.Drawing.Point(11, 609);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusBar.Name = "statusBar";
            this.statusBar.ReadOnly = true;
            this.statusBar.Size = new System.Drawing.Size(1044, 34);
            this.statusBar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            this.отчётToolStripMenuItem.Click += new System.EventHandler(this.ОтчётToolStripMenuItem_Click);
            // 
            // courierDeliverBtn
            // 
            this.courierDeliverBtn.Location = new System.Drawing.Point(340, 194);
            this.courierDeliverBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courierDeliverBtn.Name = "courierDeliverBtn";
            this.courierDeliverBtn.Size = new System.Drawing.Size(343, 63);
            this.courierDeliverBtn.TabIndex = 4;
            this.courierDeliverBtn.Text = "Доставить заказ";
            this.courierDeliverBtn.UseVisualStyleBackColor = true;
            this.courierDeliverBtn.Click += new System.EventHandler(this.CourierDeliverBtn_Click);
            // 
            // courierListCB
            // 
            this.courierListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courierListCB.FormattingEnabled = true;
            this.courierListCB.Location = new System.Drawing.Point(8, 32);
            this.courierListCB.Margin = new System.Windows.Forms.Padding(4);
            this.courierListCB.Name = "courierListCB";
            this.courierListCB.Size = new System.Drawing.Size(1031, 33);
            this.courierListCB.TabIndex = 5;
            // 
            // courierLabel
            // 
            this.courierLabel.AutoSize = true;
            this.courierLabel.Location = new System.Drawing.Point(8, 4);
            this.courierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courierLabel.Name = "courierLabel";
            this.courierLabel.Size = new System.Drawing.Size(76, 25);
            this.courierLabel.TabIndex = 6;
            this.courierLabel.Text = "Курьер";
            // 
            // courierTabPage
            // 
            this.courierTabPage.Controls.Add(this.courierLabel);
            this.courierTabPage.Controls.Add(this.courierListCB);
            this.courierTabPage.Controls.Add(this.courierDeliverBtn);
            this.courierTabPage.Location = new System.Drawing.Point(4, 34);
            this.courierTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.courierTabPage.Name = "courierTabPage";
            this.courierTabPage.Size = new System.Drawing.Size(1047, 486);
            this.courierTabPage.TabIndex = 4;
            this.courierTabPage.Text = "Курьер";
            this.courierTabPage.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 654);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.clientManTabPage.ResumeLayout(false);
            this.clientManTabPage.PerformLayout();
            this.storkeeperTabPage.ResumeLayout(false);
            this.storkeeperTabPage.PerformLayout();
            this.accountantTabPage.ResumeLayout(false);
            this.accountantTabPage.PerformLayout();
            this.purchaseManTabPage.ResumeLayout(false);
            this.purchaseManTabPage.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.courierTabPage.ResumeLayout(false);
            this.courierTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TabPage clientManTabPage;
        private System.Windows.Forms.Button clientCheckOrderStatusBtn;
        private System.Windows.Forms.Button clientNewOrderBtn;
        private System.Windows.Forms.TabPage storkeeperTabPage;
        private System.Windows.Forms.Button skNewLotBtn;
        private System.Windows.Forms.Button skNewProductBtn;
        private System.Windows.Forms.TabPage accountantTabPage;
        private System.Windows.Forms.Button acCostsInfoBtn;
        private System.Windows.Forms.Button acProviderPaymentBtn;
        private System.Windows.Forms.Button acPaymentInfoBtn;
        private System.Windows.Forms.TabPage purchaseManTabPage;
        private System.Windows.Forms.Button purcProductInfoBtn;
        private System.Windows.Forms.Button purcCheckOrderStateBtn;
        private System.Windows.Forms.Button purcNewProductBtn;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Label purcManLabel;
        public System.Windows.Forms.ComboBox purcManListCB;
        private System.Windows.Forms.Label clientLabel;
        public System.Windows.Forms.ComboBox clientListCB;
        private System.Windows.Forms.Label skLabel;
        public System.Windows.Forms.ComboBox skListCB;
        private System.Windows.Forms.Label acLabel;
        public System.Windows.Forms.ComboBox acListCB;
        public System.Windows.Forms.TextBox statusBar;
        private System.Windows.Forms.Button clientManPayBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage courierTabPage;
        private System.Windows.Forms.Label courierLabel;
        public System.Windows.Forms.ComboBox courierListCB;
        private System.Windows.Forms.Button courierDeliverBtn;
    }
}

