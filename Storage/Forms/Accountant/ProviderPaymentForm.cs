using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Storage.Source;

namespace Storage.Forms.Accountant
{
    public partial class ProviderPaymentForm : Form
    {
        Presenter pres;

        public ProviderPaymentForm(object pres)
        {
            InitializeComponent();

            this.pres = pres as Presenter;
        }

        private void AcPayReqBtn_Click(object sender, EventArgs e)
        {
            pres.PayProvider();
        }
    }
}
