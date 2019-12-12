using System;
using System.Windows.Forms;

using Storage.Source;

namespace Storage.Forms.Shopkeeper
{
    public partial class NewProductForm : Form
    {
        private readonly Presenter pres;

        public NewProductForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void ClientAddOrderBtn_Click(object sender, EventArgs e)
        {
            pres.AddToStorage();
        }
    }
}
