namespace GestorDeBiblioteca
{
    partial class formDevolucionLibro
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
            this.lblDevolucionLibro = new System.Windows.Forms.Label();
            this.grpDatosDeDevolucion = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSeleccionarPrestamo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSeleccionarPrestamo = new System.Windows.Forms.Label();
            this.grpDatosDeDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDevolucionLibro
            // 
            this.lblDevolucionLibro.AutoSize = true;
            this.lblDevolucionLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucionLibro.Location = new System.Drawing.Point(4, 22);
            this.lblDevolucionLibro.Name = "lblDevolucionLibro";
            this.lblDevolucionLibro.Size = new System.Drawing.Size(381, 46);
            this.lblDevolucionLibro.TabIndex = 11;
            this.lblDevolucionLibro.Text = "Devolucion de libros";
            // 
            // grpDatosDeDevolucion
            // 
            this.grpDatosDeDevolucion.Controls.Add(this.txtUsuario);
            this.grpDatosDeDevolucion.Controls.Add(this.txtSeleccionarPrestamo);
            this.grpDatosDeDevolucion.Controls.Add(this.btnGuardar);
            this.grpDatosDeDevolucion.Controls.Add(this.btnRegresar);
            this.grpDatosDeDevolucion.Controls.Add(this.lblUsuario);
            this.grpDatosDeDevolucion.Controls.Add(this.lblSeleccionarPrestamo);
            this.grpDatosDeDevolucion.Location = new System.Drawing.Point(29, 87);
            this.grpDatosDeDevolucion.Name = "grpDatosDeDevolucion";
            this.grpDatosDeDevolucion.Size = new System.Drawing.Size(331, 314);
            this.grpDatosDeDevolucion.TabIndex = 10;
            this.grpDatosDeDevolucion.TabStop = false;
            this.grpDatosDeDevolucion.Text = "Ingresa los datos";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(106, 147);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSeleccionarPrestamo
            // 
            this.txtSeleccionarPrestamo.Location = new System.Drawing.Point(90, 73);
            this.txtSeleccionarPrestamo.Name = "txtSeleccionarPrestamo";
            this.txtSeleccionarPrestamo.Size = new System.Drawing.Size(175, 22);
            this.txtSeleccionarPrestamo.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(185, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(62, 220);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 147);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "ID Usuario:";
            // 
            // lblSeleccionarPrestamo
            // 
            this.lblSeleccionarPrestamo.AutoSize = true;
            this.lblSeleccionarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarPrestamo.Location = new System.Drawing.Point(81, 38);
            this.lblSeleccionarPrestamo.Name = "lblSeleccionarPrestamo";
            this.lblSeleccionarPrestamo.Size = new System.Drawing.Size(184, 20);
            this.lblSeleccionarPrestamo.TabIndex = 2;
            this.lblSeleccionarPrestamo.Text = "Selecciona el prestamo";
            // 
            // formDevolucionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.lblDevolucionLibro);
            this.Controls.Add(this.grpDatosDeDevolucion);
            this.Name = "formDevolucionLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDevolucionLibro";
            this.grpDatosDeDevolucion.ResumeLayout(false);
            this.grpDatosDeDevolucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevolucionLibro;
        private System.Windows.Forms.GroupBox grpDatosDeDevolucion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSeleccionarPrestamo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSeleccionarPrestamo;
    }
}