namespace gmunozS2a.Vistas;

public partial class vCalificaiones : ContentPage
{
	public vCalificaiones()
	{
		InitializeComponent();
	}

    private void btnClacular_Clicked(object sender, EventArgs e)
    {
        string estudiante = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();
        double parcial1 = Convert.ToDouble(txtNota1.Text) * 0.3 + Convert.ToDouble(txtExamen1.Text) *0.2;
		lblNotaParcial1.Text = parcial1.ToString();

        double parcial2 = Convert.ToDouble(txtNota2.Text) * 0.3 + Convert.ToDouble(txtExamen2.Text) * 0.2;
        lblNotaParcial2.Text = parcial2.ToString();
        double notaFinal = parcial1 + parcial2;
        string estado = "";

        string fecha = dpFecha.Date.ToString();
        if(notaFinal >= 7) {
            estado = "APROBADO";
        }else if(notaFinal <= 5.9 && notaFinal >=5)
        {
            estado = "COMPLEMENTARIO";
        }else if ( notaFinal < 5)
        {
            estado = "REPROBADO";
         } 

        DisplayAlert("Notas", "Nombre: "+ estudiante +"\n Fecha: "+fecha+"\n Nota Parcial 1: "+ parcial1+"\n Nota Parcial 2: "+parcial2+"\n Nota Final: "+notaFinal+"\n Estado:"+estado, "Cancelar");

    }

    private void txtNota1_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNota1.Text);
            if(nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rando 0 -10", "Cerra");
               txtNota1.Text = "0";
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}