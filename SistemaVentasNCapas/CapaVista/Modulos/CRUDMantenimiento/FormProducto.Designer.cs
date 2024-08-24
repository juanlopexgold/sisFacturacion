
namespace CapaVista.Modulos.CRUDMantenimiento
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconImprimir = new FontAwesome.Sharp.IconButton();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.productoID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            this.iconActualizar = new FontAwesome.Sharp.IconButton();
            this.iconRegistrar = new FontAwesome.Sharp.IconButton();
            this.iconNuevo = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.comboUMedida = new System.Windows.Forms.ComboBox();
            this.comboMarcas = new System.Windows.Forms.ComboBox();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.comboNombres = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.iconImprimir);
            this.tabPage1.Controls.Add(this.checkEliminar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.iconBuscar);
            this.tabPage1.Controls.Add(this.textBusqueda);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.iconEliminar);
            this.tabPage1.Controls.Add(this.dataGridListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros disponimbles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(776, 99);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 143;
            this.labelTotal.Text = "Total";
            // 
            // iconImprimir
            // 
            this.iconImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconImprimir.IconColor = System.Drawing.Color.Black;
            this.iconImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconImprimir.IconSize = 30;
            this.iconImprimir.Location = new System.Drawing.Point(833, 38);
            this.iconImprimir.Name = "iconImprimir";
            this.iconImprimir.Size = new System.Drawing.Size(66, 50);
            this.iconImprimir.TabIndex = 142;
            this.iconImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconImprimir.UseVisualStyleBackColor = false;
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(6, 95);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(62, 17);
            this.checkEliminar.TabIndex = 144;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 25);
            this.label6.TabIndex = 141;
            this.label6.Text = "Registro de los productos";
            // 
            // iconBuscar
            // 
            this.iconBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 30;
            this.iconBuscar.Location = new System.Drawing.Point(277, 38);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(52, 39);
            this.iconBuscar.TabIndex = 140;
            this.iconBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBuscar.UseVisualStyleBackColor = false;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(74, 47);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(197, 23);
            this.textBusqueda.TabIndex = 139;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 138;
            this.label2.Text = "Buscar: ";
            // 
            // iconEliminar
            // 
            this.iconEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconEliminar.IconColor = System.Drawing.Color.Black;
            this.iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminar.IconSize = 30;
            this.iconEliminar.Location = new System.Drawing.Point(750, 38);
            this.iconEliminar.Name = "iconEliminar";
            this.iconEliminar.Size = new System.Drawing.Size(66, 50);
            this.iconEliminar.TabIndex = 137;
            this.iconEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEliminar.UseVisualStyleBackColor = false;
            this.iconEliminar.Click += new System.EventHandler(this.iconEliminar_Click);
            // 
            // dataGridListado
            // 
            this.dataGridListado.AllowUserToAddRows = false;
            this.dataGridListado.AllowUserToDeleteRows = false;
            this.dataGridListado.AllowUserToOrderColumns = true;
            this.dataGridListado.AllowUserToResizeRows = false;
            this.dataGridListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListado.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridListado.EnableHeadersVisualStyles = false;
            this.dataGridListado.Location = new System.Drawing.Point(3, 130);
            this.dataGridListado.MultiSelect = false;
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridListado.RowTemplate.Height = 28;
            this.dataGridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListado.Size = new System.Drawing.Size(901, 333);
            this.dataGridListado.TabIndex = 136;
            this.dataGridListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListado_CellContentClick);
            this.dataGridListado.DoubleClick += new System.EventHandler(this.dataGridListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // comboEstado
            // 
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(256, 345);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(463, 24);
            this.comboEstado.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Estado";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(867, 9);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(35, 23);
            this.textID.TabIndex = 93;
            this.textID.Visible = false;
            // 
            // productoID
            // 
            this.productoID.AutoSize = true;
            this.productoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoID.Location = new System.Drawing.Point(783, 12);
            this.productoID.Name = "productoID";
            this.productoID.Size = new System.Drawing.Size(77, 17);
            this.productoID.TabIndex = 92;
            this.productoID.Text = "productoID";
            this.productoID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Datos de los productos";
            // 
            // iconCancelar
            // 
            this.iconCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCancelar.IconColor = System.Drawing.Color.Black;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.IconSize = 40;
            this.iconCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCancelar.Location = new System.Drawing.Point(705, 407);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconCancelar.Size = new System.Drawing.Size(155, 51);
            this.iconCancelar.TabIndex = 88;
            this.iconCancelar.Text = "Cancelar ";
            this.iconCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconCancelar.UseVisualStyleBackColor = false;
            this.iconCancelar.Click += new System.EventHandler(this.iconCancelar_Click);
            // 
            // iconActualizar
            // 
            this.iconActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconActualizar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.iconActualizar.IconColor = System.Drawing.Color.Black;
            this.iconActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualizar.IconSize = 40;
            this.iconActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconActualizar.Location = new System.Drawing.Point(275, 407);
            this.iconActualizar.Name = "iconActualizar";
            this.iconActualizar.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconActualizar.Size = new System.Drawing.Size(155, 51);
            this.iconActualizar.TabIndex = 87;
            this.iconActualizar.Text = "Actualizar";
            this.iconActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconActualizar.UseVisualStyleBackColor = false;
            this.iconActualizar.Click += new System.EventHandler(this.iconActualizar_Click);
            // 
            // iconRegistrar
            // 
            this.iconRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconRegistrar.IconColor = System.Drawing.Color.Black;
            this.iconRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRegistrar.IconSize = 40;
            this.iconRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconRegistrar.Location = new System.Drawing.Point(491, 407);
            this.iconRegistrar.Name = "iconRegistrar";
            this.iconRegistrar.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconRegistrar.Size = new System.Drawing.Size(155, 51);
            this.iconRegistrar.TabIndex = 86;
            this.iconRegistrar.Text = "Guardar  ";
            this.iconRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconRegistrar.UseVisualStyleBackColor = false;
            this.iconRegistrar.Click += new System.EventHandler(this.iconRegistrar_Click);
            // 
            // iconNuevo
            // 
            this.iconNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconNuevo.IconColor = System.Drawing.Color.Black;
            this.iconNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNuevo.IconSize = 40;
            this.iconNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconNuevo.Location = new System.Drawing.Point(56, 407);
            this.iconNuevo.Name = "iconNuevo";
            this.iconNuevo.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconNuevo.Size = new System.Drawing.Size(155, 51);
            this.iconNuevo.TabIndex = 85;
            this.iconNuevo.Text = "Nuevo   ";
            this.iconNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconNuevo.UseVisualStyleBackColor = false;
            this.iconNuevo.Click += new System.EventHandler(this.iconNuevo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textDescripcion);
            this.tabPage2.Controls.Add(this.comboUMedida);
            this.tabPage2.Controls.Add(this.comboMarcas);
            this.tabPage2.Controls.Add(this.comboCategorias);
            this.tabPage2.Controls.Add(this.comboNombres);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboEstado);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textID);
            this.tabPage2.Controls.Add(this.productoID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.iconCancelar);
            this.tabPage2.Controls.Add(this.iconActualizar);
            this.tabPage2.Controls.Add(this.iconRegistrar);
            this.tabPage2.Controls.Add(this.iconNuevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de los registros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(256, 255);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(463, 76);
            this.textDescripcion.TabIndex = 105;
            // 
            // comboUMedida
            // 
            this.comboUMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUMedida.FormattingEnabled = true;
            this.comboUMedida.Location = new System.Drawing.Point(256, 210);
            this.comboUMedida.Name = "comboUMedida";
            this.comboUMedida.Size = new System.Drawing.Size(463, 24);
            this.comboUMedida.TabIndex = 104;
            // 
            // comboMarcas
            // 
            this.comboMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMarcas.FormattingEnabled = true;
            this.comboMarcas.Location = new System.Drawing.Point(256, 156);
            this.comboMarcas.Name = "comboMarcas";
            this.comboMarcas.Size = new System.Drawing.Size(463, 24);
            this.comboMarcas.TabIndex = 103;
            // 
            // comboCategorias
            // 
            this.comboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(256, 105);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(463, 24);
            this.comboCategorias.TabIndex = 102;
            // 
            // comboNombres
            // 
            this.comboNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNombres.FormattingEnabled = true;
            this.comboNombres.Location = new System.Drawing.Point(256, 56);
            this.comboNombres.Name = "comboNombres";
            this.comboNombres.Size = new System.Drawing.Size(463, 24);
            this.comboNombres.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 100;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "Unidad de medida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "Nombre";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelTotal;
        private FontAwesome.Sharp.IconButton iconImprimir;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private System.Windows.Forms.DataGridView dataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label productoID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconActualizar;
        private FontAwesome.Sharp.IconButton iconRegistrar;
        private FontAwesome.Sharp.IconButton iconNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.ComboBox comboUMedida;
        private System.Windows.Forms.ComboBox comboMarcas;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.ComboBox comboNombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}