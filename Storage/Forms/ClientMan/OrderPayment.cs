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

namespace Storage.Forms.ClientMan
{
    public partial class OrderPaymentForm : Form
    {
        private readonly Presenter pres;

        public OrderPaymentForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            pres.OrderPay();
        }
    }
}
