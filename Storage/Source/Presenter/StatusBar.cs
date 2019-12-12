using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Storage.Source
{
    partial class Presenter
    {
        Timer timer = new Timer();
        
        public void StartTimer()
        {
            timer.Interval = 1000;
            timer.Tick += Update;

            timer.Enabled = true;
        }

        private void Update(object sender, EventArgs e)
        {
            view.UpdateSB();
        }

        public float GetStorageSum()
        {
            var storages = model.GetAllStorages();
            var sum = 0f;
            storages.ForEach(x => x.Goods.ForEach(e => sum += e.Price));

            return sum;
        }
    }
}
