using Storage.Forms.Accountant;

namespace Storage.Source
{
    partial class Presenter
    {
        public void ShowIncome(CostsInfoForm form)
        {
            view.Show(form, model.GetIncome());
        }

        public void ShowCosts(CostsInfoForm form)
        {
            view.Show(form, model.GetCosts());
        }
    }
}
