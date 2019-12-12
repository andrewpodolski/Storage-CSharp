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

namespace Storage.Forms
{
    public partial class LogsForm : Form
    {
        Presenter pres;

        public LogsForm(object pres)
        {
            this.pres = pres as Presenter;
            InitializeComponent();

            parametrs.SelectedIndex = 0;
        }

        private void Write_Click(object sender, EventArgs e)
        {
            pres.Logs(parametrs.SelectedIndex);
        }
    }
}
