
namespace CapaVista.Modulos.vistas
{
    partial class FormProveedorVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(684, 60);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 152;
            this.labelTotal.Text = "Total";
            // 
            // dataGridListado
            // 
            this.dataGridListado.AllowUserToAddRows = false;
            this.dataGridListado.AllowUserToDeleteRows = false;
            this.dataGridListado.AllowUserToOrderColumns = true;
            this.dataGridListado.AllowUserToResizeRows = false;
            this.dataGridListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListado.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridListado.EnableHeadersVisualStyles = false;
            this.dataGridListado.Location = new System.Drawing.Point(0, 81);
            this.dataGridListado.MultiSelect = false;
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridListado.RowTemplate.Height = 28;
            this.dataGridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListado.Size = new System.Drawing.Size(919, 380);
            this.dataGridListado.TabIndex = 151;
            this.dataGridListado.DoubleClick += new System.EventHandler(this.dataGridListado_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 150;
            this.label6.Text = "Buscar por:";
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
            this.iconBuscar.Location = new System.Drawing.Point(754, 6);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(52, 39);
            this.iconBuscar.TabIndex = 149;
            this.iconBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBuscar.UseVisualStyleBackColor = false;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(448, 21);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(299, 23);
            this.textBusqueda.TabIndex = 148;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // comboBuscar
            // 
            this.comboBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Items.AddRange(new object[] {
            "Nombres",
            "Apellido Paterno",
            "Apellido Materno"});
            this.comboBuscar.Location = new System.Drawing.Point(274, 21);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(149, 24);
            this.comboBuscar.TabIndex = 153;
            this.comboBuscar.Text = "Nombres";
            // 
            // FormProveedorVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 461);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dataGridListado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iconBuscar);
            this.Controls.Add(this.textBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProveedorVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProveedorVista";
            this.Load += new System.EventHandler(this.FormProveedorVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox comboBuscar;
    }
}