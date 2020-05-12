namespace segundoParcial.Vista
{
    partial class frmAdmi
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 45);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(462, 45);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(164, 26);
            this.txtDUI.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(133, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(517, 20);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(41, 20);
            this.lblDUI.TabIndex = 3;
            this.lblDUI.Text = "DUI";
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarios.Location = new System.Drawing.Point(29, 120);
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.Size = new System.Drawing.Size(670, 292);
            this.dgvBeneficiarios.TabIndex = 4;
            this.dgvBeneficiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarios_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(753, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(134, 39);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(753, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(753, 238);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 39);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(753, 336);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 424);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(944, 463);
            this.MinimumSize = new System.Drawing.Size(944, 463);
            this.Name = "frmAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmi";
            this.Load += new System.EventHandler(this.frmAdmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}