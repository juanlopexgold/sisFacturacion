
namespace CapaVista.Modulos.CRUDMantenimiento
{
    partial class FormCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconImprimir = new FontAwesome.Sharp.IconButton();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.iconNuevo = new FontAwesome.Sharp.IconButton();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            this.iconActualizar = new FontAwesome.Sharp.IconButton();
            this.iconRegistrar = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.productoID = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).BeginInit();
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
            this.tabControl1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboEstado);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textID);
            this.tabPage2.Controls.Add(this.productoID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textNombre);
            this.tabPage2.Controls.Add(this.label3);
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
            // dataGridListado
            // 
            this.dataGridListado.AllowUserToAddRows = false;
            this.dataGridListado.AllowUserToDeleteRows = false;
            this.dataGridListado.AllowUserToOrderColumns = true;
            this.dataGridListado.AllowUserToResizeRows = false;
            this.dataGridListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListado.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridListado.EnableHeadersVisualStyles = false;
            this.dataGridListado.Location = new System.Drawing.Point(3, 130);
            this.dataGridListado.MultiSelect = false;
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 141;
            this.label6.Text = "Registro de las categorias";
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
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(286, 186);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(463, 23);
            this.textNombre.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Datos de las categoria";
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
            // comboEstado
            // 
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(286, 262);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(216, 24);
            this.comboEstado.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Estado";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelTotal;
        private FontAwesome.Sharp.IconButton iconImprimir;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private FontAwesome.Sharp.IconButton iconNuevo;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconActualizar;
        private FontAwesome.Sharp.IconButton iconRegistrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label productoID;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}