using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Storage.Forms.Accountant;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        public void PaymentInfo(PaymentInfoForm form)
        {
            view.PaymentInfo(form);
        }

        public List<Request> GetClintsReq()
        {
            return model.GetAllOrderReq();
        }
    }
}
