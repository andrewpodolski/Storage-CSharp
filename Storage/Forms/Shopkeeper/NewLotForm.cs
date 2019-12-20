using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using Storage.Source;

namespace Storage.Forms.Shopkeeper
{
    public partial class NewLotForm : Form
    {
        private readonly Presenter pres;

        public NewLotForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void AddLotBtn_Click(object sender, EventArgs e)
        {
            pres.AddLot();
        }
    }
}
