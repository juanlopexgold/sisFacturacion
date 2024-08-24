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
    public partial class FormProducto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormProducto()
        {
            InitializeComponent();

            toolTip1.SetToolTip(comboNombres, "Celecione el nombre del producto");
            toolTip1.SetToolTip(comboCategorias, "Ingrese la categoria del producto");
            toolTip1.SetToolTip(comboMarcas, "Ingrese el marca del producto");
            toolTip1.SetToolTip(comboUMedida, "Ingrese la unidad de medida");
            toolTip1.SetToolTip(textDescripcion, "Ingrese la descripcion");
            toolTip1.SetToolTip(comboEstado, "Ingrese precio estado");

            toolTip1.SetToolTip(iconNuevo, "Nuevo Registro");
            toolTip1.SetToolTip(iconRegistrar, "Guardar Registro");
            toolTip1.SetToolTip(iconActualizar, "Actualizar Registro");
            toolTip1.SetToolTip(iconCancelar, "Cancelar Operacion");
            toolTip1.SetToolTip(iconEliminar, "Eliminar Registro");
            toolTip1.SetToolTip(iconBuscar, "Buscar Registro");
            toolTip1.SetToolTip(iconImprimir, "Imprimir Informe");

            llenarComboNombre();
            llenarComboCategoria();
            llenarComboMarca();
            llenarComboUnidadMedida();
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
            comboNombres.Text = string.Empty;
            comboCategorias.Text = string.Empty;
            comboMarcas.Text = string.Empty;
            comboUMedida.Text = string.Empty;
            textDescripcion.Text = string.Empty;
            comboEstado.Text = string.Empty;
        }

        // Habilitar los controles
        private void Habilitar(bool valor)
        {
            comboNombres.Enabled = valor;
            comboCategorias.Enabled = valor;
            comboMarcas.Enabled = valor;
            comboUMedida.Enabled = valor;
            textDescripcion.ReadOnly = !valor;
            textID.ReadOnly = !valor;
            comboEstado.Enabled = valor;
        }

        // Habilitar los botones
        private void HabilitarBotones()
        {
            if (IsNuevo || IsEditar)
            {
                Habilitar(true);
                iconNuevo.Enabled = false;
                iconActualizar.Enabled = false;
                iconRegistrar.Enabled = true;
                iconCancelar.Enabled = true;
            }
            else
            {
                Habilitar(false);
                iconNuevo.Enabled = true;
                iconActualizar.Enabled = true;
                iconRegistrar.Enabled = false;
                iconCancelar.Enabled = false;
            }
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

        //LLenar comboBox
        private void llenarComboNombre()
        {
            comboNombres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNombres.DataSource = CN_NProducto.Mostrar();

            comboNombres.DisplayMember = "NOMBRE_PRODUCTO";
            comboNombres.SelectedIndex = -1;
        }

        private void llenarComboMarca()
        {
            comboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMarcas.DataSource = CN_Marcas.Mostrar();

            comboMarcas.DisplayMember = "NOMBRE_MARCA";
            comboMarcas.SelectedIndex = -1;
        }

        private void llenarComboCategoria()
        {
            comboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategorias.DataSource = CN_Categorias.Mostrar();

            comboCategorias.DisplayMember = "NOMBRE_CATEGORIA";
            comboCategorias.SelectedIndex = -1;
        }

        private void llenarComboUnidadMedida()
        {
            comboUMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUMedida.DataSource = CN_UMedida.Mostrar();

            comboUMedida.DisplayMember = "UNIDAD_MEDIDA";
            comboUMedida.SelectedIndex = -1;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostraColumnas();
            Habilitar(false);
            HabilitarBotones();

            MessageBox.Show("Las operaciones CRUD de ste formulario no funcionan por el momento 'solo funciona mostrar'");

            // Mostrar y crear todos los estados
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.Items.Add(new ObcionesCombo() { valor = 1, texto = "Activo" });
            comboEstado.Items.Add(new ObcionesCombo() { valor = 0, texto = "No Activo" });

            comboEstado.DisplayMember = "texto";
            comboEstado.ValueMember = "valor";
            comboEstado.SelectedIndex = -1;
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void iconNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            HabilitarBotones();
            Limpiar();
            Habilitar(true);
            comboNombres.Focus();
        }

        private void iconRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string repuesta = "";
                if (comboNombres.Text == string.Empty || comboCategorias.Text == string.Empty
                    || comboMarcas.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos");
                    errorIcono.SetError(comboNombres, "Seleccione un valor");
                    errorIcono.SetError(comboCategorias, "Seleccione un valor");
                    errorIcono.SetError(comboMarcas, "Seleccione un valor");
                }
                else
                {
                    if (IsNuevo)
                    {
                        repuesta = CN_Producto.Insertar(
                            Convert.ToInt32(comboNombres.SelectedValue),
                            Convert.ToInt32(comboCategorias.SelectedValue),
                            Convert.ToInt32(comboMarcas.SelectedValue),
                            textDescripcion.Text.Trim(),
                            Convert.ToInt32(comboUMedida.SelectedValue),
                            Convert.ToInt32(((ObcionesCombo)comboEstado.SelectedItem).valor) == 1 ? true : false);
                    }
                    else
                    {
                        repuesta = CN_Producto.Actualizar(
                            Convert.ToInt32(textID.Text),
                            Convert.ToInt32(comboNombres.SelectedValue),
                            Convert.ToInt32(comboCategorias.SelectedValue),
                            Convert.ToInt32(comboMarcas.SelectedValue),
                            textDescripcion.Text.Trim(),
                            Convert.ToInt32(comboUMedida.SelectedValue),
                            Convert.ToInt32(((ObcionesCombo)comboEstado.SelectedItem).valor) == 1 ? true : false);
                    }

                    if (repuesta.Equals("OK"))
                    {
                        if (IsNuevo)
                        {
                            MensajeOk("El registro se realizo con exito");
                        }
                        else
                        {
                            MensajeOk("La actualizacion se realizo con exito");
                        }
                    }
                    else
                    {
                        MensajeError(repuesta);
                    }
                    IsNuevo = false;
                    IsEditar = false;
                    HabilitarBotones();
                    Limpiar();
                    MostraColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataGridListado_DoubleClick(object sender, EventArgs e)
        {
            textID.Text = Convert.ToString(dataGridListado.CurrentRow.Cells["ID_PRODUCTO"].Value);
            comboNombres.SelectedValue = Convert.ToString(dataGridListado.CurrentRow.Cells["ID_NPRODUCTO"].Value);
            comboCategorias.SelectedValue = Convert.ToString(dataGridListado.CurrentRow.Cells["ID_CATEGORIA"].Value);
            comboMarcas.SelectedValue = Convert.ToString(dataGridListado.CurrentRow.Cells["ID_MARCA"].Value);
            textDescripcion.Text = Convert.ToString(dataGridListado.CurrentRow.Cells["DESCRIPCION"].Value);
            comboUMedida.SelectedValue = Convert.ToString(dataGridListado.CurrentRow.Cells["ID_UMEDIDA"].Value);
            comboEstado.Text = Convert.ToString(dataGridListado.CurrentRow.Cells["ESTADO"].Value);
        }

        private void iconActualizar_Click(object sender, EventArgs e)
        {
            if (!textID.Text.Equals(""))
            {
                IsEditar = true;
                HabilitarBotones();
                Habilitar(true);
            }
            else
            {
                MensajeError("Debe seleccionar un registro para modificar");
            }
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            IsEditar = false;
            HabilitarBotones();
            Limpiar();
            Habilitar(false);
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                dataGridListado.Columns[0].Visible = true;
            }
            else
            {
                dataGridListado.Columns[0].Visible = false;
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
                            respu = CN_Producto.Eliminar(Convert.ToInt32(codigo));

                            if (respu.Equals("OK"))
                            {
                                MensajeOk("El registro se elimino con exito");
                            }
                            else
                            {
                                MensajeError(respu);
                            }
                        }
                    }
                    MostraColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
