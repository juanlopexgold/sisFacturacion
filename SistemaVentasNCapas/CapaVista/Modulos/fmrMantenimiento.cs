using CapaVista.Modulos.CRUDMantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Modulos
{
    public partial class fmrMantenimiento : Form
    {
        public fmrMantenimiento()
        {
            InitializeComponent();
        }

        private void fmrMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            contenedor.Controls.Add(FormularioHijo);
            contenedor.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormNombreProducto());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormMarcas());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormCategorias());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormUMedida());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormProducto());
        }
    }
}
