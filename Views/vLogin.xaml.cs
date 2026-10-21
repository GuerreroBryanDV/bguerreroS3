namespace bguerreroS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ";
    String contrasena = " ";

	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string usuarioNuevo, string contrasenaueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contrasena = contrasenaueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            if (usuarioIngresado == usuario && contrasenaIngresada == contrasena)
            {
                // Credenciales correctas, navegar a la página principal
                await Navigation.PushAsync(new Views.vPrincipal(usuarioIngresado));
            }
            else
            {
                // Credenciales incorrectas, mostrar mensaje de error
                DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "Aceptar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
		catch (Exception ex)
		{
            // Excepcion, mostrar mensaje de error
            DisplayAlertAsync("Error", ex.Message, "Cerrar");
		}


    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        // Navegar a la página de registro
        await Navigation.PushAsync(new Views.vRegistro());

    }
}