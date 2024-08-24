
namespace CapaVista.Modulos.CRUDConfig
{
    partial class FormTrabajadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconImprimir = new FontAwesome.Sharp.IconButton();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textID = new System.Windows.Forms.TextBox();
            this.productoID = new System.Windows.Forms.Label();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            this.iconActualizar = new FontAwesome.Sharp.IconButton();
            this.iconRegistrar = new FontAwesome.Sharp.IconButton();
            this.iconNuevo = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textClave = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboAcceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBGenero = new System.Windows.Forms.ComboBox();
            this.dateTimeFeNac = new System.Windows.Forms.DateTimePicker();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textIdentificaion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage1.Controls.Add(this.comboBuscar);
            this.tabPage1.Controls.Add(this.iconBuscar);
            this.tabPage1.Controls.Add(this.textBusqueda);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.iconImprimir);
            this.tabPage1.Controls.Add(this.checkEliminar);
            this.tabPage1.Controls.Add(this.label6);
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
            // comboBuscar
            // 
            this.comboBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Items.AddRange(new object[] {
            "Nombres",
            "Apellido Paterno",
            "Apellido Materno"});
            this.comboBuscar.Location = new System.Drawing.Point(83, 51);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(187, 24);
            this.comboBuscar.TabIndex = 148;
            this.comboBuscar.Text = "Nombres";
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
            this.iconBuscar.Location = new System.Drawing.Point(452, 43);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(52, 39);
            this.iconBuscar.TabIndex = 147;
            this.iconBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBuscar.UseVisualStyleBackColor = false;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(276, 52);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(170, 23);
            this.textBusqueda.TabIndex = 146;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 145;
            this.label2.Text = "Buscar por: ";
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
            this.label6.Size = new System.Drawing.Size(281, 25);
            this.label6.TabIndex = 141;
            this.label6.Text = "Registro de los trabajadores";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridListado.EnableHeadersVisualStyles = false;
            this.dataGridListado.Location = new System.Drawing.Point(3, 130);
            this.dataGridListado.MultiSelect = false;
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            this.tabPage2.Controls.Add(this.textClave);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.comboAcceso);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBGenero);
            this.tabPage2.Controls.Add(this.dateTimeFeNac);
            this.tabPage2.Controls.Add(this.textEmail);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textIdentificaion);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textUsuario);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textTelefono);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textDireccion);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textApellidoM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textApellidoP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textNombre);
            this.tabPage2.Controls.Add(this.label3);
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
            // textClave
            // 
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.Location = new System.Drawing.Point(560, 323);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(167, 23);
            this.textClave.TabIndex = 132;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(499, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 131;
            this.label15.Text = "Clave";
            // 
            // comboAcceso
            // 
            this.comboAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAcceso.FormattingEnabled = true;
            this.comboAcceso.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.comboAcceso.Location = new System.Drawing.Point(266, 374);
            this.comboAcceso.Name = "comboAcceso";
            this.comboAcceso.Size = new System.Drawing.Size(120, 24);
            this.comboAcceso.TabIndex = 130;
            this.comboAcceso.Text = "Administrador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 129;
            this.label5.Text = "Acceso";
            // 
            // comboBGenero
            // 
            this.comboBGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBGenero.FormattingEnabled = true;
            this.comboBGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBGenero.Location = new System.Drawing.Point(264, 158);
            this.comboBGenero.Name = "comboBGenero";
            this.comboBGenero.Size = new System.Drawing.Size(79, 24);
            this.comboBGenero.TabIndex = 128;
            this.comboBGenero.Text = "F";
            // 
            // dateTimeFeNac
            // 
            this.dateTimeFeNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFeNac.Location = new System.Drawing.Point(554, 161);
            this.dateTimeFeNac.Name = "dateTimeFeNac";
            this.dateTimeFeNac.Size = new System.Drawing.Size(173, 20);
            this.dateTimeFeNac.TabIndex = 127;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(264, 275);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(463, 23);
            this.textEmail.TabIndex = 126;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(207, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 125;
            this.label14.Text = "Email";
            // 
            // textIdentificaion
            // 
            this.textIdentificaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificaion.Location = new System.Drawing.Point(558, 236);
            this.textIdentificaion.Name = "textIdentificaion";
            this.textIdentificaion.Size = new System.Drawing.Size(169, 23);
            this.textIdentificaion.TabIndex = 124;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(464, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 123;
            this.label13.Text = "Identificacion";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(266, 326);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(167, 23);
            this.textUsuario.TabIndex = 122;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 121;
            this.label12.Text = "Usuario";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(264, 236);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(169, 23);
            this.textTelefono.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 119;
            this.label11.Text = "Telefono";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(264, 193);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(463, 23);
            this.textDireccion.TabIndex = 118;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 117;
            this.label10.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 116;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 115;
            this.label8.Text = "Genero";
            // 
            // textApellidoM
            // 
            this.textApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoM.Location = new System.Drawing.Point(264, 124);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(463, 23);
            this.textApellidoM.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "Apellido Materno";
            // 
            // textApellidoP
            // 
            this.textApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoP.Location = new System.Drawing.Point(264, 87);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(463, 23);
            this.textApellidoP.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Apellido Paterno";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(264, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(463, 23);
            this.textNombre.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Datos de los trabajadores";
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
            // FormTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrabajadores";
            this.Text = "FormTrabajadores";
            this.Load += new System.EventHandler(this.FormTrabajadores_Load);
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
        private FontAwesome.Sharp.IconButton iconEliminar;
        private System.Windows.Forms.DataGridView dataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label productoID;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconActualizar;
        private FontAwesome.Sharp.IconButton iconRegistrar;
        private FontAwesome.Sharp.IconButton iconNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBuscar;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboAcceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBGenero;
        private System.Windows.Forms.DateTimePicker dateTimeFeNac;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textIdentificaion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}