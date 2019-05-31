using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Login
    {
        //VARIABLES
        public DataTable dataLogin = new DataTable();
        String idUsuario, usuario = "Jesus", password = "123";


        //GET y SET
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }      

        public String IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


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

        //public void validarUsuario()
        //{
        //    try
        //    {
        //        String delete = "delete from AREA where AREA = '" + area + "'";
        //        test.Conectar();
        //        test.consultaSQL(delete);
        //        test.Desconectar();
        //    }
        //    catch
        //    {
        //    }
        //}


        //public void validar()
        //{
        //    try
        //    {
        //        String consulta = "select idUsuario from LOGIN where Usuario = '" + usuario + "' and Password = '" + password + "'";
        //        test.Conectar();
        //        test.mostrarSQL(consulta);
        //        test.da.Fill(dataLogin);
        //        test.Desconectar();
        //    }
        //    catch
        //    {
        //    }
        //}
        //public String Descripcion
        //{
        //    get { return descripcion; }
        //    set { descripcion = value; }
        //}

        //public String Area
        //{
        //    get { return area; }
        //    set { area = value; }
        }

        

        //public void insertarArea()
        //{
        //    try
        //    {
        //        String insert = "insert into AREA(AREA, DESCRIPCION) values('" + area + "','" + descripcion + "');";

        //        test.Conectar();
        //        test.consultaSQL(insert);
        //        test.Desconectar();
        //    }
        //    catch
        //    {
        //    }
        //}

        

        //public void updateArea()
        //{
        //    try
        //    {
        //        String update = "update AREA set DESCRIPCION='" + descripcion + "' where AREA='" + area + "'";

        //        test.Conectar();
        //        test.consultaSQL(update);
        //        test.Desconectar();
        //    }
        //    catch
        //    {
        //    }
        //}

        
    //}
}
