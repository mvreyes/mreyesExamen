namespace mreyesExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}

    string Usuario = "";

    public Resumen(string User)
    {
        InitializeComponent();
        Usuario = User;
        lblUserConn.Text = "Usuario conectado: " + Usuario;
    }
}