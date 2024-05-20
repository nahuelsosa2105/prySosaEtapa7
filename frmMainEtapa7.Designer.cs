namespace prySosaEtapa7
{
    partial class frmMainEtapa7
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
            this.stsBD = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.trvBaseDatos = new System.Windows.Forms.TreeView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.stsBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsBD
            // 
            this.stsBD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.stsBD.Location = new System.Drawing.Point(0, 618);
            this.stsBD.Name = "stsBD";
            this.stsBD.Size = new System.Drawing.Size(1220, 22);
            this.stsBD.TabIndex = 0;
            this.stsBD.Text = "Estado de conexion";
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // trvBaseDatos
            // 
            this.trvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.trvBaseDatos.Name = "trvBaseDatos";
            this.trvBaseDatos.Size = new System.Drawing.Size(1186, 483);
            this.trvBaseDatos.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1019, 524);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(179, 57);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // frmMainEtapa7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1220, 640);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.trvBaseDatos);
            this.Controls.Add(this.stsBD);
            this.Name = "frmMainEtapa7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión a Base de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stsBD.ResumeLayout(false);
            this.stsBD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsBD;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
        private System.Windows.Forms.TreeView trvBaseDatos;
        private System.Windows.Forms.Button btnMostrar;
    }
}

