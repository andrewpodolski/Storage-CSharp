using System;
using System.Collections.Generic;

using Storage.Forms.ClientMan;
using Storage.Source.Entity;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void OrderPayment(OrderPaymentForm form)
        {
            view.OrderPayment(form);
        }

        public List<Goods> GetGoodsByClintId(GoodsType goodsType)
        {
            return model.GetGoodsByType(goodsType);
        }

        public void OrderPay()
        {
            var req = view.GetCheckedClientsOrders();

            if (req == null)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            foreach (var r in req)
            {
                if (!r.IsDone)
                {
                    r.IsDone = true;

                    var log = new Log(view.GetClientManId(), "Payed for order: Id - " + r.Id);
                    model.AddLog(LogType.ClientMan, log);
                }
                else
                {
                    view.ShowMessage("Часть заказа или весь заказ уже оплачен.");
                    return;
                }
            }


            view.ShowMessage("Заказ оплачен.");
        }
    }
}
