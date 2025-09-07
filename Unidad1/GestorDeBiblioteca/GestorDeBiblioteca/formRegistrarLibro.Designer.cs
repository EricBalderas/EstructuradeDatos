namespace GestorDeBiblioteca
{
    partial class formRegistrarLibro
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
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtLibroID = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpDatosLibro = new System.Windows.Forms.GroupBox();
            this.lblRegistrarLibro = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.lblLibroID = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDatosLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(131, 57);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(175, 22);
            this.txtTituloLibro.TabIndex = 0;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(131, 113);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(175, 22);
            this.txtAutorLibro.TabIndex = 1;
            // 
            // txtLibroID
            // 
            this.txtLibroID.Location = new System.Drawing.Point(131, 163);
            this.txtLibroID.Name = "txtLibroID";
            this.txtLibroID.Size = new System.Drawing.Size(175, 22);
            this.txtLibroID.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(75, 242);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // grpDatosLibro
            // 
            this.grpDatosLibro.Controls.Add(this.txtLibroID);
            this.grpDatosLibro.Controls.Add(this.txtAutorLibro);
            this.grpDatosLibro.Controls.Add(this.txtTituloLibro);
            this.grpDatosLibro.Controls.Add(this.btnGuardar);
            this.grpDatosLibro.Controls.Add(this.lblLibroID);
            this.grpDatosLibro.Controls.Add(this.btnRegresar);
            this.grpDatosLibro.Controls.Add(this.lblAutorLibro);
            this.grpDatosLibro.Controls.Add(this.lblTituloLibro);
            this.grpDatosLibro.Location = new System.Drawing.Point(12, 86);
            this.grpDatosLibro.Name = "grpDatosLibro";
            this.grpDatosLibro.Size = new System.Drawing.Size(331, 314);
            this.grpDatosLibro.TabIndex = 4;
            this.grpDatosLibro.TabStop = false;
            this.grpDatosLibro.Text = "Ingresa los datos";
            // 
            // lblRegistrarLibro
            // 
            this.lblRegistrarLibro.AutoSize = true;
            this.lblRegistrarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarLibro.Location = new System.Drawing.Point(37, 20);
            this.lblRegistrarLibro.Name = "lblRegistrarLibro";
            this.lblRegistrarLibro.Size = new System.Drawing.Size(281, 46);
            this.lblRegistrarLibro.TabIndex = 5;
            this.lblRegistrarLibro.Text = "Registrar Libro";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(6, 57);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(119, 20);
            this.lblTituloLibro.TabIndex = 2;
            this.lblTituloLibro.Text = "Titulo del libro:";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(6, 115);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(118, 20);
            this.lblAutorLibro.TabIndex = 3;
            this.lblAutorLibro.Text = "Autor del libro:";
            // 
            // lblLibroID
            // 
            this.lblLibroID.AutoSize = true;
            this.lblLibroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroID.Location = new System.Drawing.Point(71, 163);
            this.lblLibroID.Name = "lblLibroID";
            this.lblLibroID.Size = new System.Drawing.Size(53, 20);
            this.lblLibroID.TabIndex = 4;
            this.lblLibroID.Text = "ISBN:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(178, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // formRegistrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 423);
            this.Controls.Add(this.lblRegistrarLibro);
            this.Controls.Add(this.grpDatosLibro);
            this.Name = "formRegistrarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de libro";
            this.grpDatosLibro.ResumeLayout(false);
            this.grpDatosLibro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.TextBox txtLibroID;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpDatosLibro;
        private System.Windows.Forms.Label lblRegistrarLibro;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lblLibroID;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Button btnGuardar;
    }
}