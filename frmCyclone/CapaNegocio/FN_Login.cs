using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Debe controlar el proceso de logeo
//Debe controlar los formularios que se abren
namespace frmCyclone.CapaNegocio
{
    class FN_Login
    {
        private string datosLogin = string.Empty;
        private bool logueado = false;
        public string nombreUser { get; set; }
        public string userPass { get; set; }

        public FN_Login() { }
        public FN_Login(string nombreUser, string userPass)
        {
            this.nombreUser = nombreUser;
            this.userPass = userPass;
        }

        public void parLogueo(string nombreUser, string userPass)
        {
            //mandar los parametros
            datosLogin = CapaAccesoDatos.AD_Login.logueo(nombreUser, userPass);

            //Verificar datos
            if (datosLogin != "")
            {
                logueado = !logueado;

                MessageBox.Show(datosLogin,
                                "Login Suceso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);     
            }
            else {
                MessageBox.Show("Error a loguearse",
                                "Login Suceso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        //retornar el valor de logeado
        public bool log() { return logueado; }
    }
}
