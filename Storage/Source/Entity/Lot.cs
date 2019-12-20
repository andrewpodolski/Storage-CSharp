using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source.Entity
{
    class Lot
    {
        public int ReqId { get; }
        public List<Goods> Goods { get; }

        public Lot(int id, List<Goods> goods)
        {
            ReqId = id;
            Goods = goods;
        }

        public override string ToString()
        {
            var result = "";

            result += "Id запроса: " + ReqId + " \n";
            result += "Товары:\n";

            foreach(var g in Goods)
            {
                result += "    " + g.ShortInfo() + "\n";
            }

            return result;
        }
    }
}
