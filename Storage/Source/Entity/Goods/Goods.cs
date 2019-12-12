using System.ComponentModel;

using Storage.Source.Interfaces;

namespace Storage.Source.Entity
{
    abstract class Goods : IGoods
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Description { get; }
        public GoodsType Type { get; }
        public UnitType Unit { get; }
        public bool Packaging { get; }
        public float Weight { get; }
        public int LifeTime { get; }
        public float Price { get; }
        public FromType From { get; }

        public Goods(string name, string description, UnitType unit, bool packaging, float weight, int lifeTime, float price, FromType from, GoodsType goodsType)
        {
            Name = name;
            Description = description;
            Unit = unit;
            Packaging = packaging;
            Weight = weight;
            LifeTime = lifeTime;
            Price = price;
            From = from;
            Type = goodsType;
        }

        public string StringToCompare()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                Name,
                Description,
                Type.ToString(),
                LifeTime < 0 ? "Бесконечный" : LifeTime.ToString(),
                Price,
                From,
                Weight,
                Unit,
                Packaging);
        }

        public string ShortInfo()
        {
            return string.Format("Id: {0} ; Название: {1}", Id, Name);
        }

        public override string ToString()
        {
            return string.Format("Id: {0} ; Название: {1}; Описание: {2}; Вид: {3}; Срок хранения: {4}; Цена: {5}",
                Id,
                Name,
                Description,
                Type == GoodsType.Industrial ? "Промышленный" : "Продовольственный",
                LifeTime < 0 ? "Бесконечный" : LifeTime.ToString(),
                Price);
        }
    }
}
