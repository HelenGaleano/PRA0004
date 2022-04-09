using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRA0004.Controllers;
using System.IO;
using PRA0004.Views;

namespace PRA0004
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            PagosAntiguedad.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR.db3"));
            MainPage = new NavigationPage (new PagePrincial());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
