

using System.Globalization;

namespace rcorralesExamen.Vistas;


public partial class VistaRegistro : ContentPage
{
    

    public VistaRegistro(string us)
	{
		InitializeComponent();
        lblusuario.Text = "Usuario conectado: " + us;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string fecha = pickdate.Date.ToString("MM/dd/yyyy");
        string pais = pkpais.Items[pkpais.SelectedIndex].ToString();
        string cuidad = pkcuidad.Items[pkcuidad.SelectedIndex].ToString();
        double montoinicial = Convert.ToDouble(txtmontoinicial.Text);
        
        
        double costo = 1500;
        double cuota;
        double resta;
        double porcentaje;
        double total;
        double multiplicacion;
        double sum;

      

        if (montoinicial > costo)
        {
            DisplayAlert("Alerta", "El costo inicial no puede superar al costo total", "Cerrar");
        }
        else
        {

            resta = costo - montoinicial;
            cuota = resta / 4;
            porcentaje = cuota * 0.04;
            sum = cuota + porcentaje;
            multiplicacion = porcentaje * 4;
            total = resta + multiplicacion;
            

            lbfecha.Text = fecha;
            lbpais.Text = pais;
            lbcuidad.Text = cuidad;
            lbpagomensual.Text = Convert.ToString(sum);

        }
        

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        string edad = txtedad.Text;
        string fecha = lbfecha.Text;
        string pais = lbpais.Text;
        string cuidad = lbcuidad.Text;
        string montoinicial = txtmontoinicial.Text;
        string pmensual = lbpagomensual.Text;
        string usa = lblusuario.Text;

        if (nombre == null || apellido == null || edad ==null)
        {
            DisplayAlert("Alerta", "Los campos no estan llenos", "Cerrar");
        }

        else
        {
            Navigation.PushAsync(new VentanaResumen(nombre,apellido,edad,fecha,pais,cuidad,montoinicial,pmensual
                ,usa));
        }
    }
}