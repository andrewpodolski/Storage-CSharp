using System;
using System.Windows.Forms;

using Storage.Forms.PurcaseMan;

namespace Storage.Source
{ 
    partial class UserView
    {
        ProductInfoForm goodsInfo;

        public void GoodsInfo(ProductInfoForm form)
        {
            goodsInfo = form;

            PrintStorage();
        }

        private void PrintStorage()
        {
            goodsInfo.storeListPanel.Controls.Clear();

            var storages = pres.GetAllStorages();

            foreach (var s in storages)
            {
                var height = 5;

                var c = goodsInfo.storeListPanel.Controls;
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

                rb.Click += LoadStorageInfo;

                goodsInfo.storeListPanel.Controls.Add(rb);
                (goodsInfo.storeListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadStorageInfo(object sender, EventArgs e)
        {
            goodsInfo.storInfoPanel.Controls.Clear();

            var storeId = int.Parse((sender as RadioButton).Text.Split(' ')[1]);

            var store = pres.GetStorageById(storeId);

            var label = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(5, 5),
                Text = store.ToString()
            };

            goodsInfo.storInfoPanel.Controls.Add(label);
        }

    }
}
