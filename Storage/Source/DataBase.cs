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

            AddGoods(new Bakery("Хлеб", "1.", UnitType.Unit, false, 0.15f, 1, 100.0f, FromType.Belarus, GoodsType.Food));
            AddGoods(new Dairy("Молоко", "2.", UnitType.Liter, false, 0.15f, 1, 125.5f, FromType.Belarus, GoodsType.Food));
            AddGoods(new Meat("Сало", "3.", UnitType.Unit, true, 1.15f, 12, 1.99f, FromType.Belarus, GoodsType.Industrial));
            AddGoods(new Appliances("СВЧ-печь", "4.", UnitType.Liter, false, 25f, 35, 30.99f, FromType.Germany, GoodsType.Industrial));
            AddGoods(new Clothes("Куртка", "5.", UnitType.Unit, true, 43.5f, -1, 16.99f, FromType.Italy, GoodsType.Industrial));
            AddGoods(new Equipment("Гантеля", "6.", UnitType.Killogram, false, 1.15f, 12, 12.25f, FromType.Russia, GoodsType.Industrial));
            AddGoods(new Shoes("Кроссовки", "7.", UnitType.Unit, true, 2.15f, -1, 50.99f, FromType.Spain, GoodsType.Industrial));
            AddGoods(new Furniture("Диван", "8.", UnitType.Killogram, true, 40.1f, 12, 150f, FromType.USA, GoodsType.Industrial));
            AddGoods(new Stationery("Ручки", "9.", UnitType.Unit, true, 1.1f, 9999, 0.99f, FromType.Denmark, GoodsType.Industrial));
            AddGoods(new Stationery("Блокноты", "10.", UnitType.Unit, true, 1.1f, 0, 1.0f, FromType.England, GoodsType.Industrial));

            AddUsers(new PurchaseManager("Иванов Иван"));
            AddUsers(new Shopkeeper("Петров Петр"));
            AddUsers(new Accountant("Сидоров Сидор"));
            AddUsers(new ClientManager("Мумов Валентин"));
            AddUsers(new ClientManager("Энгельс Фридрих"));
            AddUsers(new Courier("Ластенко Алексей"));
            AddUsers(new PurchaseManager("Тодов Виталий"));


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
