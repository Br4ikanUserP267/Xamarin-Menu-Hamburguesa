using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asphalt9
{
    public partial class App : Application
    {
        public static FlyoutPage FYP { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
