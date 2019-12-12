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

namespace Storage.Forms.Courier
{
    public partial class DeliverForm : Form
    {
        Presenter pres;
        public DeliverForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void DeliverBtn_Click(object sender, EventArgs e)
        {
            pres.CourierDeliver();
        }
    }
}
