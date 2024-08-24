
namespace CapaVista.Modulos.CRUDCompras
{
    partial class FormCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconImprimir = new FontAwesome.Sharp.IconButton();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeFechaNav = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeFechaPro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textPrecVen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPreCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textStockI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textIdArticulo = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataDetalle = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.textIdentificaion = new System.Windows.Forms.TextBox();
            this.textProveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.productoID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            this.iconActualizar = new FontAwesome.Sharp.IconButton();
            this.iconRegistrar = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.labelTotalPagar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.iconBuscar);
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(165, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker2.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(189, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 17);
            this.label17.TabIndex = 151;
            this.label17.Text = "Fecha Final:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 150;
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
            this.iconBuscar.Location = new System.Drawing.Point(662, 33);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(66, 50);
            this.iconBuscar.TabIndex = 147;
            this.iconBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBuscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 145;
            this.label2.Text = "Fecha Inicio:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(726, 95);
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
            this.iconImprimir.Location = new System.Drawing.Point(833, 33);
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
            this.checkEliminar.Size = new System.Drawing.Size(56, 17);
            this.checkEliminar.TabIndex = 144;
            this.checkEliminar.Text = "Anular";
            this.checkEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 25);
            this.label6.TabIndex = 141;
            this.label6.Text = "Registro de los ingresos";
            // 
            // iconEliminar
            // 
            this.iconEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconEliminar.IconColor = System.Drawing.Color.Black;
            this.iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminar.IconSize = 30;
            this.iconEliminar.Location = new System.Drawing.Point(750, 33);
            this.iconEliminar.Name = "iconEliminar";
            this.iconEliminar.Size = new System.Drawing.Size(66, 50);
            this.iconEliminar.TabIndex = 137;
            this.iconEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridListado
            // 
            this.dataGridListado.AllowUserToAddRows = false;
            this.dataGridListado.AllowUserToDeleteRows = false;
            this.dataGridListado.AllowUserToOrderColumns = true;
            this.dataGridListado.AllowUserToResizeRows = false;
            this.dataGridListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListado.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridListado.EnableHeadersVisualStyles = false;
            this.dataGridListado.Location = new System.Drawing.Point(3, 130);
            this.dataGridListado.MultiSelect = false;
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridListado.RowTemplate.Height = 28;
            this.dataGridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListado.Size = new System.Drawing.Size(901, 333);
            this.dataGridListado.TabIndex = 136;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTotalPagar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.iconButton1);
            this.tabPage2.Controls.Add(this.dataDetalle);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimeFecha);
            this.tabPage2.Controls.Add(this.textIdentificaion);
            this.tabPage2.Controls.Add(this.textProveedor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textID);
            this.tabPage2.Controls.Add(this.productoID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.iconCancelar);
            this.tabPage2.Controls.Add(this.iconActualizar);
            this.tabPage2.Controls.Add(this.iconRegistrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de los registros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButton4);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.dateTimeFechaNav);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimeFechaPro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textPrecVen);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textPreCom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textStockI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.textIdArticulo);
            this.groupBox1.Controls.Add(this.textProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(19, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 156);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            // 
            // dateTimeFechaNav
            // 
            this.dateTimeFechaNav.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNav.Location = new System.Drawing.Point(719, 74);
            this.dateTimeFechaNav.Name = "dateTimeFechaNav";
            this.dateTimeFechaNav.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFechaNav.TabIndex = 161;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(591, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 160;
            this.label13.Text = "Fecha Vencimiento";
            // 
            // dateTimeFechaPro
            // 
            this.dateTimeFechaPro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaPro.Location = new System.Drawing.Point(719, 25);
            this.dateTimeFechaPro.Name = "dateTimeFechaPro";
            this.dateTimeFechaPro.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFechaPro.TabIndex = 151;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(591, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 150;
            this.label12.Text = "Fecha Produccion";
            // 
            // textPrecVen
            // 
            this.textPrecVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecVen.Location = new System.Drawing.Point(407, 72);
            this.textPrecVen.Name = "textPrecVen";
            this.textPrecVen.Size = new System.Drawing.Size(152, 23);
            this.textPrecVen.TabIndex = 159;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(300, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 158;
            this.label10.Text = "Precio Venta";
            // 
            // textPreCom
            // 
            this.textPreCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPreCom.Location = new System.Drawing.Point(407, 26);
            this.textPreCom.Name = "textPreCom";
            this.textPreCom.Size = new System.Drawing.Size(152, 23);
            this.textPreCom.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 156;
            this.label8.Text = "Precio Compra";
            // 
            // textStockI
            // 
            this.textStockI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStockI.Location = new System.Drawing.Point(93, 75);
            this.textStockI.Name = "textStockI";
            this.textStockI.Size = new System.Drawing.Size(152, 23);
            this.textStockI.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 154;
            this.label7.Text = "Stock Inicial";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 26;
            this.iconButton2.Location = new System.Drawing.Point(247, 26);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(42, 32);
            this.iconButton2.TabIndex = 153;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // textIdArticulo
            // 
            this.textIdArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdArticulo.Location = new System.Drawing.Point(148, 0);
            this.textIdArticulo.Name = "textIdArticulo";
            this.textIdArticulo.Size = new System.Drawing.Size(35, 23);
            this.textIdArticulo.TabIndex = 150;
            this.textIdArticulo.Visible = false;
            // 
            // textProducto
            // 
            this.textProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.Location = new System.Drawing.Point(76, 29);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(169, 23);
            this.textProducto.TabIndex = 152;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 151;
            this.label4.Text = "Producto";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(571, 41);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 32);
            this.iconButton1.TabIndex = 148;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataDetalle
            // 
            this.dataDetalle.AllowUserToAddRows = false;
            this.dataDetalle.AllowUserToDeleteRows = false;
            this.dataDetalle.AllowUserToOrderColumns = true;
            this.dataDetalle.AllowUserToResizeRows = false;
            this.dataDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetalle.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataDetalle.EnableHeadersVisualStyles = false;
            this.dataDetalle.Location = new System.Drawing.Point(19, 233);
            this.dataDetalle.MultiSelect = false;
            this.dataDetalle.Name = "dataDetalle";
            this.dataDetalle.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataDetalle.RowTemplate.Height = 28;
            this.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDetalle.Size = new System.Drawing.Size(868, 177);
            this.dataDetalle.TabIndex = 137;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 129;
            this.label5.Text = "TotalPago";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(726, 50);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFecha.TabIndex = 127;
            // 
            // textIdentificaion
            // 
            this.textIdentificaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificaion.Location = new System.Drawing.Point(112, 49);
            this.textIdentificaion.Name = "textIdentificaion";
            this.textIdentificaion.Size = new System.Drawing.Size(169, 23);
            this.textIdentificaion.TabIndex = 124;
            // 
            // textProveedor
            // 
            this.textProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProveedor.Location = new System.Drawing.Point(396, 44);
            this.textProveedor.Name = "textProveedor";
            this.textProveedor.Size = new System.Drawing.Size(169, 23);
            this.textProveedor.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(320, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 119;
            this.label11.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(673, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 116;
            this.label9.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nombres";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(462, 15);
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
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Datos del ingreso";
            // 
            // iconCancelar
            // 
            this.iconCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCancelar.IconColor = System.Drawing.Color.Black;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.IconSize = 25;
            this.iconCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCancelar.Location = new System.Drawing.Point(774, 419);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Size = new System.Drawing.Size(113, 41);
            this.iconCancelar.TabIndex = 88;
            this.iconCancelar.Text = "Cancelar ";
            this.iconCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconCancelar.UseVisualStyleBackColor = false;
            // 
            // iconActualizar
            // 
            this.iconActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconActualizar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.iconActualizar.IconColor = System.Drawing.Color.Black;
            this.iconActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualizar.IconSize = 25;
            this.iconActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconActualizar.Location = new System.Drawing.Point(533, 419);
            this.iconActualizar.Name = "iconActualizar";
            this.iconActualizar.Size = new System.Drawing.Size(113, 41);
            this.iconActualizar.TabIndex = 87;
            this.iconActualizar.Text = "Nuevo";
            this.iconActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconActualizar.UseVisualStyleBackColor = false;
            // 
            // iconRegistrar
            // 
            this.iconRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconRegistrar.IconColor = System.Drawing.Color.Black;
            this.iconRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRegistrar.IconSize = 25;
            this.iconRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconRegistrar.Location = new System.Drawing.Point(655, 419);
            this.iconRegistrar.Name = "iconRegistrar";
            this.iconRegistrar.Size = new System.Drawing.Size(113, 41);
            this.iconRegistrar.TabIndex = 86;
            this.iconRegistrar.Text = "Guardar  ";
            this.iconRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconRegistrar.UseVisualStyleBackColor = false;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.LevelUp;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Location = new System.Drawing.Point(715, 109);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(66, 41);
            this.iconButton3.TabIndex = 150;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.LevelDownAlt;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.Location = new System.Drawing.Point(787, 109);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(66, 41);
            this.iconButton4.TabIndex = 162;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // labelTotalPagar
            // 
            this.labelTotalPagar.AutoSize = true;
            this.labelTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagar.Location = new System.Drawing.Point(109, 431);
            this.labelTotalPagar.Name = "labelTotalPagar";
            this.labelTotalPagar.Size = new System.Drawing.Size(28, 17);
            this.labelTotalPagar.TabIndex = 150;
            this.labelTotalPagar.Text = "0.0";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompras_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private FontAwesome.Sharp.IconButton iconImprimir;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private System.Windows.Forms.DataGridView dataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.TextBox textIdentificaion;
        private System.Windows.Forms.TextBox textProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label productoID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconActualizar;
        private FontAwesome.Sharp.IconButton iconRegistrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dataDetalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPrecVen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPreCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textStockI;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textIdArticulo;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNav;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimeFechaPro;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label labelTotalPagar;
    }
}