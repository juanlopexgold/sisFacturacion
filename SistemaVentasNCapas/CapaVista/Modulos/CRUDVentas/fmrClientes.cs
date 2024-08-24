using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Modulos.CRUDVentas
{
    public partial class fmrClientes : Form
    {
        public fmrClientes()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.iconRegistrar, "Registrar");
            this.toolTip1.SetToolTip(this.iconActualizar, "Actualizar");
            this.toolTip1.SetToolTip(this.iconLimpiar, "Limpiar");
            this.toolTip1.SetToolTip(this.iconEliminar, "Eliminar");
            this.toolTip1.SetToolTip(this.iconBuscar, "Eliminar");
            this.toolTip1.SetToolTip(this.iconLimpiar2, "Limpiar");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
