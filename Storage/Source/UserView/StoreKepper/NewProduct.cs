using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.Shopkeeper;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class UserView
    {
        NewProductForm newSkProduct;

        public void NewSkProduct(NewProductForm form)
        {
            newSkProduct = form;

            PrintProduct();
        }

        private void PrintProduct()
        {
            newSkProduct.skStorageListPanel.Controls.Clear();

            var storages = pres.GetAllStorages();

            foreach (var s in storages)
            {
                var height = 5;

                var c = newSkProduct.skStorageListPanel.Controls;
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

                rb.Click += LoadStorageGoods;

                newSkProduct.skStorageListPanel.Controls.Add(rb);
                (newSkProduct.skStorageListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadStorageGoods(object sender, EventArgs e)
        {
            newSkProduct.skReadyGoodsListPanel.Controls.Clear();

            var storageId = int.Parse((sender as RadioButton).Text.Split(' ')[1]);
            var storage = pres.GetStorageById(storageId);
            var req = pres.GetAllPurcaseReq();

            foreach (var r in req)
            {
                if (!r.IsDone || r.InStorage || r.IsDelivered || r.IsReady)
                {
                    continue;
                }

                var height = 5;

                var c = newSkProduct.skReadyGoodsListPanel.Controls;
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

                newSkProduct.skReadyGoodsListPanel.Controls.Add(cb);
            }
        }

        public List<string> GetSkCheckedReq()
        {
            var res = new List<string>();

            foreach (var c in newSkProduct.skReadyGoodsListPanel.Controls)
            {
                if ((c as CheckBox).Checked)
                {
                    res.Add((c as CheckBox).Text.Split(' ')[1]);
                }
            }

            if (res.Count == 0)
            {
                return null;
            }

            return res;
        }

        public int GetStorageId()
        {
            var id = -1;
            foreach (var c in newSkProduct.skStorageListPanel.Controls) {
                var rb = c as RadioButton;
                if (rb.Checked)
                {
                    id = int.Parse(rb.Text.ToString().Split(' ')[1]);
                }
            }

            return id;
        }

        public int GetSkId()
        {
            var id = mainMenu.skListCB.SelectedItem.ToString().Split(' ')[1];

            return int.Parse(id);
        }

    }
}
