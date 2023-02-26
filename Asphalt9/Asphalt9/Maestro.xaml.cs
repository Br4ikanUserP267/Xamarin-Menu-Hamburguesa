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
        private List<Asphalt> ListaAsphalt;
        public Maestro()
        {
            InitializeComponent();

            ListaAsphalt = new List<Asphalt>();
            ListaAsphalt.Add(new Asphalt
            {
                Nombre = "LaFerrari",
                imagen = "https://asphalt9.info/wp-content/uploads/2018/07/Ferrari-LaFerrari.jpg",
                Descripcion = "Es el primer vehículo híbrido eléctrico de la casa de Maranello, una propulsión que lo ubica como el Ferrari más potente jamás producido y le permite una reducción del 40% en consumo de combustible.10​ Cuenta con el mismo motor V12 naturalmente aspirado de 6262 cm³ (6,3 L; 382,1 plg³) del Ferrari F12berlinetta,11​ que desarrolla una potencia máxima de 800 CV (789 HP; 588 kW) a las 9000 rpm y un par máximo de más de 700 N·m (516 lb·pie) a las 6750 rpm. Cuenta con asistencias electrónicas como control de tracción, control de estabilidad y un diferencial electrónico de tercera generación. Además, se considera primordial tanto el centro de gravedad, como la eficiencia y comodidad de la posición del conductor dentro del habitáculo.12​ Inicialmente se especulaba que el F70 estuviera equipado con una nueva motorización de 7.3 litros."

            });
            ListaAsphalt.Add(new Asphalt
            {
                Nombre = "Chevrolet Corvette Grand Sport",
                imagen = "https://i0.wp.com/asphalt9.info/wp-content/uploads/2018/07/Chevrolet-Corvette-Grand-Sport.jpg?w=1062&ssl=1",
                Descripcion = "El Chevrolet Corbeta C2017 7 Grand Sport Convertible (oficialmente llamado Chevrolet Corvette Grand Sport y a menudo abreviado como Corvette GS) es una variante convertible de alto rendimiento del Chevrolet Corvette C7 Stingray, con carrocería del Corvette C7 Z06.\r\n\r\nEl Chevrolet Corbeta C2017 7 Grand Sport El convertible tiene un motor V1 LT6.2 de 8 litros de aspiración natural montado en la parte delantera, que produce 460 caballos de fuerza a 6000 rpm y 465 libras-pie de torque a 4600 rpm, y le da al GS un 0-60 de 3.6 segundos."

            });
            ListaAsphalt.Add(new Asphalt
            {
                Nombre = "Vencer Sarthe",
                imagen = "https://i0.wp.com/asphalt9.info/wp-content/uploads/2019/01/Vencer-Sarthe.jpg?w=1062&ssl=1",
                Descripcion = "La Vencer Sarthe es un automóvil deportivo holandés producido por Vencer. Es el primer automóvil producido por Vencer.\r\nEl Sarthe está propulsado por un motor V6.3 de 8 litros sobrealimentado. Produce 622 bhp (464 kW; 631 PS) y 618 lb⋅ft (838 N⋅m) de torque. El automóvil tiene una velocidad máxima de 338 km/h (210 mph) y puede acelerar de 0 a 100 km/h (62 mph) en 3.6 segundos."

            });
            ListaAsphalt.Add(new Asphalt
            {
                Nombre = "Lamborghini Centenario",
                imagen = "https://i0.wp.com/asphalt9.info/wp-content/uploads/2018/07/Lamborghini-Centenario.jpg?resize=768%2C425&ssl=1",
                Descripcion = "El Lamborghini Centenario es un automóvil superdeportivo de dos puertas de tijera biplaza, con motor central-trasero montado longitudinalmente y tracción en las cuatro ruedas, producido por el fabricante italiano Automobili Lamborghini S.p.A. subsidiaria del Grupo Volkswagen."

            });
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