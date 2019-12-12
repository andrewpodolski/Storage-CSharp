using System.Collections.Generic;

using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Model
    {
        public void AddOrderReq(Request req)
        {
            db.AddOrdersReq(req);
        }

        public List<Request> GetAllOrderReq()
        {
            return db.ordersReq;
        }

        public Request GetOrderReqById(int id)
        {
            return db.ordersReq.Find(x => x.Id == id);
        }

        public List<Request> GetOrdersReqByUserId(int userId)
        {
            return db.ordersReq.FindAll(x => x.UserId == userId);
        }

        public List<Request> GetAllAcceptedOrderReq()
        {
            return db.ordersReq.FindAll(x => x.IsDone);
        }

        public void SetOrderReqReady(Request req)
        {
            GetOrderReqById(req.Id).IsReady = true;
        }
    }
}
