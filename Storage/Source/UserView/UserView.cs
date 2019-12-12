using System;
using System.Windows.Forms;

namespace Storage.Source
{
    partial class UserView
    {
        MainMenuForm mainMenu;
        Presenter pres;

        public UserView(Presenter pres)
        {
            this.pres = pres;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
