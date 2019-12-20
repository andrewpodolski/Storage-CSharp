using System.Collections.Generic;
using Storage.Source.Entity;
using Storage.Source.Entity.Users;
using Storage.Source.Entity.Request;

namespace Storage.Source
{
    class DataBase
    {
        private int goodsId = 1;
        private int usersId = 1;
        private int ordersReqId = 1;
        private int purchasesReqId = 1;
        private int storageId = 1;

        public readonly List<string> income;
        public readonly List<string> costs;

        public readonly List<Goods> goods;
        public readonly List<User> users;
        public readonly List<Request> ordersReq;
        public readonly List<Request> purchasesReq;
        public readonly List<Entity.Storage> storages;
        public readonly List<Lot> toDeliver;

        public DataBase()
        {
            income = new List<string>();
            costs = new List<string>();

            goods = new List<Goods>();
            users = new List<User>();
            ordersReq = new List<Request>();
            purchasesReq = new List<Request>();
            storages = new List<Entity.Storage>();
            toDeliver = new List<Lot>();

            Init();
        }

        private void Init()
        {
            AddGoods(new Bakery("Булочка1", "1.", UnitType.Unit, false, 0.15f, 1, 1.23f, FromType.Belarus, GoodsType.Industrial));
            AddGoods(new Dairy("Булочка2", "2.", UnitType.Killogram, false, 0.15f, 1, 12.23f, FromType.Belarus, GoodsType.Food));
            AddGoods(new Meat("Булочка3", "3.", UnitType.Unit, true, 1.15f, 12, 23.23f, FromType.Belarus, GoodsType.Industrial));
            AddGoods(new Appliances("Булочка4", "4.", UnitType.Liter, false, 25f, 35, 53.23f, FromType.Germany, GoodsType.Food));
            AddGoods(new Clothes("Булочка5", "5.", UnitType.Unit, true, 43.5f, -1, 1.23f, FromType.Italy, GoodsType.Industrial));
            AddGoods(new Equipment("Булочка6", "6.", UnitType.Killogram, false, 1.15f, 12, 2.23f, FromType.Russia, GoodsType.Industrial));
            AddGoods(new Shoes("Булочка7", "7.", UnitType.Unit, true, 2.15f, -1, 5.23f, FromType.Spain, GoodsType.Industrial));
            AddGoods(new Furniture("Булочка8", "8.", UnitType.Killogram, true, 2.15f, 12, 152.23f, FromType.USA, GoodsType.Food));

            AddUsers(new PurchaseManager("Иванов Иван Иванович"));
            AddUsers(new Shopkeeper("Петров П П"));
            AddUsers(new Accountant("Жигалова Ж Ж"));
            AddUsers(new ClientManager("Иванов2 Иван2 Иванович2"));
            AddUsers(new ClientManager("Жигалов Иван2 Иванович2"));
            AddUsers(new Courier("Петров2 П2 П2"));
            AddUsers(new PurchaseManager("Жигалова2 Ж2 Ж2"));

            AddStorage(new Entity.Storage(1));
            AddStorage(new Entity.Storage(2));
            AddStorage(new Entity.Storage(2));
            AddStorage(new Entity.Storage(3));
        }

        public void AddGoods(Goods product)
        {
            product.Id = goodsId++;
            goods.Add(product);
        }

        public void AddUsers(User user)
        {
            user.Id = usersId++;
            users.Add(user);
        }

        public void AddOrdersReq(Request req)
        {
            req.Id = ordersReqId++;
            ordersReq.Add(req);
        }

        public void AddPurchasesReq(Request req)
        {
            req.Id = purchasesReqId++;
            purchasesReq.Add(req);
        }

        public void AddStorage(Entity.Storage storage)
        {
            storage.Id = storageId++;
            storages.Add(storage);
        }
    }
}
