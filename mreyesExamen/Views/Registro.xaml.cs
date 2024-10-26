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
            double dMontoIngreso = Convert.ToDouble(txtMontoInicial.Text);
            string sNombre = txtNombre.Text;
            string sApellido = txtApellido.Text;
            string pVoltajes = pkVoltaje.Items[pkVoltaje.SelectedIndex].ToString();
            string pCiudades = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            string dtFecha = dtFechas.Date.ToString();
            int iPorcCosto = 5;
            double dValotTotal = 300;
            double dMontoMinimo = ((dValotTotal * 15) / 100);
            double dMontoRestante = dValotTotal - dMontoMinimo;
            double dCuota = dMontoRestante / 3;
            double dPorDiferencia = iPorcCosto / 100;
            double dInteres = dCuota * dPorDiferencia;
            double dCuotaFinal = dCuota + dInteres;
            double dCuotaTot = dCuotaFinal * 3;
            double dPagoTotal = dCuotaTot + dMontoMinimo;

            if (dMontoIngreso < 0 || dMontoIngreso == 0 || dMontoIngreso > 300)
            {
                DisplayAlert("Advertencia", "El monto incial no puede tener valores negativo o sobre pasar los $300.00 o valor $ 0.00", "Ok");
            }


            Navigation.PushAsync(new Views.Resumen(Usuario, sNombre, sApellido, pVoltajes, dtFecha, pCiudades, dMontoIngreso, dCuota, dPagoTotal));
        }
		catch (Exception ex)
		{
            DisplayAlert("Error", "Error: " + ex.Message, "Ok");
		}
    }
}