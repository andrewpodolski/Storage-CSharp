using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source
{
    partial class Model
    {
        public void AddIncome(string message)
        {
            db.income.Add(message);
        }

        public List<string> GetIncome()
        {
            return db.income;
        }

        public void AddCosts(string message)
        {
            db.costs.Add(message);
        }

        public List<string> GetCosts()
        {
            return db.costs;
        }
    }
}
