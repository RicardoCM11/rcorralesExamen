
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
        string[] contrase�as = new string[3];
        usuarios[0] = "estudiante2024";
        usuarios[1] = "examen1";
        usuarios[2] = "NombreEstudiante";

        contrase�as[0] = "uisrael2024";
        contrase�as[1] = "parcial1";
        contrase�as[2] = "2024";

        string us = txtusuario.Text;

      
                if (txtusuario.Text == usuarios[0] && txtcontrase�a.Text == contrase�as[0])
                {
                    Navigation.PushAsync(new VistaRegistro(us));

                }
              

                if (txtusuario.Text == usuarios[1] && txtcontrase�a.Text == contrase�as[1])
                {
                    Navigation.PushAsync(new VistaRegistro(us));
          

        }
        

        if (txtusuario.Text == usuarios[2] && txtcontrase�a.Text == contrase�as[2])
                {
                    Navigation.PushAsync(new VistaRegistro(us));
          

        }
 
    }


        
      
    
}