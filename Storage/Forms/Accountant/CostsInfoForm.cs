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
    public partial class CostsInfoForm : Form
    {
        Presenter pres;
        public CostsInfoForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();
        }

        private void Income_CheckedChanged(object sender, EventArgs e)
        {
            pres.ShowIncome(this);
        }

        private void Costs_CheckedChanged(object sender, EventArgs e)
        {
            pres.ShowCosts(this);
        }
    }
}
