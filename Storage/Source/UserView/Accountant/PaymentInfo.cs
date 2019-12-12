using System;
using System.Windows.Forms;

using Storage.Forms.Accountant;

namespace Storage.Source
{
    partial class UserView
    {
        PaymentInfoForm paymentInfo;

        public void PaymentInfo(PaymentInfoForm form)
        {
            paymentInfo = form;

            PrintPaymentInfo();
        }

        private void PrintPaymentInfo()
        {
            paymentInfo.reqListPanel.Controls.Clear();

            var req = pres.GetClintsReq();

            foreach (var r in req)
            {
                var height = 5;

                var c = paymentInfo.reqListPanel.Controls;
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

                    Text = string.Format(r.ShortInfo())
                };

                rb.Click += LoadClinetReqInfo;

                paymentInfo.reqListPanel.Controls.Add(rb);
                (paymentInfo.reqListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadClinetReqInfo(object sender, EventArgs e)
        {
            paymentInfo.reqInfoPanel.Controls.Clear();

            var reqId = Int32.Parse((sender as RadioButton).Text.Split(' ')[1]);
            var req = pres.GetOrderReqById(reqId);

            var label = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(5,5),

                Text = string.Format(req.ToString())
            };

            paymentInfo.reqInfoPanel.Controls.Add(label);
        }
    }
}
