using System.Collections.Generic;
using System.Windows.Forms;

using Storage.Forms.Accountant;

namespace Storage.Source
{
    partial class UserView
    {
        public void Show(CostsInfoForm form, List<string> messages)
        {
            form.logs.Controls.Clear();

            foreach (var m in messages)
            {
                var height = 5;

                var c = form.logs.Controls;
                if (c.Count > 0)
                {
                    height =
                        c[c.Count - 1].Location.Y
                        + c[c.Count - 1].Size.Height;
                }

                var label = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(5, height),

                    Text = string.Format(m.ToString())
                };

                form.logs.Controls.Add(label);
            }
        }
    }
}
