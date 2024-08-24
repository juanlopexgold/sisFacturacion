using CapaVista.Modulos.CRUDCompras;
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
    public partial class fmrCompras : Form
    {
        public fmrCompras()
        {
            InitializeComponent();
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
            FormCompras form = FormCompras.GetInstancia();
            form.MdiParent = this;
            form.Show();

        }
    }
}
