using System;
using System.Collections.Generic;

using Storage.Forms.Shopkeeper;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void NewSkProduct(NewProductForm form)
        {
            view.NewSkProduct(form);
        }

        public void AddToStorage()
        {
            var checkedReqId = view.GetSkCheckedReq();

            if (checkedReqId == null)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            foreach (var c in checkedReqId)
            {
                var id = int.Parse(c);
                var req = model.GetPurchaseReqById(id);

                if (req == null)
                {
                    continue;
                }

                req.InStorage = true;
                var s = model.GetStorageById(view.GetStorageId());

                var message = "Добавлен товар: " + req.ToString();
                model.AddIncome(message);

                var log = new Log(view.GetSkId(), "Add product to store: Id - " + id);
                model.AddLog(LogType.Shopkeeper, log);

                foreach (var g in req.ReqGoods)
                {
                    s.ComeDate = DateTime.Now.ToString();
                    s.Goods.Add(g);
                }
            }

            view.ShowMessage("Товар добавлен на склад.");
        }
    }
}
