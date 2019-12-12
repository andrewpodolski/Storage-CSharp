using System;
using System.Windows.Forms;

using Storage.Forms.ClientMan;
using Storage.Source.Entity.Users;

namespace Storage.Source
{
    partial class UserView
    {
        OrderInfoForm ordersInfo;

        public void OrdersInfo(OrderInfoForm form)
        {
            ordersInfo = form;

            PrintClient();
        }

        private void PrintClient()
        {
            ordersInfo.clientListLabel.Controls.Clear();

            var users = pres.GetAllClients();

            foreach (var u in users)
            {
                var height = 5;

                var c = ordersInfo.clientListLabel.Controls;
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

                    Text = string.Format(u.ToString())
                };

                rb.Click += LoadOrderInfo;

                ordersInfo.clientListLabel.Controls.Add(rb);
                (ordersInfo.clientListLabel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadOrderInfo(object sender, EventArgs e)
        {
            ordersInfo.clientInfoListPanel.Controls.Clear();

            var userId = Int32.Parse((sender as RadioButton).Text.Split(' ')[1]);
            var req = pres.GetOrdersReqByUserId(userId);

            foreach (var r in req)
            {
                var height = 5;

                var c = ordersInfo.clientInfoListPanel.Controls;
                if (c.Count > 0)
                {
                    height =
                        c[c.Count - 1].Location.Y
                        + c[c.Count - 1].Size.Height;
                }

                var label = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(5, height),
                    Text = string.Format(r.ToString())
                };

                ordersInfo.clientInfoListPanel.Controls.Add(label);
            }
        }

    }
}
