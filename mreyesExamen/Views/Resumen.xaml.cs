namespace mreyesExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen()
    {
        InitializeComponent();
    }

    string sUsuario = ""; 
    string sNombre = "";
    string sApellido = "";
    string pVoltajes = "";
    string dtFecha = "";
    string pCiudades = "";
    double dMontoIngreso = 0;
    double dCuota = 0;
    double dPagoTotal = 0;


    public Resumen(string Usuario, string Nombre, string Apellido, string Voltajes, string Fecha, string Ciudades, double MontoIngreso, double Cuota, double PagoTotal)
    {
        InitializeComponent();
        sUsuario = Usuario;
        sNombre = Nombre;
        sApellido= Apellido;
        pVoltajes= Voltajes;
        dtFecha = Fecha;
        pCiudades = Ciudades;
        dMontoIngreso= MontoIngreso;
        dCuota = Cuota;
        dPagoTotal= PagoTotal;
        lblUserConn.Text = "Usuario conectado: " + Usuario;

        txtNombre.Text = sNombre;
        txtApellido.Text = sApellido;
        txtVoltaje.Text = pVoltajes;
        txtFecha.Text = dtFecha;
        txtCiudad.Text = pCiudades;
        txtMontoInicial.Text = Convert.ToString(dMontoIngreso);
        txtCoutaMensual.Text = Convert.ToString(dCuota);
        txtPagoTotal.Text = Convert.ToString(dPagoTotal);
    }

    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Login());
    }
}