namespace WindowsFormsApp1
{
    partial class FormBusqueda
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtboxBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(26, 29);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(650, 220);
            this.dgvLista.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(546, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtboxBusqueda
            // 
            this.txtboxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxBusqueda.Location = new System.Drawing.Point(95, 264);
            this.txtboxBusqueda.Name = "txtboxBusqueda";
            this.txtboxBusqueda.Size = new System.Drawing.Size(300, 20);
            this.txtboxBusqueda.TabIndex = 2;
            this.txtboxBusqueda.TextChanged += new System.EventHandler(this.txtboxBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 264);
            this.label1.MaximumSize = new System.Drawing.Size(60, 20);
            this.label1.MinimumSize = new System.Drawing.Size(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar :";
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvLista);
            this.Name = "FormBusqueda";
            this.Text = "FormBusqueda";
            this.Load += new System.EventHandler(this.FormBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtboxBusqueda;
        private System.Windows.Forms.Label label1;
    }
}