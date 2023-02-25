using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Asphalt9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina4 : ContentPage
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://asphaltlegends.com/");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Muchas gracias", "Tu información se ha enviado correctamente", "De acuerdo");
        }
    }
}