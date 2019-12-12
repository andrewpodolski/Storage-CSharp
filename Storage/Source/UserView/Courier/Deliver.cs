using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.Courier;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class UserView
    {
        DeliverForm deliver;

        public void Deliver(DeliverForm form)
        {
            deliver = form;

            PrintDelClients();
        }

        private void PrintDelClients()
        {
            deliver.delClientList.Controls.Clear();

            var clients = pres.GetAllClients();

            foreach (var cl in clients)
            {
                var height = 5;

                var c = deliver.delClientList.Controls;
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

                rb.Click += LoadDel;

                deliver.delClientList.Controls.Add(rb);
                (deliver.delClientList.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadDel(object sender, EventArgs e)
        {
            deliver.delGoodsList.Controls.Clear();
            var clientId = int.Parse((sender as RadioButton).Text.Split(' ')[1]);

            var lots = pres.GetLotsByClientId(clientId);

            foreach (var l in lots)
            {
                var req = pres.GetOrderReqById(l.ReqId);
                if (req.IsDelivered || !req.InStorage || !req.IsReady)
                {
                    continue;
                }

                var height = 5;

                var c = deliver.delGoodsList.Controls;
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

                    Text = string.Format(l.ToString())
                };

                deliver.delGoodsList.Controls.Add(cb);
            }
        }

        public int GetCourierId()
        {
            var id = mainMenu.courierListCB.SelectedItem.ToString().Split(' ')[1];

            return int.Parse(id);
        }

        public int GetDelClientId()
        {
            foreach (var c in deliver.delClientList.Controls)
            {
                var rb = (c as RadioButton);
                if (rb.Checked)
                {
                    return int.Parse(rb.Text.Split(' ')[1]);
                }
            }

            return -1;
        }

        public List<int> GetDelReqId()
        {
            var res = new List<int>();
            foreach (var c in deliver.delGoodsList.Controls)
            {
                var cb = (c as CheckBox);
                if (cb.Checked)
                {
                    res.Add(int.Parse(cb.Text.Split(' ')[2]));
                }
            }

            return res;
        }
    }
}
