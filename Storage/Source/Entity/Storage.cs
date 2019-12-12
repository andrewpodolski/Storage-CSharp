using System;
using System.Collections.Generic;
using Storage.Source.Interfaces;

namespace Storage.Source.Entity
{ 
    class Storage : IStorage
    {
        public int Id { get; set; }
        public int ShopkeeperId { get; }
        public string ComeDate { get; set; }
        public List<Goods> SpoiledGoods { get; }
        public List<Goods> Goods { get; }
        public List<List<Goods>> ToDeliver { get; }
        public Storage(int shopkeeperId)
        {
            ShopkeeperId = shopkeeperId;
            ComeDate = DateTime.Now.ToString();

            Goods = new List<Goods>();
            SpoiledGoods = new List<Goods>();
            ToDeliver = new List<List<Goods>>();
        }

        public string ShortInfo()
        {
            return string.Format("Склад {0}", Id);
        }

        public override string ToString()
        {
            var result = "";

            result += "Id: " + Id + "\n";

            result += "Заведущий складом: " + ShopkeeperId + "\n";
            result += "Дата поставки: " + ComeDate + "\n";

            result += "Товары:\n";
            foreach (var g in Goods)
            {
                result += "    " + g.ToString() + "\n";
            }

            result += "Испорченные товары:\n";
            foreach (var g in SpoiledGoods)
            {
                result += "    " + g.ToString() + "\n";
            }

            return result;
        }
    }
}
