using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importarlibrerias
using CapaNegocio.CNMetodos;
using CapaVista.Utilidades;

namespace CapaVista.Modulos.CRUDConfig
{
    public partial class FormTrabajadores : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormTrabajadores()
        {
            InitializeComponent();

            this.toolTip1.SetToolTip(this.textNombre, "Ingrese el nombre del producto");
            this.toolTip1.SetToolTip(this.iconNuevo, "Nuevo Registro");
            this.toolTip1.SetToolTip(this.iconRegistrar, "Guardar Registro");
            this.toolTip1.SetToolTip(this.iconActualizar, "Actualizar Registro");
            this.toolTip1.SetToolTip(this.iconCancelar, "Cancelar Operacion");
            this.toolTip1.SetToolTip(this.iconEliminar, "Eliminar Registro");
            this.toolTip1.SetToolTip(this.iconBuscar, "Buscar Registro");
            this.toolTip1.SetToolTip(this.iconImprimir, "Imprimir Informe");
        }

        // Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Limpíar los controles
        private void Limpiar()
        {
            this.textNombre.Text = string.Empty;
            this.textApellidoP.Text = string.Empty;
            this.textApellidoM.Text = string.Empty;
            this.textDireccion.Text = string.Empty;
            this.textUsuario.Text = string.Empty;
            this.textIdentificaion.Text = string.Empty;
            this.textEmail.Text = string.Empty;
            this.textUsuario.Text = string.Empty;
            this.textClave.Text = string.Empty;
            this.textID.Text = string.Empty;
        }

        // Habilitar los controles
        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textApellidoP.ReadOnly = !valor;
            this.textApellidoM.ReadOnly = !valor;
            this.textDireccion.ReadOnly = !valor;
            this.textUsuario.ReadOnly = !valor;
            this.textIdentificaion.ReadOnly = !valor;
            this.textEmail.ReadOnly = !valor;
            this.textUsuario.ReadOnly = !valor;
            this.textClave.ReadOnly = !valor;
            this.comboBGenero.Enabled = valor;
            this.comboAcceso.Enabled = valor;
            this.textID.ReadOnly = !valor;
        }

        // Habilitar los botones
        private void HabilitarBotones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.iconNuevo.Enabled = false;
                this.iconActualizar.Enabled = false;
                this.iconRegistrar.Enabled = true;
                this.iconCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.iconNuevo.Enabled = true;
                this.iconActualizar.Enabled = true;
                this.iconRegistrar.Enabled = false;
                this.iconCancelar.Enabled = false;
            }
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

        private void FormTrabajadores_Load(object sender, EventArgs e)
        {
            this.MostraColumnas();
            this.Habilitar(false);
            this.HabilitarBotones();

            this.comboBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboAcceso.DropDownStyle = ComboBoxStyle.DropDownList;
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
            if (comboBuscar.Text == "Nombres")
            {
                this.BuscarPor();
            }
            else if (comboBuscar.Text == "Apellido Paterno")
            {
                this.BuscarPorApellidoP();
            }
            else if (comboBuscar.Text == "Apellido Materno")
            {
                this.BuscarPorApellidoM();
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Obcion;
                Obcion = MessageBox.Show("Realmente desea eliminar este registro", "Sistema de facturacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Obcion == DialogResult.OK)
                {
                    string codigo;
                    string respu = "";

                    foreach (DataGridViewRow row in dataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respu = CN_Trabajador.Eliminar(Convert.ToInt32(codigo));

                            if (respu.Equals("OK"))
                            {
                                this.MensajeOk("El registro se elimino con exito");
                            }
                            else
                            {
                                this.MensajeError(respu);
                            }
                        }
                    }
                    this.MostraColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkEliminar.Checked)
            {
                this.dataGridListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataGridListado.Columns[0].Visible = false;
            }
        }

        private void dataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataGridListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dataGridListado_DoubleClick(object sender, EventArgs e)
        {
            this.textID.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ID_EMPLEADO"].Value);
            this.textNombre.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["NOMBRES"].Value);
            this.textApellidoP.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["APELLIDOPATERNO"].Value);
            this.textApellidoM.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["APELLIDOMATERNO"].Value);
            this.comboBGenero.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["GENERO"].Value);
            this.dateTimeFeNac.Value = Convert.ToDateTime(this.dataGridListado.CurrentRow.Cells["FECHA_NAC"].Value);
            this.textIdentificaion.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["N_IDENTIFICACION"].Value);
            this.textDireccion.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["DIRECCION"].Value);
            this.textTelefono.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["TELEFONO"].Value);
            this.textEmail.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["EMAIL"].Value);
            this.comboAcceso.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ACCESO"].Value);
            this.textUsuario.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["USUARIO"].Value);
            this.textClave.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["CLAVE"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void iconNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(true);
            this.textNombre.Focus();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
            this.textID.Text = string.Empty;
        }

        private void iconRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string repuesta = "";
                if (this.textNombre.Text == string.Empty || this.textApellidoP.Text == string.Empty || this.textApellidoM.Text == string.Empty
                    || this.textDireccion.Text == string.Empty || this.textUsuario.Text == string.Empty || this.textClave.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos");
                    errorIcono.SetError(textNombre, "Ingrese el nombre");
                    errorIcono.SetError(textApellidoP, "Ingrese el primer apellido");
                    errorIcono.SetError(textApellidoM, "Ingrese el segundo apellido");
                    errorIcono.SetError(textDireccion, "Ingrese la direccion");
                    errorIcono.SetError(textUsuario, "Ingrese el nombre de usuario");
                    errorIcono.SetError(textClave, "Ingrese su contraseña");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        repuesta = CN_Trabajador.Insertar(
                            this.textNombre.Text.Trim().ToUpper(),
                            this.textApellidoP.Text.Trim().ToUpper(),
                            this.textApellidoM.Text.Trim().ToUpper(),
                            this.comboBGenero.Text, 
                            this.dateTimeFeNac.Value,
                            this.textIdentificaion.Text,
                            this.textDireccion.Text,
                            this.textTelefono.Text,
                            this.textEmail.Text,
                            this.comboAcceso.Text,
                            this.textUsuario.Text,
                            this.textClave.Text);
                    }
                    else
                    {
                        repuesta = CN_Trabajador.Actualizar(
                            Convert.ToInt32(this.textID.Text),
                            this.textNombre.Text.Trim().ToUpper(),
                            this.textApellidoP.Text.Trim().ToUpper(),
                            this.textApellidoM.Text.Trim().ToUpper(),
                            this.comboBGenero.Text,
                            this.dateTimeFeNac.Value,
                            this.textIdentificaion.Text,
                            this.textDireccion.Text,
                            this.textTelefono.Text,
                            this.textEmail.Text,
                            this.comboAcceso.Text,
                            this.textUsuario.Text,
                            this.textClave.Text);
                    }

                    if (repuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("El registro se realizo con exito");
                        }
                        else
                        {
                            this.MensajeOk("La actualizacion se realizo con exito");
                        }
                    }
                    else
                    {
                        this.MensajeError(repuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.HabilitarBotones();
                    this.Limpiar();
                    this.MostraColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void iconActualizar_Click(object sender, EventArgs e)
        {
            if (!this.textID.Text.Equals(""))
            {
                this.IsEditar = true;
                this.HabilitarBotones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar un registro para modificar");
            }
        }
    }
}
