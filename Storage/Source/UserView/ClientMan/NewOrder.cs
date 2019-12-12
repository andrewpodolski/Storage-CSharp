using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.ClientMan;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class UserView
    {
        NewOrderForm newOrder;

        public void NewOrder(NewOrderForm form)
        {
            newOrder = form;

            PrintFoodType();
        }

        private void PrintFoodType()
        {
            newOrder.clientGoodsTypeListPanel.Controls.Clear();

            var goods = Enum.GetNames(typeof(GoodsType));

            foreach (var g in goods)
            {
                var height = 5;

                var c = newOrder.clientGoodsTypeListPanel.Controls;
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

                    Text = String.Format(g == "Industrial" ? "Промышленные" : "Продовольственные")
                };

                rb.Click += LoadGoods;

                newOrder.clientGoodsTypeListPanel.Controls.Add(rb);
                (newOrder.clientGoodsTypeListPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadGoods(object sender, EventArgs e)
        {
            newOrder.clientGoodsListPanel.Controls.Clear();
            var goodsTxt = (sender as RadioButton).Text == "Промышленные" ? "Industrial" : "Food";

            Enum.TryParse(goodsTxt, out GoodsType goodsType);

            var goods = pres.GetGoodsByType(goodsType);

            foreach (var g in goods)
            {
                var height = 5;

                var c = newOrder.clientGoodsListPanel.Controls;
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

                    Text = string.Format(g.ToString())
                };

                newOrder.clientGoodsListPanel.Controls.Add(cb);
            }
        }

        public List<Goods> GetCheckedOrderGoods()
        {
            var res = new List<Goods>();

            foreach (var c in newOrder.clientGoodsListPanel.Controls)
            {
                if ((c as CheckBox).Checked)
                {
                    var id = int.Parse((c as CheckBox).Text.Split(' ')[1]);
                    res.Add(pres.GetGoodsById(id));
                }
            }

            if (res.Count == 0)
            {
                return null;
            }

            return res;
        }

        public int GetClientManId()
        {
            var id = mainMenu.clientListCB.SelectedItem.ToString().Split(' ')[1];

            return int.Parse(id);
        }
    }
}
