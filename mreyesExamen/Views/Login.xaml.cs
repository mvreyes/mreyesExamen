namespace mreyesExamen.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        
	}

    private void btnInicioSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
            string[] usuarios = { "estudiante2024", "examen1" };
            string[] claves = { "uisrael2024", "parcial1" };
            bool bUsuario = false;
            bool bClave = false;

            string usuarioIngresado = txtUser.Text;
            string claveIngresada = txtPassword.Text;

            List<string> listaUsuarios = usuarios.ToList();
            List<string> listaClaves = claves.ToList();

            foreach (string usuario in listaUsuarios)
            {
                if (usuario.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase))
                {
                    bUsuario = true;
                    break;
                }
            }

            if (!bUsuario)
            {
                listaUsuarios.Add(usuarioIngresado);
                listaClaves.Add("2024");
                bUsuario = true;
            }

            foreach (string clave in listaClaves)
            {
                if (clave.Equals(claveIngresada, StringComparison.OrdinalIgnoreCase))
                {
                    bClave = true;
                    break;
                }
            }

            if (!bUsuario || !bClave)
            {
                DisplayAlert("Advertencia", "El usuario/contraseña no son correctos", "Ok");
            }
            else
            {
                Navigation.PushAsync(new Views.Registro(usuarioIngresado));
            }
        }
        catch (Exception ex)
		{
            DisplayAlert("Error", "Error: " + ex.Message, "Ok");
        }
    }

    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Información", "La aplicacion fue creada por: Marco Reyes.", "Ok");
    }
}