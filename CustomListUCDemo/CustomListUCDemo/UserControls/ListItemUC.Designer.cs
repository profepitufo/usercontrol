namespace CustomListUCDemo.UserControls
{
    partial class ListItemUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.InformacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PhotoPictureBox.Location = new System.Drawing.Point(2, 2);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(91, 88);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.BackColor = System.Drawing.Color.Transparent;
            this.NombreLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(108, 2);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(76, 22);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // InformacionLabel
            // 
            this.InformacionLabel.AutoSize = true;
            this.InformacionLabel.BackColor = System.Drawing.Color.Transparent;
            this.InformacionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformacionLabel.Location = new System.Drawing.Point(108, 36);
            this.InformacionLabel.Name = "InformacionLabel";
            this.InformacionLabel.Size = new System.Drawing.Size(236, 19);
            this.InformacionLabel.TabIndex = 2;
            this.InformacionLabel.Text = "Datos Adicionales del Registro aquí";
            // 
            // ListItemUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.InformacionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListItemUC";
            this.Size = new System.Drawing.Size(500, 90);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label InformacionLabel;
    }
}
