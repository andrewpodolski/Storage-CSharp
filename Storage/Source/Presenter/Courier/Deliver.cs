using System;
using System.Collections.Generic;

using Storage.Forms.Courier;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class Presenter
    {
        public void Deliver(DeliverForm form)
        {
            view.Deliver(form);
        }

        public List<Lot> GetLotsByClientId(int clientId)
        {
            return model.GetLotsByClientId(clientId);
        }

        public void CourierDeliver()
        {
            var reqIdList = view.GetDelReqId();

            foreach (var id in reqIdList)
            {
                model.GetOrderReqById(id).IsDelivered = true;

                var log = new Log(view.GetCourierId(), "Delivered order: Id - " + id);
                model.AddLog(LogType.Courier, log);
            }

            view.ShowMessage("Заказ доставлен.");
        }
    }
}
