using System.Collections.Generic;
using System.IO;

using System.Windows.Forms;

namespace Storage.Source
{
    partial class Presenter
    {
        string fileName = "";

        public void Logs(int type)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Text files(*.txt)| *.txt*";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = openFile.FileName;
            var logs = "";

            switch (type)
            {
                case 0:
                    logs = AllLogs();
                    break;
                default:
                    view.ShowMessage("Неизвестное условие.");
                    return;
            }

            File.WriteAllText(fileName, logs);
            view.ShowMessage("Записано.");
        }

        private string AllLogs()
        {
            var logs = "";

            var logArr = model.GetLogs();
            var logList = new List<string>();

            foreach (var l in logArr)
            {
                foreach (var m in l)
                {
                    logList.Add(m.ToString());
                }
            }

            logList.Sort();

            logList.ForEach(l => logs += l);
            

            return logs;
        }
    }
}
