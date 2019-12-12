using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source
{
    class LogsDB
    {
        private List<Log> Accountant;
        private List<Log> ClientMan;
        private List<Log> Courier;
        private List<Log> PurcaseMan;
        private List<Log> Shopkeeper;

        public List<Log>[] Log { get; }

        public LogsDB()
        {
            Accountant = new List<Log>();
            ClientMan = new List<Log>();
            Courier = new List<Log>();
            PurcaseMan = new List<Log>();
            Shopkeeper = new List<Log>();

            Log = new List<Log>[]
            {
                Accountant,
                ClientMan,
                Courier,
                PurcaseMan,
                Shopkeeper
            };
        }
    }
}
