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
        int LifeTime { get; }

        float Price { get; }
        FromType From { get; }
    }
}
