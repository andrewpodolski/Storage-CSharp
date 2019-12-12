using System;
using System.Collections.Generic;

using Storage.Forms.Accountant;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void ProviderPayment(ProviderPaymentForm form)
        {
            view.ProviderPayment(form);
        }

        public List<Request> GetReqsFrom(FromType from)
        {
            return model.GetReqsFrom(from);
        }

        public void PayProvider()
        {
            var reqId = view.GetReqId();

            if (reqId < 0)
            {
                view.ShowMessage("Ничего не выбрано.");
                return;
            }

            var req = model.GetPurchaseReqById(reqId);

            if (req.IsDone)
            {
                view.ShowMessage("Заказ уже оплачен.");
                return;
            }

            req.Pay();

            var log = new Log(view.GetAccountantId(), "Payed for product. Id: " + reqId);
            model.AddLog(LogType.Accountant, log);

            view.ShowMessage("Заказ оплачен.");
        }
    }
}
