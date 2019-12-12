using System;
using System.Collections.Generic;

using Storage.Forms.PurcaseMan;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void NewProduct(NewProductForm form)
        {
            view.NewProduct(form);
        }

        public List<Goods> GetGoodsFrom(FromType from)
        {
            return model.GetGoodsFrom(from);
        }

        public void AddProduct()
        {
            var checkedGoodsId = view.GetCheckedGoods();

            if (checkedGoodsId == null)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            var goods = new List<Goods>();

            foreach (var s in checkedGoodsId)
            {
                var id = int.Parse(s);
                var product = model.GetGoodsById(id);

                if (product == null)
                {
                    continue;
                }

                goods.Add(product);
            }

            var req = new Request(view.GetPurcManId(), goods);
            model.AddPurchaseReq(req);

            var log = new Log(view.GetPurcManId(), "Product request.");
            model.AddLog(LogType.PurcaseMan, log);

            view.ShowMessage("Товар заказан.");
        }
    }
}
