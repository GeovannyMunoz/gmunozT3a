using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gmunozS2a.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		string dato = pkPaises.Items[pkPaises.SelectedIndex].ToString();
		lblSeleccionado.Text = "El elemento seleccionado es " + dato;
		//DisplayAlert("Elemento eleccionado", dato, "Cancelar");

    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha = dpFechas.Date.ToString();
        DisplayAlert("Fecha Seleccionada", fecha, "Cancelar");
    }
}