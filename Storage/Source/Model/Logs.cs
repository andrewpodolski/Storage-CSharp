using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source
{
    partial class Model
    {
        public void AddLog(LogType type, Log log)
        {
            logs.Log[(int) type].Add(log);
        }

        public List<Log>[] GetLogs()
        {
            return logs.Log;
        }
    }
}
