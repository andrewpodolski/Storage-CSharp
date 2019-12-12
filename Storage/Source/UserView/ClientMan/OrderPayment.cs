using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.ClientMan;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class UserView
    {
        OrderPaymentForm orderPayment;

        public void OrderPayment(OrderPaymentForm form)
        {
            orderPayment = form;

            PrintClients();
        }

        private void PrintClients()
        {
            orderPayment.clientListPanel.Controls.Clear();

            var clients = pres.GetAllClients();

            foreach (var cl in clients)
            {
                var height = 5;

                var c = orderPayment.clientListPanel.Controls;
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

                    Text = String.Format(cl.ToString())
                };

                rb.Click += LoadClientReq;

                orderPayment.clientListPanel.Controls.Add(rb);
                (orderPayment.clientListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadClientReq(object sender, EventArgs e)
        {
            orderPayment.clientOrderListPanel.Controls.Clear();

            var userId = int.Parse((sender as RadioButton).Text.Split(' ')[1]);
            var req = pres.GetOrdersReqByUserId(userId);

            foreach (var r in req)
            {
                var height = 5;

                var c = orderPayment.clientOrderListPanel.Controls;
                if (c.Count > 0)
                {
                    height =
                        c[c.Count - 1].Location.Y
                        + c[c.Count - 1].Size.Height;
                }

                var cb = new CheckBox
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(5, height),

                    Text = string.Format(r.ToString())
                };

                orderPayment.clientOrderListPanel.Controls.Add(cb);
            }
        }

        public List<Request> GetCheckedClientsOrders()
        {
            var res = new List<Request>();

            foreach (var c in orderPayment.clientOrderListPanel.Controls)
            {
                if ((c as CheckBox).Checked)
                {
                    var id = int.Parse((c as CheckBox).Text.Split(' ')[1]);
                    res.Add(pres.GetOrderReqById(id));
                }
            }

            if (res.Count == 0)
            {
                return null;
            }

            return res;
        }
    }
}
