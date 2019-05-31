using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class MantenimientoArea : Form
    {
        manttoArea manArea = new manttoArea();

        public MantenimientoArea()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            this.ClientSize = new System.Drawing.Size(397, 150);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            manArea.Area = txtCodigoArea.Text;
            manArea.Descripcion = txtDescripcionArea.Text;

            manArea.insertarArea();
            limpiar();
            cargar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            manArea.dt.Clear();
            dataGridView1.Refresh();
            manArea.mostrarArea();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = manArea.dt;
            this.ClientSize = new System.Drawing.Size(397, 305);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            manArea.Area = txtCodigoArea.Text;
            manArea.Descripcion = txtDescripcionArea.Text;
            manArea.deleteArea();
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            manArea.Area = txtCodigoArea.Text;
            manArea.Descripcion = txtDescripcionArea.Text;
            manArea.updateArea();
            limpiar();
        }

        public void cargar()
        {
            manArea.dt.Clear();
            dataGridView1.Refresh();
            manArea.mostrarArea();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = manArea.dt;
            this.ClientSize = new System.Drawing.Size(397, 305);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
