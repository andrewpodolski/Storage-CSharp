using System.Collections.Generic;

using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Model
    {
        public void AddPurchaseReq(Request req)
        {
            db.AddPurchasesReq(req);
        }

        public List<Request> GetAllPurchaseReq()
        {
            return db.purchasesReq;
        }

        public Request GetPurchaseReqById (int id)
        {
            return db.purchasesReq.Find(x => x.Id == id);
        }

        public List<Request> GetReqsFrom (FromType from)
        {
            return db.purchasesReq.FindAll(x => x.ReqGoods[0].From == from);
        }

        public List<Request> GetPurcaseReqByType (GoodsType type)
        {
            return db.purchasesReq.FindAll(x => x.ReqGoods[0].Type == type);
        }

        public List<Request> GetPurcaseReqByUserId(int id)
        {
            return db.purchasesReq.FindAll(x => x.UserId == id);
        }

        public void DelPurcaseReq(Request req)
        {
            db.purchasesReq.Remove(req);
        }
    }
}
