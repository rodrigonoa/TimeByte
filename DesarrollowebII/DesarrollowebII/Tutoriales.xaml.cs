using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesarrollowebII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tutoriales : ContentPage
	{
        public string link = "";
		public Tutoriales ()
		{
			InitializeComponent ();
		}

        private async void btnMostrarMo_Clicked(object sender, EventArgs e)
        {
            imgLogo.Source = new Uri("https://dsadasdasdasd.000webhostapp.com/imagenes/java.png");
            lblTitulo.Text = "Java Android";
            lblLink.Text = "Click aqui para información";
            link = "https://www.develou.com/introduccion-a-java-para-desarrollo-android/";
            await TextoIntroduccion.FadeTo(0, 250);
            TextoIntroduccion.Text = "La versión de Java para dispositivos móviles está basada en la edición Micro Edition de la plataforma Java (Java ME), que constituye un entorno sólido y flexible para aplicaciones ejecutadas en dispositivos móviles y otros dispositivos incrustados: teléfonos móviles, PDA, descodificadores e impresoras.";
            await TextoIntroduccion.FadeTo(1, 250);
        }

        private async void btnMostrarFront_Clicked(object sender, EventArgs e)
        {
            imgLogo.Source = new Uri("https://dsadasdasdasd.000webhostapp.com/imagenes/React.png");
            lblTitulo.Text = "React";
            lblLink.Text = "Click aqui para información";
            link = "https://legacy.reactjs.org/tutorial/tutorial.html";
            await TextoIntroduccion.FadeTo(0, 250);
            TextoIntroduccion.Text = "React es una librería Javascript de código abierto diseñada para crear interfaces de usuario con el objetivo de facilitar el desarrollo de aplicaciones en una sola página. Es mantenido por Facebook y la comunidad de software libre. En el proyecto hay más de mil desarrolladores libres.";
            await TextoIntroduccion.FadeTo(1, 250);
        }

        private async void btnMostrarBack_Clicked(object sender, EventArgs e)
        {
            imgLogo.Source = new Uri("https://dsadasdasdasd.000webhostapp.com/imagenes/laravel.png");
            lblTitulo.Text = "Laravel";
            lblLink.Text = "Click aqui para información";
            link = "https://styde.net/laravel-desde-cero/";
            await TextoIntroduccion.FadeTo(0, 250);
            TextoIntroduccion.Text = "Laravel es un framework de código abierto para desarrollar aplicaciones y servicios web con PHP 5, PHP 7 y PHP 8. Su filosofía es desarrollar código PHP de forma elegante y simple, evitando el \"código espagueti\". Fue creado en 2011 y tiene una gran influencia de frameworks como Ruby on Rails, Sinatra y ASP.NET MVC.​";
            await TextoIntroduccion.FadeTo(1, 250);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(link));
        }
    }
}