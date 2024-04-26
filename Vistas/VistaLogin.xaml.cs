
namespace rcorralesExamen.Vistas;

public partial class VistaLogin : ContentPage
{
	public VistaLogin()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new VistaAcerca());

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        string[] usuarios = new string[3];
        string[] contraseñas = new string[3];
        usuarios[0] = "estudiante2024";
        usuarios[1] = "examen1";
        usuarios[2] = "NombreEstudiante";

        contraseñas[0] = "uisrael2024";
        contraseñas[1] = "parcial1";
        contraseñas[2] = "2024";

        string us = txtusuario.Text;

      
                if (txtusuario.Text == usuarios[0] && txtcontraseña.Text == contraseñas[0])
                {
                    Navigation.PushAsync(new VistaRegistro(us));

                }
              

                if (txtusuario.Text == usuarios[1] && txtcontraseña.Text == contraseñas[1])
                {
                    Navigation.PushAsync(new VistaRegistro(us));
          

        }
        

        if (txtusuario.Text == usuarios[2] && txtcontraseña.Text == contraseñas[2])
                {
                    Navigation.PushAsync(new VistaRegistro(us));
          

        }
 
    }


        
      
    
}