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

namespace CapaVista.Modulos.CRUDMantenimiento
{
    public partial class FormNombreProducto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormNombreProducto()
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
            this.textID.Text = string.Empty;
            this.comboEstado.Text = string.Empty;
        }

        // Habilitar los controles
        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
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
        }

        // Mostrar columnas
        private void MostraColumnas()
        {
            this.dataGridListado.DataSource = CN_NProducto.Mostrar();
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        // Buscar Por nombre
        private void BuscarPor()
        {
            this.dataGridListado.DataSource = CN_NProducto.Buscar_nombre(this.textBusqueda.Text);
            this.OcultarColumnas();
            labelTotal.Text = "Total de registros: " + Convert.ToString(dataGridListado.Rows.Count);
        }

        private void FormNombreProducto_Load(object sender, EventArgs e)
        {
            this.MostraColumnas();
            this.Habilitar(false);
            this.HabilitarBotones();

            // Mostrar y crear todos los estados
            //comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.Items.Add(new ObcionesCombo() { valor = 1, texto = "Activo" });
            comboEstado.Items.Add(new ObcionesCombo() { valor = 0, texto = "No Activo" });

            comboEstado.DisplayMember = "texto";
            comboEstado.ValueMember = "valor";
            comboEstado.SelectedIndex = 0;
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarPor();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.BuscarPor();
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

        private void iconRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string repuesta = "";
                if (this.textNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos");
                    errorIcono.SetError(textNombre, "Ingrese el nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        repuesta = CN_NProducto.Insertar(this.textNombre.Text.Trim().ToUpper(),
                            Convert.ToInt32(((ObcionesCombo)comboEstado.SelectedItem).valor) == 1 ? true : false);
                    }
                    else
                    {
                        repuesta = CN_NProducto.Actualizar(Convert.ToInt32(this.textID.Text),
                            this.textNombre.Text.Trim().ToUpper(),
                            Convert.ToInt32(((ObcionesCombo)comboEstado.SelectedItem).valor) == 1 ? true : false);
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

        private void dataGridListado_DoubleClick(object sender, EventArgs e)
        {
            this.textID.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ID_NPRODUCTO"].Value);
            this.textNombre.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["NOMBRE_PRODUCTO"].Value);
            this.comboEstado.Text = Convert.ToString(this.dataGridListado.CurrentRow.Cells["ESTADO"].Value);

            this.tabControl1.SelectedIndex = 1;
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

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
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
                            respu = CN_NProducto.Eliminar(Convert.ToInt32(codigo));

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
    }
}
