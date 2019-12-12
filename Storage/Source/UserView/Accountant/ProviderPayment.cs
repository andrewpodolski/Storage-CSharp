using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.Accountant;

namespace Storage.Source
{
    partial class UserView
    {
        ProviderPaymentForm providerPayment;

        public void ProviderPayment(ProviderPaymentForm form)
        {
            providerPayment = form;

            PrintProviders();
        }

        private void PrintProviders()
        {
            providerPayment.acProviderListPanel.Controls.Clear();

            var from = Enum.GetNames(typeof(FromType));

            foreach (var f in from)
            {
                var height = 5;

                var c = providerPayment.acProviderListPanel.Controls;
                if (c.Count > 0)
                {
                    height =
                        c[c.Count - 1].Location.Y
                        + c[c.Count - 1].Size.Height;
                }

                var rb = new RadioButton
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(5, height),

                    Text = String.Format(f)
                };

                rb.Click += LoadReqInfo;

                providerPayment.acProviderListPanel.Controls.Add(rb);
                (providerPayment.acProviderListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadReqInfo(object sender, EventArgs e)
        {
            providerPayment.acReqListPanel.Controls.Clear();

            Enum.TryParse((sender as RadioButton).Text, out FromType from);

            var req = pres.GetReqsFrom(from);

            for (var i = 0; i < req.Count; i++)
            {
                if (req[i].IsDone)
                {
                    continue;
                }

                var height = 5;

                if (i > 0)
                {
                    height =
                        providerPayment.acReqListPanel.Controls[i - 1]
                            .Location.Y + providerPayment.acReqListPanel.Controls[i - 1]
                                .Size.Height;
                }

                var rb = new RadioButton
                {
                    AutoSize = true,
                    Location
                    = new System.Drawing.Point
                    (
                        5,
                        height
                    ),

                    Text = string.Format(req[i].ToString())
                };

                providerPayment.acReqListPanel.Controls.Add(rb);
                providerPayment.acReqListPanel.Controls[0].Select();
            }
        }

        public int GetReqId()
        {
            RadioButton rb = null;

            foreach (RadioButton r in providerPayment.acReqListPanel.Controls)
            {
                if (r.Checked)
                {
                    rb = r;
                    break;
                }
            }

            if (rb == null)
            {
                return -1;
            }

            var id = rb.Text.Split(' ')[1];

            return int.Parse(id);
        }

        public int GetAccountantId()
        {
            var id = mainMenu.acListCB.SelectedItem.ToString().Split(' ')[1];

            return int.Parse(id);
        }
    }
}
