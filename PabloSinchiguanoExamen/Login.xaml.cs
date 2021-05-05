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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private  async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2021";
            string clave = "uisrael2021";
            if (txtUsuario.Text.Equals(usuario) && txtClave.Text.Equals(clave))
            {
                String parametroUsuario = txtUsuario.Text;
                await Navigation.PushAsync(new Registro(parametroUsuario));
            }
            else
            {
                DisplayAlert("ALERTA", "DATOS INCORRECTOS", "ACEPTAR");
                txtUsuario.Text = "";
                txtClave.Text = "";
            }
        }
    }
}