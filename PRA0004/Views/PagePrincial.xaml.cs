using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRA0004.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincial : ContentPage
    {
        public PagePrincial()
        {
            InitializeComponent();
        }

        private async void btn_Pagos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListaPagosAnti());
        }

        private async void btnAgregarMon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePagos());
        }
    }
}