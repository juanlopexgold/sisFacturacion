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
    public partial class FormProveedorVista : Form
    {
        public FormProveedorVista()
        {
            InitializeComponent();
        }

        private void FormProveedorVista_Load(object sender, EventArgs e)
        {
            this.MostraColumnas();
        }

        // Ocultar columnas
        private void OcultarColumnas()
        {
            this.dataGridListado.Columns[0].Visible = false;
            this.dataGridListado.Columns[1].Visible = false;
            this.dataGridListado.Columns[11].Visible = false;
            this.dataGridListado.Columns[13].Visible = false;
        }

        // Mostrar columnas
        private void MostraColumnas()
        {
            this.dataGridListado.DataSource = CN_Trabajador.Mostrar();
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        // Buscar Por nombre
        private void BuscarPor()
        {
            this.dataGridListado.DataSource = CN_Trabajador.Buscar_nombre(this.textBusqueda.Text);
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        private void BuscarPorApellidoP()
        {
            this.dataGridListado.DataSource = CN_Trabajador.Buscar_ApellidoP(this.textBusqueda.Text);
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        private void BuscarPorApellidoM()
        {
            this.dataGridListado.DataSource = CN_Trabajador.Buscar_ApellidoM(this.textBusqueda.Text);
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (comboBuscar.Text.Equals("Nombres"))
            {
                this.BuscarPor();
            }
            else if (comboBuscar.Text.Equals("Apellido Paterno"))
            {
                this.BuscarPorApellidoP();
            }
            else if (comboBuscar.Text.Equals("Apellido Materno"))
            {
                this.BuscarPorApellidoM();
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (comboBuscar.Text.Equals("Nombres"))
            {
                this.BuscarPor();
            }
            else if (comboBuscar.Text.Equals("Apellido Paterno"))
            {
                this.BuscarPorApellidoP();
            }
            else if (comboBuscar.Text.Equals("Apellido Materno"))
            {
                this.BuscarPorApellidoM();
            }
        }

        private void dataGridListado_DoubleClick(object sender, EventArgs e)
        {
            FormCompras form = FormCompras.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ID_EMPLEADO"].Value);
            par2 = Convert.ToString(this.dataGridListado.CurrentRow.Cells["NOMBRES"].Value);
            form.SetArticulo(par1, par2);
            this.Hide();
        }
    }
}
