using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRA0004.Models;
using PRA0004.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRA0004.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageActualizar : ContentPage
    {
        public PageActualizar()
        {
            InitializeComponent();
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            var pagos = new Pago
            {
                ID = Convert.ToInt32(id.Text),
                Descripcion = descripcion.Text,
                Monto = Convert.ToDouble(montopago.Text),
                Fecha = fecha.Date,
            };

            await PagosAntiguedad.UpdPagos(pagos);

           /* if (await PagosAntiguedad.UpdPagos(pagos) > 0)
            {
                await DisplayAlert("Alerta", "Se guardo correctamente", "Ok");
            }
            else
            {
                await DisplayAlert("Alerta", "No se guardar", "Ok");
            }*/
        }
    }
}