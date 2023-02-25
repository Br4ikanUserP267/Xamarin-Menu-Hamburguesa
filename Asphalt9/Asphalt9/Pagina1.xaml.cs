using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace Asphalt9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
            
        }

        private void Elyuserneim_Clicked(object sender, EventArgs e)
        {
            var nombre = elyuserneim.Text;
            DisplayAlert("Felicidades ", nombre + ". Aqui comienza tu camino para ser una leyenda","De acuerdo");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://asphaltlegends.com/");
        }
    }
}