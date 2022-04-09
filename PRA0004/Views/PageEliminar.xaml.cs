using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRA0004.Controllers;
using PRA0004.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRA0004.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageEliminar : ContentPage
    {
        public PageEliminar()
        {
            InitializeComponent();
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var pagos = new Pago
            {
                ID = Convert.ToInt32(id.Text),
            };

            await PagosAntiguedad.DelPagoAntiguedad(pagos);


        }
    }
}