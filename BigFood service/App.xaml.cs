namespace BigFood_service
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
           GoToLoginPage();
        }
        private async void GoToLoginPage()
        {
            // Navegar a la página de inicio de sesión
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
