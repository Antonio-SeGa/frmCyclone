using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace frmCyclone.CapaAccesoDatos
{
    class AD_Login
    {
        //Otra forma de conectarse
        private static SqlConnection conexion = new SqlConnection();
        private static string cadConexion = @"Data Source=LAPTOP-ANTONIO\SQLEXPRESS2020;Initial Catalog=cyclone;User ID=sa;Password=server";

        public static void abrirConexionCyclone()
        {
            conexion.ConnectionString = cadConexion;
            conexion.Open();
        }
        public static void cerrarConexionCyclone()
        {
            conexion.Close();
        }
        //Finaliza la froma de conectarse

        //Metodo de logueo
        public static string logueo(string user, string password)
        {
            int logueado = 0;
            string mensaje = string.Empty;
            abrirConexionCyclone();
            SqlCommand cmdLogin = new SqlCommand();
            cmdLogin.CommandText = "sp_Login";
            cmdLogin.Connection = conexion;
            cmdLogin.CommandType = CommandType.StoredProcedure;

            cmdLogin.Parameters.Add(new SqlParameter("@user", user));
            cmdLogin.Parameters.Add(new SqlParameter("@password", password));

            SqlParameter parLogueado = new SqlParameter("@logueado", 0);
            parLogueado.Direction = ParameterDirection.Output;
            cmdLogin.Parameters.Add(parLogueado);

            SqlParameter parMensaje = new SqlParameter("@mensaje", SqlDbType.VarChar);
            parMensaje.Direction = ParameterDirection.Output;
            parMensaje.Size = 30;
            cmdLogin.Parameters.Add(parMensaje);

            cmdLogin.ExecuteNonQuery();
            cerrarConexionCyclone();

            logueado = Int32.Parse(cmdLogin.Parameters["@logueado"].Value.ToString());
            if (logueado > 0)
            {
                mensaje = cmdLogin.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else return mensaje;
        }
    }
}
