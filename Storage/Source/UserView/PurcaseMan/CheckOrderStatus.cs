using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.PurcaseMan;

namespace Storage.Source
{
    partial class UserView
    {
        CheckOrderStateForm checkOrder;

        public void CheckOrder(CheckOrderStateForm form)
        {
            checkOrder = form;

            PrintOrders();
        }

        private void PrintOrders()
        {
            checkOrder.purcOrderListPanel.Controls.Clear();

            var req = pres.GetAllPurcaseReq();

            foreach (var r in req)
            {
                var height = 5;

                var c = checkOrder.purcOrderListPanel.Controls;
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

                rb.Click += LoadPurcaseReqInfo;

                checkOrder.purcOrderListPanel.Controls.Add(rb);
            }
        }

        private void LoadPurcaseReqInfo(object sender, EventArgs e)
        {
            checkOrder.purcOrderInfoPanel.Controls.Clear();

            var reqId = int.Parse((sender as RadioButton).Text.Split(' ')[1]);

            var req = pres.GetPurcaseReqById(reqId);

            var label = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(5, 5),
                Text = req.ToString()
            };

            checkOrder.purcOrderInfoPanel.Controls.Add(label);
        }
    }
}
