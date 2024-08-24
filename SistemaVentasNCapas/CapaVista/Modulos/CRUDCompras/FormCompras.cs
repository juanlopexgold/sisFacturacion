using CapaVista.Modulos.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Modulos.CRUDCompras
{
    public partial class FormCompras : Form
    {
        public int IdEmplado;
        private static FormCompras _instancia;

        public static FormCompras GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FormCompras();
            }
            return _instancia;
        }

        public void SetProveedor(string IdProveedor, string nombre)
        {
            this.textID.Text = IdProveedor;
            this.textProveedor.Text = nombre;
        }

        public void SetArticulo(string IdArticulo, string nombre)
        {
            this.textIdArticulo.Text = IdArticulo;
            this.textProducto.Text = nombre;
        }
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormProveedorVista vista = new FormProveedorVista();
            vista.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormArticuloCelect vista = new FormArticuloCelect();
            vista.ShowDialog();
        }
    }
}
