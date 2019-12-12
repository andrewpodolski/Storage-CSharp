using System;
using System.Collections.Generic;

using Storage.Forms.Shopkeeper;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void NewLot(NewLotForm form)
        {
            view.NewLot(form);
        }

        public void AddLot()
        {
            var storage = model.GetStorageById(view.GetLotStorageId());
            if (storage.Goods.Count < 1)
            {
                view.ShowMessage("Склад путой / не выбран.");
                return;
            }

            var req = model.GetOrderReqById(view.GetLotReqId());
            if (req.GoodsCount < 1)
            {
                view.ShowMessage("Запрос путой / не выбран.");
                return;
            }

            var goods = new List<Goods>();
            var deleted = new List<Goods>();

            foreach (var g in req.ReqGoods)
            {
                var first = g.StringToCompare();
                Goods toDelete = null;
                foreach (var sg in storage.Goods)
                {
                    var second = sg.StringToCompare();
                    if (first.Equals(second))
                    {
                        goods.Add(g);
                        deleted.Add(sg);
                        toDelete = sg;
                        break;
                    }
                }
                if (toDelete == null)
                {
                    break;
                }

                storage.Goods.Remove(toDelete);
            }

            if (goods.Count == req.GoodsCount)
            {
                var message = "Товар отправлен в партию: " + req.ToString();
                model.AddIncome(message);

                var log = new Log(view.GetSkId(), "Add goods lot.");
                model.AddLog(LogType.Shopkeeper, log);

                model.SetOrderReqReady(req);
                var lot = new Lot(view.GetLotReqId(), goods);
                model.AddToDeliverList(lot);
                view.ShowMessage("Партия создана.");
                return;
            }

            storage.Goods.AddRange(deleted);
            view.ShowMessage("На складе не хватает товаров для создания партии данного запроса.");
        }
    }
}
