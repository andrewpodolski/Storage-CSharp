using System;
using System.Windows.Forms;

using Storage.Source;
using Storage.Forms;
using Storage.Forms.PurcaseMan;
using Storage.Forms.Accountant;
using Storage.Forms.Shopkeeper;
using Storage.Forms.ClientMan;
using Storage.Forms.Courier;

namespace Storage
{
    public partial class MainMenuForm : Form
    {
        Presenter pres;

        public MainMenuForm()
        {
            InitializeComponent();
            pres = new Presenter();

            pres.view.Init(pres, this);
            pres.StartTimer();
        }

        private void PurcNewProductBtn_Click(object sender, EventArgs e)
        {
            var newProductForm = new Forms.PurcaseMan.NewProductForm(pres);

            pres.NewProduct(newProductForm);

            newProductForm.ShowDialog();
        }

        private void PurcCheckOrderStateBtn_Click(object sender, EventArgs e)
        {
            var checkOrderState = new CheckOrderStateForm();

            pres.CheckOrder(checkOrderState);

            checkOrderState.ShowDialog();
        }

        private void PurcProductInfoBtn_Click(object sender, EventArgs e)
        {
            var productInfo = new ProductInfoForm();

            pres.GoodsInfo(productInfo);

            productInfo.ShowDialog();
        }

        private void AcPaymentInfoBtn_Click(object sender, EventArgs e)
        {
            var paymentInfo = new PaymentInfoForm();

            pres.PaymentInfo(paymentInfo);

            paymentInfo.ShowDialog();
        }

        private void AcProviderPaymentBtn_Click(object sender, EventArgs e)
        {
            var providerPayment = new ProviderPaymentForm(pres);

            pres.ProviderPayment(providerPayment);

            providerPayment.ShowDialog();
        }

        private void AcCostsInfoBtn_Click(object sender, EventArgs e)
        {
            var costsInfo = new CostsInfoForm(pres);

            costsInfo.ShowDialog();
        }

        private void SkNewProductBtn_Click(object sender, EventArgs e)
        {
            var newProduct = new Forms.Shopkeeper.NewProductForm(pres);

            pres.NewSkProduct(newProduct);

            newProduct.ShowDialog();
        }

        private void SkNewLotBtn_Click(object sender, EventArgs e)
        {
            var newLot = new NewLotForm(pres);

            pres.NewLot(newLot);

            newLot.ShowDialog();
        }

        private void ClientNewOrderBtn_Click(object sender, EventArgs e)
        {
            var newOrder = new NewOrderForm(pres);

            pres.NewOrder(newOrder);

            newOrder.ShowDialog();
        }

        private void ClientManPayBtn_Click(object sender, EventArgs e)
        {
            var orderPayment = new OrderPaymentForm(pres);

            pres.OrderPayment(orderPayment);

            orderPayment.ShowDialog();
        }

        private void ClientCheckOrderStatusBtn_Click(object sender, EventArgs e)
        {
            var orderInfo = new OrderInfoForm();

            pres.OrdersInfo(orderInfo);

            orderInfo.ShowDialog();
        }

        private void CourierDeliverBtn_Click(object sender, EventArgs e)
        {
            var deliver = new DeliverForm(pres);

            pres.Deliver(deliver);

            deliver.ShowDialog();
        }

        private void ОтчётToolStripMenuItem_Click(object senders, EventArgs e)
        {
            var logsForm = new LogsForm(pres);

            logsForm.ShowDialog();
        }
    }
}
