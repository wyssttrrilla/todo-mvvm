using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMobileSample.ViewModel;
using MVVMobileSample.View;
using MVVMobileSample.Model;


namespace MVVMobileSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new PageListUser());
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
