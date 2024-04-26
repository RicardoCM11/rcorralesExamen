using System.Globalization;

namespace rcorralesExamen.Vistas;

public partial class VentanaResumen : ContentPage
{
	public VentanaResumen(String nombre,string apellido, string edad, 
		string fecha, string pais, string cuidad, string montoinicial, string pmensual, string usa)
	{
		InitializeComponent();
        lbusuarioo.Text = usa;
		lbnombre.Text = nombre;
		lbpellido.Text = apellido;
		lbedad.Text = edad;
		lbfecha.Text = fecha;	
		lbpais.Text = pais;
		lbcuidad.Text = cuidad;
		lbmontoincial.Text = montoinicial;
		lbpmensual.Text = pmensual;
		
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new VistaLogin());
    }
}