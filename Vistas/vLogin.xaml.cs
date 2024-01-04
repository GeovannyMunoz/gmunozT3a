namespace gmunozS2a.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        string[] user = { "geovanny", "damian", "ronnie", "vinicio", "stalin" };
        string[] pass = { "geovanny123", "damian123", "ronnie123", "vinicio123", "stalin123" };
        string usuario = "";
        string contrasena = "";
        int index = Array.IndexOf(user, txtUsuario.Text);
        if(index != -1)
        {
            usuario = txtUsuario.Text;
            contrasena = pass[index];

        }

        //string usuario = "geovanny";
        //string contrasena = "12345";

        if (txtUsuario.Text == usuario && txtContraseña.Text == contrasena)
        {
            DisplayAlert("Bienvenido", "Hola "+ usuario, "Aceptar");
            //Navigation.PushAsync(new vCalificaiones());

        }
        else
        {
            DisplayAlert("ALERTA", "Usuario/Contrasena incorrectos", "Cancel");
        }

    }
}