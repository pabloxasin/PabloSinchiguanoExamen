using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PabloSinchiguanoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        String usuarioN = null;
        String nombreN = null;
        double montoN = 0;
        public Resumen(String usuario,String nombre, double monto,double mensual)
        {
            InitializeComponent();
            lblUsuario.Text ="Usuario: "+usuario;
            lblNombre.Text = "Nombre: "+nombre;
            lblTotal.Text = "Pago diferido a tres meses: "+monto.ToString();
            lblMensual.Text = "Pago mensual de: " + mensual.ToString();
        }

        private void btnImprimir_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Almacenamiento", "Elemento Guardado con exito", "ACEPTAR");
        }
    }
}