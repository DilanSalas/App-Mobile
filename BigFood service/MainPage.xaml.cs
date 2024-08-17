namespace BigFood_service
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnVerProductosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductosPage());
        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }

}
