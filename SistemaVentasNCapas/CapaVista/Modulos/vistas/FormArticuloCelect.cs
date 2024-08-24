using CapaNegocio.CNMetodos;
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

namespace CapaVista.Modulos.vistas
{
    public partial class FormArticuloCelect : Form
    {
        public FormArticuloCelect()
        {
            InitializeComponent();
        }

        // Ocultar columnas
        private void OcultarColumnas()
        {
            dataGridListado.Columns[0].Visible = false;
            dataGridListado.Columns[1].Visible = false;
            dataGridListado.Columns[2].Visible = false;
            dataGridListado.Columns[4].Visible = false;
            dataGridListado.Columns[6].Visible = false;
            dataGridListado.Columns[9].Visible = false;
        }

        // Mostrar columnas
        private void MostraColumnas()
        {
            dataGridListado.DataSource = CN_Producto.Mostrar();
            OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        // Buscar Por nombre
        private void BuscarPor()
        {
            dataGridListado.DataSource = CN_Producto.Buscar_nombre(textBusqueda.Text);
            OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        private void FormArticuloCelect_Load(object sender, EventArgs e)
        {
            MostraColumnas();
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void dataGridListado_DoubleClick(object sender, EventArgs e)
        {
            FormCompras form = FormCompras.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ID_PRODUCTO"].Value);
            par2 = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ID_NPRODUCTO"].Value);
            form.SetArticulo(par1, par2);
            this.Hide();
        }
    }
}
