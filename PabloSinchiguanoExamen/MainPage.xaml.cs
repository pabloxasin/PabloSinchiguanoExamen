using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PabloSinchiguanoExamen
{
    
    public partial class Registro : ContentPage
    {
        double Costo = 1800;
        double porcentajeCosto = 0;
        double cuota = 0;
        double montoInicial = 0;
        String usuario = null;
        public Registro(String nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            lblNombreUsuario.Text ="Usuario conectado: "+ usuario;
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //acciones del programa
                porcentajeCosto = Costo * 0.05;
                montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                if (montoInicial>0 && montoInicial<=Costo && montoInicial!=Costo)
                {
                    cuota = ((Costo - montoInicial) / 3) + porcentajeCosto;
                    txtPagoMensual.Text=cuota.ToString();
                    DisplayAlert("A CANCELAR", "3 CUOTAS DE: "+ cuota.ToString(), "ACEPTAR");
                }
                else if (montoInicial == Costo)
                {
                    DisplayAlert("ALERTA", "Curso cancelado", "ACEPTAR");
                }
                else
                {
                    DisplayAlert("ALERTA", "Monto inicial Incorrecto", "ACEPTAR");
                }
            }
            catch (Exception ex)
            {
                //excepciones
                DisplayAlert("ALERTA", ex.Message, "ACEPTAR");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text==null || txtMontoInicial.Text==null)
            {
                DisplayAlert("Alerta", "Ingrese los datos", "ACEPTAR");
                
            }
            else
            {
                await Navigation.PushAsync(new Resumen(usuario, txtNombre.Text, Costo - montoInicial, cuota));
            }
        }
    }
}
