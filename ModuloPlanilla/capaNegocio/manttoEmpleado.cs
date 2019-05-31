using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class manttoEmpleado
    {
        bdConex test = new bdConex();
        public DataTable dataPuesto = new DataTable();
        public DataTable dataArea = new DataTable();
        public DataTable dataDepa = new DataTable();
        public DataTable dataEstado = new DataTable();
        public DataTable dataSexo = new DataTable();
        public DataTable dataNomina = new DataTable();

        //Declaracion de Variables
        String idEmpleado, nombre1, nombre2, apellido1, apellido2, apellido3, dui, telefono, correo, direccion, cuentaBanco, area, idEstado, fechaIngreso, fechaSalida;
        int idDepartamento, idPuesto, idNomina, idMarcacion, idSexo;
        double salarioReferencia;

        public void insertarEmpleado()
        {
            try
            {
                String insert = "insert into EMPLEADOS" 
                    //Campos de la tabla
                + "(ID_EMPLEADO, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, APELLIDO_3, DUI, TELEFONO, E_MAIL, DIRECCION," 
                + " FECHA_INGRESO, FECHA_SALIDA, SALARIO_REFERENCIA, CUENTA_BANCO, AREA, ID_DEPART, ID_ESTADO, ID_PUESTO, ID_NOMINA, ID_MARCACION, ID_SEXO)"
                //Asignacion de valores
                + "values('" + idEmpleado + "', '" + nombre1 + "', '" + nombre2 + "', '" + apellido1 + "', '" + apellido2 + "', '" + apellido3 + "',  '" + dui + "', '" + telefono + "',  '" + correo + "', '" + direccion + "',"
                + " '" + fechaIngreso + "', '" + fechaSalida + "', " + salarioReferencia + ", '" + cuentaBanco + "', '" + area + "', " + idDepartamento + ", '" + idEstado + "', " + idPuesto + ", " + idNomina + ", " + idMarcacion + ", " + idSexo + ");";

                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void deleteEmpleado()
        {
            try
            {
                String delete = "delete from EMPLEADOS where ID_EMPLEADO = '" + idEmpleado + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {
            }
        }

#region GET y SET
        public double SalarioReferencia
        {
            get { return salarioReferencia; }
            set { salarioReferencia = value; }
        }

        public String FechSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        public String FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public int IdSexo
        {
            get { return idSexo; }
            set { idSexo = value; }
        }

        public int IdMarcacion
        {
            get { return idMarcacion; }
            set { idMarcacion = value; }
        }

        public int IdNomina
        {
            get { return idNomina; }
            set { idNomina = value; }
        }

        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }
        }

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }
        public String IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        public String Area
        {
            get { return area; }
            set { area = value; }
        }

        public String CuentaBanco
        {
            get { return cuentaBanco; }
            set { cuentaBanco = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public String Apellido3
        {
            get { return apellido3; }
            set { apellido3 = value; }
        }

        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public String Nombre2
        {
            get { return nombre2; }
            set { nombre2 = value; }
        }

        public String Nombre1
        {
            get { return nombre1; }
            set { nombre1 = value; }
        }

        public String IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
#endregion
#region Llenar ComboBox
        public void mostrarPuesto()
        {
            try
            {
                String consulta = "select * from PUESTO";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dataPuesto);
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
                test.da.Fill(dataArea);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void mostrarDepartamento()
        {
            try
            {
                String consulta = "select * from DEPARTAMENTO";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dataDepa);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void mostrarEstado()
        {
            try
            {
                String consulta = "select * from ESTADO_EMPLEADO";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dataEstado);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void mostrarSexo()
        {
            try
            {
                String consulta = "select * from SEXO";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dataSexo);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void mostrarNomina()
        {
            try
            {
                String consulta = "select * from NOMINA";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dataNomina);
                test.Desconectar();
            }
            catch
            {
            }
        }
#endregion
    }
}
