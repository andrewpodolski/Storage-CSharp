using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source
{
    class Log
    {
        int objectId { get; }
        string message { get; }

        DateTime date { get; }

        public Log(int id, string message)
        {
            objectId = id;
            this.message = message;
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("{0}: Пользователь {1}.{2}\n", date, objectId, message);
        }
    }
}
