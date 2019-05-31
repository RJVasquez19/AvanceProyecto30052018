using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class MantenimientoEmpleado : Form
    {
        manttoEmpleado objEmp = new manttoEmpleado();

        public MantenimientoEmpleado()
        {
            InitializeComponent();

            //Combobox Area
            objEmp.dataArea.Clear();
            cbbArea.Refresh();
            cbbArea.DataSource = null;
            objEmp.mostrarArea();
            cbbArea.DataSource = objEmp.dataArea;
            cbbArea.ValueMember = "AREA";
            cbbArea.DisplayMember = "DESCRIPCION";

            //Combobox Puesto
            objEmp.dataPuesto.Clear();
            cbbPuesto.Refresh();
            cbbPuesto.DataSource = null;
            objEmp.mostrarPuesto();
            cbbPuesto.DataSource = objEmp.dataPuesto;
            cbbPuesto.ValueMember = "ID_PUESTO";
            cbbPuesto.DisplayMember = "PUESTO";

            //Combobox Departamento
            objEmp.dataDepa.Clear();
            cbbDepartamento.Refresh();
            cbbDepartamento.DataSource = null;
            objEmp.mostrarDepartamento();
            cbbDepartamento.DataSource = objEmp.dataDepa;
            cbbDepartamento.ValueMember = "ID_DEPART";
            cbbDepartamento.DisplayMember = "DEPARTAMENTO";

            //Combobox Estado Usuario
            objEmp.dataEstado.Clear();
            cbbEstado.Refresh();
            cbbEstado.DataSource = null;
            objEmp.mostrarEstado();
            cbbEstado.DataSource = objEmp.dataEstado;
            cbbEstado.ValueMember = "ID_ESTADO";
            cbbEstado.DisplayMember = "ESTADO";

            //Combobox Sexo
            objEmp.dataSexo.Clear();
            cbbSexo.Refresh();
            cbbSexo.DataSource = null;
            objEmp.mostrarSexo();
            cbbSexo.DataSource = objEmp.dataSexo;
            cbbSexo.ValueMember = "ID_SEXO";
            cbbSexo.DisplayMember = "DESCRIPCION";

            //Combobox Nomina
            objEmp.dataNomina.Clear();
            cbbNomina.Refresh();
            cbbNomina.DataSource = null;
            objEmp.mostrarNomina();
            cbbNomina.DataSource = objEmp.dataNomina;
            cbbNomina.ValueMember = "ID_NOMINA";
            cbbNomina.DisplayMember = "DESCRIPCION";
        }

        private void MantenimientoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cbbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ModuloPlanilla mp = new ModuloPlanilla();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEmp.IdEmpleado = txtCodigoEmpleado.Text;
            objEmp.Nombre1 = txtPrimerNombre.Text;
            objEmp.Nombre2 = txtSegundoNombre.Text;
            objEmp.Apellido1 = txtPrimerApellido.Text;
            objEmp.Apellido2 = txtSegundoApellido.Text;
            objEmp.Apellido3 = txtApellidoCasada.Text;
            objEmp.Dui = txtDui.Text;
            objEmp.Telefono = txtTelefono.Text;
            objEmp.Correo = txtCorreo.Text;
            objEmp.Direccion = txtDireccion.Text;
            objEmp.FechaIngreso = dTPFechaIngreso.Value.Date.ToShortDateString();
            objEmp.FechSalida = dTPFechaSalida.Value.Date.ToShortDateString();
            objEmp.SalarioReferencia = double.Parse(txtSalario.Text);
            objEmp.CuentaBanco = txtCuentaBanco.Text;
            objEmp.Area = cbbArea.SelectedValue.ToString();
            objEmp.IdDepartamento = int.Parse(cbbDepartamento.SelectedValue.ToString());
            objEmp.IdEstado = cbbEstado.SelectedValue.ToString();
            objEmp.IdPuesto = int.Parse(cbbPuesto.SelectedValue.ToString());
            objEmp.IdNomina = int.Parse(cbbNomina.SelectedValue.ToString());
            objEmp.IdMarcacion = int.Parse(txtMarcacion.Text);
            objEmp.IdSexo = int.Parse(cbbSexo.SelectedValue.ToString());

            objEmp.insertarEmpleado();
            limpiar();
        }

        public void limpiar()
        {
            txtCodigoEmpleado.Text = " ";
            txtPrimerNombre.Text = " ";
            txtSegundoNombre.Text = " ";
            txtPrimerApellido.Text = " ";
            txtSegundoApellido.Text = " ";
            txtApellidoCasada.Text = " ";
            txtDui.Text = " ";
            txtTelefono.Text = " ";
            txtCorreo.Text = " ";
            txtDireccion.Text = " ";
            dTPFechaIngreso.Value = DateTime.Now;
            dTPFechaSalida.Value = DateTime.Now;
            txtSalario.Text = " ";
            txtCuentaBanco.Text = " ";
            cbbArea.SelectedIndex = 0;
            cbbDepartamento.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
            cbbPuesto.SelectedIndex = 0;
            cbbNomina.SelectedIndex = 0;
            txtMarcacion.Text = " ";
            cbbSexo.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objEmp.IdEmpleado = txtCodigoEmpleado.Text;
            objEmp.deleteEmpleado();
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        
    }
}
