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
    public partial class ModuloPlanilla : Form
    {
        private int childFormNumber = 0;

        public ModuloPlanilla()
        {
            InitializeComponent();
            menuStrip1.Hide();
            panelPrincipal.Dock = DockStyle.Fill;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Hide();
            MantenimientoArea mantoArea = new MantenimientoArea();
            mantoArea.StartPosition = FormStartPosition.CenterScreen;
            mantoArea.MdiParent = this;
            //mantoArea.Dock = DockStyle.Fill; 
            mantoArea.Show();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Hide();
            MantenimientoPuesto mantoPuesto = new MantenimientoPuesto();
            mantoPuesto.StartPosition = FormStartPosition.CenterScreen;
            mantoPuesto.MdiParent = this;
            //mantoPuesto.Dock = DockStyle.Fill; 
            mantoPuesto.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelPrincipal.Visible = false;
            MantenimientoEmpleado mantoEmpleado = new MantenimientoEmpleado();
            mantoEmpleado.StartPosition = FormStartPosition.CenterScreen;
            mantoEmpleado.MdiParent = this;
            //mantoEmpleado.Dock = DockStyle.Fill; 
            //panelPrincipal.SendToBack();
            mantoEmpleado.Show();
            //mantoEmpleado.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (txtUsuario.Text.Equals(login.Usuario) && txtContraseña.Text.Equals(login.Password))
            {
                menuStrip1.Visible = true;
                txtUsuario.Hide();
                txtContraseña.Hide();
                btnIngresar.Hide();
                btnSalir.Hide();
                pictureBox2.Hide();
                lblUsuario.Hide();
                lblPassword.Hide();
            }
            else 
            {
                MessageBox.Show("Error de usuario");
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
