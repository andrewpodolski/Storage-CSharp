using System;
using System.Collections.Generic;

using Storage.Source.Interfaces;

namespace Storage.Source.Entity.Request
{
    class Request : IRequest
    {
        public int Id { get; set; }
        public string Date { get; }
        public int UserId { get; }

        public List<Goods> ReqGoods { get; set; }

        public int GoodsCount
        {
            get
            {
                return ReqGoods.Count;
            }
        }

        public float GoodsSum
        {
            get
            {
                var sum = 0f;
                ReqGoods.ForEach(e => sum += e.Price);

                return sum;
            }
        }

        public bool IsDone { get; set; } = false;
        public bool InStorage { get; set; } = false;
        public bool IsReady { get; set; } = false;
        public bool IsDelivered { get; set; } = false;

        public Request(int userId, List<Goods> goods)
        {
            Date = DateTime.Now.ToString();
            UserId = userId;
            ReqGoods = goods;
        }

        public void Pay()
        {
            IsDone = true;
        }

        public string ShortInfo()
        {
            var result = "";
            result += "Id: " + Id + " ";
            result += "UserId: " + UserId;

            return result;
        }

        public override string ToString()
        {
            var result = "";

            result += "Id: " + Id + " \n";
            result += "Дата: " + Date + "\n";
            result += "Id Менаджера: " + UserId + "\n";
            result += "Товаров всего: " + GoodsCount + "\n";
            result += "Суммарная стоимость: " + GoodsSum + "\n";
            result += "Товары:\n";
            foreach (var g in ReqGoods)
            {
                result += "    " + g.ToString() + "\n";
            }

            result += "Оплачен: " + (IsDone ? "да" : "нет") + "\n";
            result += "На складе:" + (InStorage ? "да" : "нет") + "\n";
            result += "Готов к отправке: " + (IsReady ? "да" : "нет") + "\n";
            result += "Доставлен покупателю: " + (IsDelivered ? "да" : "нет") + "\n\n";

            return result;
        }
    }
}
