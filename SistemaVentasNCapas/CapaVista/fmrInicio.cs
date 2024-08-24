using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.Modulos;
using MetroFramework.Forms;

namespace CapaVista
{
    public partial class fmrInicio : MetroForm
    {
        public string idEmpleado = "";
        public string apellido = "";
        public string nombre = "";
        public string acceso = "";
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void fmrInicio_Load(object sender, EventArgs e)
        {
            GestionAcceso();
        }

        // Mostrar_los_formularios_en_el_contenedor_principal
        private Form FormularioActivo = null;
        private void abrirFormulariosHijos(Form FormularioHijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            ContenedorPrincipal.Controls.Add(FormularioHijo);
            ContenedorPrincipal.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new fmrMantenimiento());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new fmrVentas());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new fmrConfiguraciones());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new fmrCompras());
        }

        private void GestionAcceso()
        {
            if(acceso == "Administrador")
            {
                this.iconButton1.Enabled = true;
                this.iconButton2.Enabled = true;
                this.iconButton4.Enabled = true;
                this.iconButton3.Enabled = true;
            }
            else if (acceso == "Vendedor")
            {
                this.iconButton1.Enabled = false;
                this.iconButton2.Enabled = true;
                this.iconButton4.Enabled = false;
                this.iconButton3.Enabled = false;
            }
            else
            {
                this.iconButton1.Enabled = false;
                this.iconButton2.Enabled = false;
                this.iconButton4.Enabled = false;
                this.iconButton3.Enabled = false;
            }
        }
    }
}
