using System.Collections.Generic;

using Storage.Source.Entity.Users;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    partial class Presenter
    {
        private readonly Model model;
        public UserView view;

        public Presenter()
        {
            model = new Model();
            view = new UserView(this);
        }

        public List<User> GetAllUsers()
        {
            return model.GetAllUsers();
        }

        public List<Request> GetAllPurcaseReq()
        {
            return model.GetAllPurchaseReq();
        }

        public List<Request> GetAllOrderReq()
        {
            return model.GetAllOrderReq();
        }

        public Request GetOrderReqById(int id)
        {
            return model.GetOrderReqById(id);
        }

        public Request GetPurcaseReqById(int id)
        {
            return model.GetPurchaseReqById(id);
        }

        public List<Entity.Storage> GetAllStorages()
        {
            return model.GetAllStorages();
        }

        public Entity.Storage GetStorageById(int id)
        {
            return model.GetStorageById(id);
        }

        public List<User> GetAllClients()
        {
            return model.GetAllClients();
        }

        public List<Request> GetAllAcceptedOrderReq()
        {
            return model.GetAllAcceptedOrderReq();
        }

        public List<Request> GetOrdersReqByUserId(int id)
        {
            return model.GetOrdersReqByUserId(id);
        } 

        public List<Request> GetPurcaseReqByType (GoodsType type)
        {
            return model.GetPurcaseReqByType(type);
        }

        public List<Request> GetPurcaseReqByUserId(int id)
        {
            return model.GetPurcaseReqByUserId(id);
        }

        public void DelPurcaseReq(Request req)
        {
            model.DelPurcaseReq(req);
        }
    }
}
