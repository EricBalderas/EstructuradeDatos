namespace GestorDeBiblioteca
{
    partial class formPrestamoLibro
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
            this.lblPrestamoLibro = new System.Windows.Forms.Label();
            this.grpDatosPrestamo = new System.Windows.Forms.GroupBox();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtSeleccionarLibro = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblSeleccionarLibro = new System.Windows.Forms.Label();
            this.grpDatosPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrestamoLibro
            // 
            this.lblPrestamoLibro.AutoSize = true;
            this.lblPrestamoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamoLibro.Location = new System.Drawing.Point(17, 34);
            this.lblPrestamoLibro.Name = "lblPrestamoLibro";
            this.lblPrestamoLibro.Size = new System.Drawing.Size(353, 46);
            this.lblPrestamoLibro.TabIndex = 9;
            this.lblPrestamoLibro.Text = "Prestamo de libros";
            // 
            // grpDatosPrestamo
            // 
            this.grpDatosPrestamo.Controls.Add(this.txtIDUsuario);
            this.grpDatosPrestamo.Controls.Add(this.txtSeleccionarLibro);
            this.grpDatosPrestamo.Controls.Add(this.btnGuardar);
            this.grpDatosPrestamo.Controls.Add(this.btnRegresar);
            this.grpDatosPrestamo.Controls.Add(this.lblIDUsuario);
            this.grpDatosPrestamo.Controls.Add(this.lblSeleccionarLibro);
            this.grpDatosPrestamo.Location = new System.Drawing.Point(23, 83);
            this.grpDatosPrestamo.Name = "grpDatosPrestamo";
            this.grpDatosPrestamo.Size = new System.Drawing.Size(331, 314);
            this.grpDatosPrestamo.TabIndex = 8;
            this.grpDatosPrestamo.TabStop = false;
            this.grpDatosPrestamo.Text = "Ingresa los datos";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(143, 115);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtIDUsuario.TabIndex = 1;
            // 
            // txtSeleccionarLibro
            // 
            this.txtSeleccionarLibro.Location = new System.Drawing.Point(157, 57);
            this.txtSeleccionarLibro.Name = "txtSeleccionarLibro";
            this.txtSeleccionarLibro.Size = new System.Drawing.Size(175, 22);
            this.txtSeleccionarLibro.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(62, 184);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUsuario.Location = new System.Drawing.Point(43, 115);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(94, 20);
            this.lblIDUsuario.TabIndex = 3;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // lblSeleccionarLibro
            // 
            this.lblSeleccionarLibro.AutoSize = true;
            this.lblSeleccionarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarLibro.Location = new System.Drawing.Point(6, 57);
            this.lblSeleccionarLibro.Name = "lblSeleccionarLibro";
            this.lblSeleccionarLibro.Size = new System.Drawing.Size(151, 20);
            this.lblSeleccionarLibro.TabIndex = 2;
            this.lblSeleccionarLibro.Text = "Selecciona el libro:";
            // 
            // formPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 428);
            this.Controls.Add(this.lblPrestamoLibro);
            this.Controls.Add(this.grpDatosPrestamo);
            this.Name = "formPrestamoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrestamoLibro";
            this.grpDatosPrestamo.ResumeLayout(false);
            this.grpDatosPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamoLibro;
        private System.Windows.Forms.GroupBox grpDatosPrestamo;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtSeleccionarLibro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Label lblSeleccionarLibro;
    }
}