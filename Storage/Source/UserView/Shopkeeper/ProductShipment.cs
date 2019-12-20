using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.Shopkeeper;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class UserView
    {
        NewLotForm newLot;

        public void NewLot(NewLotForm form)
        {
            newLot = form;

            PrintLotStorages();
            PrintLotReq();
        }

        private void PrintLotStorages()
        {
            newLot.storageListPanel.Controls.Clear();

            var storages = pres.GetAllStorages();

            foreach (var s in storages)
            {
                var height = 5;

                var c = newLot.storageListPanel.Controls;
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

                    Text = String.Format(s.ShortInfo())
                };

                newLot.storageListPanel.Controls.Add(rb);
                (newLot.storageListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void PrintLotReq()
        {
            newLot.reqList.Controls.Clear();

            var req = pres.GetAllAcceptedOrderReq();

            foreach (var r in req)
            {
                var height = 5;

                var c = newLot.reqList.Controls;
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

                    Text = string.Format(r.ToString())
                };

                newLot.reqList.Controls.Add(rb);
                (newLot.reqList.Controls[0] as RadioButton).Checked = true;
            }
        }

        public int GetLotStorageId()
        {
            var id = -1;
            foreach (var c in newLot.storageListPanel.Controls)
            {
                var rb = c as RadioButton;
                if (rb.Checked)
                {
                    id = int.Parse(rb.Text.ToString().Split(' ')[1]);
                }
            }

            return id;
        }

        public int GetLotReqId()
        {
            var id = -1;
            foreach (var c in newLot.reqList.Controls)
            {
                var rb = c as RadioButton;
                if (rb.Checked)
                {
                    id = int.Parse(rb.Text.ToString().Split(' ')[1]);
                }
            }

            return id;
        }
    }
}
