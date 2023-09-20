using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesarrollowebII.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ayuda : ContentPage
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiTabbedPage());
        }

        private async void btnTutoriales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tutoriales());
        }

        private async void btnContacto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Contacto());
        }

        private async void btnProyecto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Proyecto());
        }
    }
}