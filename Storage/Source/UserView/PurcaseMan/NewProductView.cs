using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.PurcaseMan;

namespace Storage.Source
{
    partial class UserView
    {
        NewProductForm newProduct;

        public void NewProduct(NewProductForm form)
        {
            newProduct = form;

            PrintCustomers();
        }

        private void PrintCustomers()
        {
            newProduct.purcOrderFromPanel.Controls.Clear();

            var from = Enum.GetNames(typeof(FromType));

            foreach (var f in from)
            {
                var height = 5;

                var c = newProduct.purcOrderFromPanel.Controls;
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

                rb.Click += LoadGoodsInfo;

                newProduct.purcOrderFromPanel.Controls.Add(rb);
                (newProduct.purcOrderFromPanel.Controls[0] as RadioButton).Checked = true;
            }
        }

        private void LoadGoodsInfo(object sender, EventArgs e)
        {
            newProduct.purcOrderInfoPanel.Controls.Clear();

            Enum.TryParse((sender as RadioButton).Text, out FromType from);

            var goods = pres.GetGoodsFrom(from);

            foreach (var g in goods)
            {
                var height = 5;

                var c = newProduct.purcOrderInfoPanel.Controls;
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

                newProduct.purcOrderInfoPanel.Controls.Add(cb);
            }
        }

        public List<string> GetCheckedGoods()
        {
            var res = new List<string>();

            foreach (var c in newProduct.purcOrderInfoPanel.Controls)
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

        public int GetPurcManId()
        {
            var id = mainMenu.purcManListCB.SelectedItem.ToString().Split(' ')[1];

            return int.Parse(id);
        }
    }
}
