using System;
using System.Collections.Generic;

using Storage.Forms.ClientMan;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void NewOrder(NewOrderForm form)
        {
            view.NewOrder(form);
        }

        public List<Goods> GetGoodsByType(GoodsType goodsType)
        {
            return model.GetGoodsByType(goodsType);
        }

        public Goods GetGoodsById(int id)
        {
            return model.GetGoodsById(id);
        }

        public void AddOrder()
        {
            var checkedGoods = view.GetCheckedOrderGoods();
            if (checkedGoods == null)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            if (checkedGoods.Count == 0)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            var req = new Request(view.GetClientManId(), checkedGoods);
            model.AddOrderReq(req);

            var log = new Log(view.GetClientManId(), "Make order.");
            model.AddLog(LogType.ClientMan, log);

            view.ShowMessage("Товар заказан.");
        }
    }
}
