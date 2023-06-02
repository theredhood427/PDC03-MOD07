using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDC03_MOD07.Services;
using PDC03_MOD07.View;

namespace PDC03_MOD07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ShowEmployeePage());
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
