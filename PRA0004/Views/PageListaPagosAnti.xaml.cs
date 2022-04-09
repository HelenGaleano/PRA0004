using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRA0004.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRA0004.Models;

namespace PRA0004.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListaPagosAnti : ContentPage
    {
        public PageListaPagosAnti()
        {
            InitializeComponent();
        }

       /* private void ListaPagos_SelectionChanged(object sender, SelectionChangedEventArgs e)
             {
            
             if(e.CurrentSelection!=null)
             {
                ClasePagos pagos = (ClasePagos)e.CurrentSelection.FirstOrDefault();

             }
       }*/

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaPagos.ItemsSource = await PagosAntiguedad.ObtenerListaPagos();
        }

        private async void toolAgregar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new PagePagos());
        }

        private async void toolModificarPagos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageActualizar());

        }

        private async void toolEliminarPago_Clicked(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new PageEliminar());
        }
    }
}