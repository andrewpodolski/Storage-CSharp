namespace Storage.Source.Interfaces
{
    interface IGoods
    {
        int Id { get; set; }
        string Name { get; }
        string Description { get; }
        GoodsType Type { get; }
        UnitType Unit { get; }
        bool Packaging { get; }

        float Weight { get; }

        /// <summary>
        /// Срок годности. < 0 - без срока годности
        /// </summary>
        int LifeTime { get; }

        float Price { get; }
        FromType From { get; }
    }
}
