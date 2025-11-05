using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
            dtpck_checkin.MinimumDate = DateTime.Now;
        }

        private async void btnAvancar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
