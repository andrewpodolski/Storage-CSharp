using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using Storage.Source;

namespace Storage.Forms.ClientMan
{
    public partial class NewOrderForm : Form
    {
        private readonly Presenter pres;

        public NewOrderForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void ClientAddOrderBtn_Click(object sender, EventArgs e)
        {
            pres.AddOrder();
        }
    }
}
