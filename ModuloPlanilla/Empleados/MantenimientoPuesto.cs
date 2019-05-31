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
    public partial class MantenimientoPuesto : Form
    {
        manttoPuesto objPuesto = new manttoPuesto();

        public MantenimientoPuesto()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(397, 179);

            //ComboBox
            objPuesto.mp.Clear();
            cbbArea.Refresh();
            cbbArea.DataSource = null;
            objPuesto.mostrarPuesto();
            cbbArea.DataSource = objPuesto.mp;
            cbbArea.ValueMember = "AREA";
            cbbArea.DisplayMember = "DESCRIPCION";
        }

        private void cbbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objPuesto.IdPuesto = int.Parse(txtCodigoPuesto.Text);
            objPuesto.Puesto = txtPuesto.Text;
            objPuesto.Area = cbbArea.SelectedValue.ToString();

            objPuesto.insertarPuesto();
            actualizar();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objPuesto.IdPuesto = int.Parse(txtCodigoPuesto.Text);
            objPuesto.Puesto = txtPuesto.Text;
            objPuesto.Area = cbbArea.SelectedValue.ToString();

            objPuesto.deletePuesto();
            actualizar();
        }

        public void cargar()
        {
            objPuesto.mp.Clear();
            objPuesto.mostrarPuesto();

        }

        public void actualizar()
        {
            objPuesto.mp.Clear();
            objPuesto.mostrarPuesto();

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ModuloPlanilla mp = new ModuloPlanilla();
            this.Close();
            mp.panelPrincipal.Visible = true;
        }
    }
}
