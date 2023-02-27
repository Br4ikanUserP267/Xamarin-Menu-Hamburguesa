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
    public partial class ChatView : ContentPage
    {
        public LinkedList<ChatMessage> ChatMessages { get; set; }

        public ChatView()
        {
            InitializeComponent();
        
            // Instanciar y añadir mensajes de chat a la LinkedList
            ChatMessages = new LinkedList<ChatMessage>();
            ChatMessages.AddLast(new ChatMessage { Content = "Hola", Sender = "Ana", Timestamp = DateTime.Now });
            ChatMessages.AddLast(new ChatMessage { Content = "Hola Ana, ¿cómo estás?", Sender = "Pedro", Timestamp = DateTime.Now });
            ChatMessages.AddLast(new ChatMessage { Content = "Estoy bien, gracias. ¿Y tú?", Sender = "Ana", Timestamp = DateTime.Now });

            // Enlazar la vista con la propiedad ChatMessages
            BindingContext = this;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}