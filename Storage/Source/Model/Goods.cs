using System.Collections.Generic;
using Storage.Source.Entity;

namespace Storage.Source
{
    partial class Model
    {
        public List<Goods> GetGoodsFrom(FromType from)
        {
            return db.goods.FindAll(x => x.From == from);
        }

        public Goods GetGoodsById(int id)
        {
            return db.goods.Find(x => x.Id == id);
        }

        public List<Goods> GetGoodsByType(GoodsType goodsType)
        {
            return db.goods.FindAll(x => x.Type == goodsType);
        }
    }
}
