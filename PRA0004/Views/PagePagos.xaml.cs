using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRA0004.Models;
using PRA0004.Controllers;
using System.IO;
using Plugin.Media;


namespace PRA0004.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePagos : ContentPage
    {
        public PagePagos()
        {
            InitializeComponent();
        }

        


        private void btnPhotorecibo_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void btninsertar_Clicked(object sender, EventArgs e)
        {
            var pagos = new Pago
            {     
                
                Descripcion = descripcion.Text,
                Monto = Convert.ToDouble(montopago.Text),
                Fecha = fecha.Date,

            };

           
           if(await PagosAntiguedad.AddPagos(pagos)>0)
           {
               await DisplayAlert("Alerta", "Se guardo correctamente", "Ok");
           }
           else
           {
                await DisplayAlert("Alerta", "No se guardar", "Ok");
           }
            
        }

       
    }
}