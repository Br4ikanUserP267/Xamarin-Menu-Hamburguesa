using Asphalt9.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asphalt9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maestro : ContentPage
    {
        
        public Maestro()
        {
            InitializeComponent();

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FYP.IsPresented = false;
            App.FYP.Detail.Navigation.PushAsync(new Pagina1());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.FYP.IsPresented = false;
            App.FYP.Detail.Navigation.PushAsync(new Pagina2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.FYP.IsPresented = false;
            App.FYP.Detail.Navigation.PushAsync(new Pagina3());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.FYP.IsPresented = false;
            App.FYP.Detail.Navigation.PushAsync(new Pagina4());

        }
    }
}