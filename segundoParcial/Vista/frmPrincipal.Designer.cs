namespace segundoParcial
{
    partial class frmPrincipal
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Location = new System.Drawing.Point(2, 1);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(88, 35);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 281);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(593, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "ESTE DUI NO SE ENCUENTRA REGISTRADO EN NUESTRA BASE DE DATOS";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Location = new System.Drawing.Point(404, 281);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(358, 20);
            this.lblBeneficiario.TabIndex = 11;
            this.lblBeneficiario.Text = "ERES BENEFICIARIO DE LOS $300 DOLARES";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Location = new System.Drawing.Point(423, 147);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 35);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(104, 151);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(240, 26);
            this.txtDUI.TabIndex = 9;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBeneficiario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.btnAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(824, 488);
            this.MinimumSize = new System.Drawing.Size(824, 488);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "covidGob";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDUI;
    }
}

