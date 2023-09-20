using DesarrollowebII.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static DesarrollowebII.Modelos.ViewModel;

namespace DesarrollowebII.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horario : ContentPage
    {
        private HorarioViewModel viewModel;
        private MiHorarioViewModel miHorario;
        public Horario()
        {
            InitializeComponent();
            viewModel = new HorarioViewModel();
            miHorario = new MiHorarioViewModel();
            BindingContext = viewModel;
            BindingContext = miHorario;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Recarga();
        }

        private void Recarga()
        {
            string lunes = viewModel.Lunes;
            string martes = viewModel.Martes;
            string miercoles = viewModel.Miercoles;
            string jueves = viewModel.Jueves;
            string viernes = viewModel.Viernes;
            string sabado = viewModel.Sabado;
            string domingo = viewModel.Domingo;

            string milunes = miHorario.Lunes;
            string mimartes = miHorario.Martes;
            string mimiercoles = miHorario.Miercoles;
            string mijueves = miHorario.Jueves;
            string miviernes = miHorario.Viernes;
            string misabado = miHorario.Sabado;

            if (!string.IsNullOrEmpty(milunes))
            {
                lblLunes.Text = milunes;
            }
            if (!string.IsNullOrEmpty(mimartes))
            {
                lblMartes.Text = mimartes;
            }
            if (!string.IsNullOrEmpty(mimiercoles))
            {
                lblMiercoles.Text = mimiercoles;
            }
            if (!string.IsNullOrEmpty(mijueves))
            {
                lblJueves.Text = mijueves;
            }
            if (!string.IsNullOrEmpty(miviernes))
            {
                lblViernes.Text = miviernes;
            }
            if (!string.IsNullOrEmpty(misabado))
            {
                lblSabado.Text = misabado;
            }

            btntareaLunes.IsVisible = !string.IsNullOrEmpty(lunes);
            btntareaMartes.IsVisible = !string.IsNullOrEmpty(martes);
            btntareaMiercoles.IsVisible = !string.IsNullOrEmpty(miercoles);
            btntareaJueves.IsVisible = !string.IsNullOrEmpty(jueves);
            btntareaViernes.IsVisible = !string.IsNullOrEmpty(viernes);
            btntareaSabado.IsVisible = !string.IsNullOrEmpty(sabado);
            btntareaDomingo.IsVisible = !string.IsNullOrEmpty(domingo);
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiTabbedPage());
        }

        private async void btnLunes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Lunes = result;
            OnAppearing();
        }

        private async void btnMartes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día martes", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Martes = result;
            OnAppearing();
        }

        private async void btnMiercoles_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día miercoles", "Escribir Recuerdo", initialValue: viewModel.Miercoles, maxLength: 50);
            viewModel.Miercoles = result;
            OnAppearing();
        }

        private async void btnJueves_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día jueves", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Jueves = result;
            OnAppearing();
        }

        private async void btnViernes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día viernes", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Viernes = result;
            OnAppearing();
        }

        private async void btnSabado_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día sábado", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Sabado = result;
            OnAppearing();
        }

        private async void btnDomingo_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día domingo", "Escribir Recuerdo", initialValue: "", maxLength: 50);
            viewModel.Domingo = result;
            OnAppearing();
        }

        private async void btntareaLunes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Lunes.ToString(), maxLength: 50);
            viewModel.Lunes = result;
        }

        private async void btntareaMartes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Martes, maxLength: 50);
            viewModel.Martes = result;
        }

        private async void btntareaMiercoles_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Miercoles, maxLength: 50);
            viewModel.Miercoles = result;
        }

        private async void btntareaJueves_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Jueves, maxLength: 50);
            viewModel.Jueves = result;
        }

        private async void btntareaViernes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Viernes, maxLength: 50);
            viewModel.Viernes = result;
        }

        private async void btntareaSabado_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Sabado, maxLength: 50);
            viewModel.Sabado = result;
        }

        private async void btntareaDomingo_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi actividad día lunes", "Escribir Recuerdo", initialValue: viewModel.Domingo, maxLength: 50);
            viewModel.Domingo = result;
        }

        private async void btnEditLunes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día lunes", "Escribir horario", initialValue: lblLunes.Text, maxLength: 80);
            miHorario.Lunes = result;
            OnAppearing();
        }

        private async void btnEditMartes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día martes", "Escribir horario", initialValue: lblMartes.Text, maxLength: 80);
            miHorario.Martes = result;
            OnAppearing();
        }

        private async void btnEditMiercoles_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día miercoles", "Escribir horario", initialValue: lblMiercoles.Text, maxLength: 80);
            miHorario.Miercoles = result;
            OnAppearing();
        }

        private async void btnEditJueves_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día jueves", "Escribir horario", initialValue: lblJueves.Text, maxLength: 80);
            miHorario.Jueves = result;
            OnAppearing();
        }

        private async void btnEditViernes_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día viernes", "Escribir horario", initialValue: lblViernes.Text, maxLength: 80);
            miHorario.Viernes = result;
            OnAppearing();
        }

        private async void btnEditSabado_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Mi horario día sabado", "Escribir horario", initialValue: lblSabado.Text, maxLength: 80);
            miHorario.Sabado = result;
            OnAppearing();
        }
    }
}