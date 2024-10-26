namespace mreyesExamen.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    string Usuario = "";

    public Registro(string User)
    {
        InitializeComponent();
        Usuario = User;
        lblUserConn.Text = "Usuario conectado: " + Usuario;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
		try
		{
            string sNombre = txtNombre.Text;
            string sApellido = txtApellido.Text;
            double dMontoIngreso = txtMontoInicial;
            string pVoltajes = pkVoltaje.Items[pkVoltaje.SelectedIndex].ToString();
            string pCiudades = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            string dtFecha = dtFechas.Date.ToString();
            double dPagoTotal = 300;
            double dcuotaMensual = 0;   


            Navigation.PushAsync(new Views.Resumen(Usuario, sNombre, sApellido, dMontoIngreso, pVoltajes, pCiudades, dtFecha));
        }
		catch (Exception ex)
		{
            DisplayAlert("Error", "Error: " + ex.Message, "Ok");
		}
    }
}