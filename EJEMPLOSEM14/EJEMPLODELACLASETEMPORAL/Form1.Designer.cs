namespace EJEMPLODELACLASETEMPORAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.grpGenerales = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAgrupados = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tlsCargar = new System.Windows.Forms.ToolStripButton();
            this.tlsEliminar = new System.Windows.Forms.ToolStripButton();
            this.grpGenerales.SuspendLayout();
            this.grpAgrupados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Registro de Ciudades";
            // 
            // grpGenerales
            // 
            this.grpGenerales.Controls.Add(this.btnAgregar);
            this.grpGenerales.Controls.Add(this.txtNombre);
            this.grpGenerales.Controls.Add(this.txtCodigo);
            this.grpGenerales.Controls.Add(this.label3);
            this.grpGenerales.Controls.Add(this.label2);
            this.grpGenerales.Location = new System.Drawing.Point(46, 119);
            this.grpGenerales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGenerales.Name = "grpGenerales";
            this.grpGenerales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGenerales.Size = new System.Drawing.Size(512, 300);
            this.grpGenerales.TabIndex = 1;
            this.grpGenerales.TabStop = false;
            this.grpGenerales.Text = "Datos Generales";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(134, 171);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(198, 91);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 52);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(285, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // grpAgrupados
            // 
            this.grpAgrupados.Controls.Add(this.dgvRegistros);
            this.grpAgrupados.Location = new System.Drawing.Point(158, 446);
            this.grpAgrupados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAgrupados.Name = "grpAgrupados";
            this.grpAgrupados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAgrupados.Size = new System.Drawing.Size(955, 370);
            this.grpAgrupados.TabIndex = 2;
            this.grpAgrupados.TabStop = false;
            this.grpAgrupados.Text = "Registros agrupados";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(22, 29);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(907, 341);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(784, 119);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 78);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(794, 238);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(171, 67);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(794, 341);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 68);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsGuardar,
            this.tlsCargar,
            this.tlsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 29);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsGuardar
            // 
            this.tlsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlsGuardar.Image")));
            this.tlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsGuardar.Name = "tlsGuardar";
            this.tlsGuardar.Size = new System.Drawing.Size(34, 24);
            this.tlsGuardar.Text = "Guardar";
            this.tlsGuardar.Click += new System.EventHandler(this.tlsGuardar_Click);
            // 
            // tlsCargar
            // 
            this.tlsCargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsCargar.Image = ((System.Drawing.Image)(resources.GetObject("tlsCargar.Image")));
            this.tlsCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsCargar.Name = "tlsCargar";
            this.tlsCargar.Size = new System.Drawing.Size(34, 24);
            this.tlsCargar.Text = "Cargar";
            this.tlsCargar.ToolTipText = "Cargar";
            this.tlsCargar.Click += new System.EventHandler(this.tlsCargar_Click);
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsEliminar.Image")));
            this.tlsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(34, 24);
            this.tlsEliminar.Text = "toolStripButton3";
            this.tlsEliminar.ToolTipText = "Eliminar";
            this.tlsEliminar.Click += new System.EventHandler(this.tlsEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 928);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpAgrupados);
            this.Controls.Add(this.grpGenerales);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Registro Ciudades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGenerales.ResumeLayout(false);
            this.grpGenerales.PerformLayout();
            this.grpAgrupados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGenerales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAgrupados;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsGuardar;
        private System.Windows.Forms.ToolStripButton tlsCargar;
        private System.Windows.Forms.ToolStripButton tlsEliminar;
    }
}

