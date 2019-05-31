using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class bdConex
    {
        SqlDataAdapter adaptador;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        public SqlDataAdapter da;


        String cadenaConex = "Data Source=localhost;Initial Catalog=PrograI;Integrated Security=True";

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public bool Conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = cadenaConex;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }

            return conn;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public void consultaSQL(String consulta)
        {
            String mensaje = "";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";
            }
            catch (Exception e)
            {
                mensaje = "Error";
            }
        }

        public void mostrarSQL(String consulta)
        {
            String mensaje = "";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                da = new SqlDataAdapter(comando);
                mensaje = "Correctamente";
            }
            catch (Exception e)
            {
                mensaje = "Error";
            }
        }

    }
}
