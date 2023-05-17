namespace pryPonceCarlos
{
    partial class Frmprincipal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredecompañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredelcontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargodelcontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.nombredecompañia,
            this.nombredelcontacto,
            this.cargodelcontacto,
            this.direccion,
            this.ciudad,
            this.region,
            this.codigopostal,
            this.pais,
            this.telefono,
            this.fax});
            this.dataGridView1.Location = new System.Drawing.Point(23, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "id.cliente";
            this.idcliente.Name = "idcliente";
            // 
            // nombredecompañia
            // 
            this.nombredecompañia.HeaderText = "nombre de compañia";
            this.nombredecompañia.Name = "nombredecompañia";
            // 
            // nombredelcontacto
            // 
            this.nombredelcontacto.HeaderText = "nombre del contacto";
            this.nombredelcontacto.Name = "nombredelcontacto";
            // 
            // cargodelcontacto
            // 
            this.cargodelcontacto.HeaderText = "cargo del contacto";
            this.cargodelcontacto.Name = "cargodelcontacto";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "ciudad";
            this.ciudad.Name = "ciudad";
            // 
            // region
            // 
            this.region.HeaderText = "region";
            this.region.Name = "region";
            // 
            // codigopostal
            // 
            this.codigopostal.HeaderText = "codigo postal";
            this.codigopostal.Name = "codigopostal";
            // 
            // pais
            // 
            this.pais.HeaderText = "pais";
            this.pais.Name = "pais";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // fax
            // 
            this.fax.HeaderText = "fax";
            this.fax.Name = "fax";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(774, 512);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageKey = "(ninguno)";
            this.label1.Location = new System.Drawing.Point(131, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 512);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 540);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frmprincipal";
            this.Text = "BUSCAR CLIENTE";
            this.Load += new System.EventHandler(this.Frmprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredecompañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelcontacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargodelcontacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
    }
}

