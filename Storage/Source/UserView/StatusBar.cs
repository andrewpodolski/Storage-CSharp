using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Source
{
    partial class UserView
    {
        public void UpdateSB()
        {
            var sum = pres.GetStorageSum();
            var info = string.Format("Дата: {0}; Сумма всех товарова на складе: {1}.", DateTime.Now.ToString(), sum);
            mainMenu.statusBar.Text = info;
        }
    }
}
