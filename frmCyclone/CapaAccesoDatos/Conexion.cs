using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace frmCyclone.CapaAccesoDatos
{
    class Conexion
    {
        public SqlConnection conexionCiclone()
        {            
            //Se crea la cadena de conexion
            SqlConnection connCyclone = new SqlConnection(ConfigurationManager.ConnectionStrings["cadConnCyclone"].ConnectionString);                       

            if (connCyclone.State == ConnectionState.Open)
            {
                //Cerrar la conexion
                connCyclone.Close();
            }
            else {
                //abrir la conexion 
                connCyclone.Open();
            } 
            //Retornar la conexion
            return connCyclone;
        }

    }
}
