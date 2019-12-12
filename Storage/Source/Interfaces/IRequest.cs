using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Source.Entity;

namespace Storage.Source.Interfaces
{
    interface IRequest
    {
        int Id { get; set; }
        string Date { get; }
        int UserId { get; }
        List<Goods> ReqGoods { get; }
        int GoodsCount { get; }
        float GoodsSum { get; }
        bool IsDone { get; set; }
    }
}
