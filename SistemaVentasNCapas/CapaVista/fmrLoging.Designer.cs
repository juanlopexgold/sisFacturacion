
namespace CapaVista
{
    partial class fmrLoging
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            this.iconIngresar = new FontAwesome.Sharp.IconButton();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Abarroteria";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 111;
            this.iconPictureBox1.Location = new System.Drawing.Point(127, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(150, 111);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textClave);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso al sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clave:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(119, 53);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(144, 26);
            this.textUsuario.TabIndex = 2;
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(119, 106);
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(144, 26);
            this.textClave.TabIndex = 3;
            // 
            // iconCancelar
            // 
            this.iconCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconCancelar.FlatAppearance.BorderSize = 0;
            this.iconCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCancelar.ForeColor = System.Drawing.Color.White;
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCancelar.IconColor = System.Drawing.Color.White;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.IconSize = 40;
            this.iconCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCancelar.Location = new System.Drawing.Point(219, 439);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconCancelar.Size = new System.Drawing.Size(155, 51);
            this.iconCancelar.TabIndex = 89;
            this.iconCancelar.Text = "Cancelar ";
            this.iconCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconCancelar.UseVisualStyleBackColor = false;
            this.iconCancelar.Click += new System.EventHandler(this.iconCancelar_Click);
            // 
            // iconIngresar
            // 
            this.iconIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconIngresar.FlatAppearance.BorderSize = 0;
            this.iconIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconIngresar.ForeColor = System.Drawing.Color.White;
            this.iconIngresar.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconIngresar.IconColor = System.Drawing.Color.White;
            this.iconIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconIngresar.IconSize = 40;
            this.iconIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconIngresar.Location = new System.Drawing.Point(26, 439);
            this.iconIngresar.Name = "iconIngresar";
            this.iconIngresar.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iconIngresar.Size = new System.Drawing.Size(155, 51);
            this.iconIngresar.TabIndex = 90;
            this.iconIngresar.Text = "Ingresar  ";
            this.iconIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconIngresar.UseVisualStyleBackColor = false;
            this.iconIngresar.Click += new System.EventHandler(this.iconIngresar_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(204, 192);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(64, 18);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Usuario:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmrLoging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 515);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.iconIngresar);
            this.Controls.Add(this.iconCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrLoging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrLoging";
            this.Load += new System.EventHandler(this.fmrLoging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconIngresar;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
    }
}