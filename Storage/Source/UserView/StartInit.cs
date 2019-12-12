using Storage.Source.Entity.Users;

namespace Storage.Source
{
    partial class UserView
    {
        public void Init(Presenter pres, MainMenuForm form)
        {
            mainMenu = form;

            var users = pres.GetAllUsers();

            foreach (var u in users)
            {
                if (u is PurchaseManager)
                {
                    form.purcManListCB.Items.Add(u.ToString());
                    form.purcManListCB.SelectedIndex = 0;
                    continue;
                }

                if (u is Accountant)
                {
                    form.acListCB.Items.Add(u.ToString());
                    form.acListCB.SelectedIndex = 0;
                    continue;
                }

                if (u is StoreKepper)
                {
                    form.skListCB.Items.Add(u.ToString());
                    form.skListCB.SelectedIndex = 0;
                    continue;
                }

                if (u is ClientManager)
                {
                    form.clientListCB.Items.Add(u.ToString());
                    form.clientListCB.SelectedIndex = 0;
                    continue;
                }

                if (u is Courier)
                {
                    form.courierListCB.Items.Add(u.ToString());
                    form.courierListCB.SelectedIndex = 0;
                    continue;
                }
            }
        }
    }
}
