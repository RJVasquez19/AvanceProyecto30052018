using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class manttoArea
    {
        bdConex test = new bdConex();
        public String prueba()
        {
            String mensaje;

            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;
        }
        String area, descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Area
        {
            get { return area; }
            set { area = value; }
        }

        public DataTable dt = new DataTable();

        public void insertarArea()
        {
            try
            {
                String insert = "insert into AREA(AREA, DESCRIPCION) values('" + area + "','" + descripcion + "');";

                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void deleteArea()
        {
            try
            {
                String delete = "delete from AREA where AREA = '" + area + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void updateArea()
        {
            try
            {
                String update = "update AREA set DESCRIPCION='" + descripcion + "' where AREA='" + area + "'";

                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void mostrarArea()
        {
            try
            {
                String consulta = "select * from AREA";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {
            }
        }
    }

}
