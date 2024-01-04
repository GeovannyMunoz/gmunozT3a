namespace gmunozS2a
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Vistas.vLogin());
            //MainPage = new Vistas.vLogin();
        }
    }
}