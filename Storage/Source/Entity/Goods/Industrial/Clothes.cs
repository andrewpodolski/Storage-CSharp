namespace Storage.Source.Entity
{ 
    class Clothes : IndustrialGoods
    {
        public Clothes(
            string name,
            string description,
            UnitType unit,
            bool packaging,
            float weight,
            int lifeTime,
            float price,
            FromType from,
            GoodsType type
        ) : base(
            name,
            description,
            unit,
            packaging,
            weight,
            lifeTime,
            price,
            from,
            type)
        {

        }
    }
}
