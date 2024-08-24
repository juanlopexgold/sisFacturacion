using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class fmrLoging : Form
    {
        public fmrLoging()
        {
            InitializeComponent();
            labelHora.Text = DateTime.Now.ToString();
        }

        private void fmrLoging_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.CNMetodos.CN_Trabajador.Login(this.textUsuario.Text, textClave.Text);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al sistema","SIS Facturacion abarroteria",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                fmrInicio fmr = new fmrInicio();
                fmr.idEmpleado = Datos.Rows[0][0].ToString();
                fmr.apellido = Datos.Rows[0][1].ToString();
                fmr.nombre = Datos.Rows[0][2].ToString();
                fmr.acceso = Datos.Rows[0][3].ToString();

                fmr.Show();
                this.Hide();
            }
        }
    }
}
