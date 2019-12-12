using System.Collections.Generic;
using Storage.Source.Entity;

namespace Storage.Source.Interfaces
{
    interface IStorage
    {
        int Id { get; set; }
        int ShopkeeperId { get; }

        string ComeDate { get; set; }

        List<Goods> Goods { get; }
        List<Goods> SpoiledGoods { get; }
    }
}
