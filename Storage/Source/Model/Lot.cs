using System.Collections.Generic;

using Storage.Source.Entity;

namespace Storage.Source
{
    partial class Model
    {
        public List<Lot> GetToDeliverListByReqId(int id)
        {
            return db.toDeliver.FindAll(x => x.ReqId == id);
        }

        public void AddToDeliverList(Lot lot)
        {
            db.toDeliver.Add(lot);
        }

        public List<Lot> GetLotsByClientId (int clientId)
        {
            return db.toDeliver.FindAll(l => GetOrderReqById(l.ReqId).UserId == clientId);
        }
    }
}
