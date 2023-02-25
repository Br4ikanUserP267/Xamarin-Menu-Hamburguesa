using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asphalt9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
            cars.Source = "https://www.youtube.com/embed/l19cXNR78pM?start=10";
            tuning.Source = "https://www.youtube.com/embed/KyWkYfvgfnQ";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://asphaltlegends.com/");
        }
    }
}