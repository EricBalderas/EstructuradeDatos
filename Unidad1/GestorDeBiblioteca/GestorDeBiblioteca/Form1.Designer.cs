namespace GestorDeBiblioteca
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
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLibrosDisponibles = new System.Windows.Forms.Button();
            this.btnDevolverLibro = new System.Windows.Forms.Button();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.btnRegistarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.Location = new System.Drawing.Point(104, 69);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(276, 51);
            this.lblBiblioteca.TabIndex = 0;
            this.lblBiblioteca.Text = "BIBLIOTECA";
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.btnSalir);
            this.grpMenu.Controls.Add(this.btnDevolverLibro);
            this.grpMenu.Controls.Add(this.btnPrestarLibro);
            this.grpMenu.Controls.Add(this.btnRegistarUsuario);
            this.grpMenu.Controls.Add(this.btnRegistrarLibro);
            this.grpMenu.Location = new System.Drawing.Point(80, 136);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(319, 309);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Elige una opcion";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(86, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLibrosDisponibles
            // 
            this.btnLibrosDisponibles.Location = new System.Drawing.Point(166, 462);
            this.btnLibrosDisponibles.Name = "btnLibrosDisponibles";
            this.btnLibrosDisponibles.Size = new System.Drawing.Size(144, 34);
            this.btnLibrosDisponibles.TabIndex = 4;
            this.btnLibrosDisponibles.Text = "Libros Disponibles";
            this.btnLibrosDisponibles.UseVisualStyleBackColor = true;
            this.btnLibrosDisponibles.Click += new System.EventHandler(this.btnLibrosDisponibles_Click);
            // 
            // btnDevolverLibro
            // 
            this.btnDevolverLibro.Location = new System.Drawing.Point(86, 175);
            this.btnDevolverLibro.Name = "btnDevolverLibro";
            this.btnDevolverLibro.Size = new System.Drawing.Size(144, 40);
            this.btnDevolverLibro.TabIndex = 3;
            this.btnDevolverLibro.Text = "Devolver Libro";
            this.btnDevolverLibro.UseVisualStyleBackColor = true;
            this.btnDevolverLibro.Click += new System.EventHandler(this.btnDevolverLibro_Click);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Location = new System.Drawing.Point(86, 130);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(144, 39);
            this.btnPrestarLibro.TabIndex = 2;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = true;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // btnRegistarUsuario
            // 
            this.btnRegistarUsuario.Location = new System.Drawing.Point(86, 82);
            this.btnRegistarUsuario.Name = "btnRegistarUsuario";
            this.btnRegistarUsuario.Size = new System.Drawing.Size(144, 42);
            this.btnRegistarUsuario.TabIndex = 1;
            this.btnRegistarUsuario.Text = "Registrar Usuario";
            this.btnRegistarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistarUsuario.Click += new System.EventHandler(this.btnRegistarUsuario_Click);
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.Location = new System.Drawing.Point(86, 36);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(144, 40);
            this.btnRegistrarLibro.TabIndex = 0;
            this.btnRegistrarLibro.Text = "Registrar Libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = true;
            this.btnRegistrarLibro.Click += new System.EventHandler(this.btnRegistrarLibro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 532);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnLibrosDisponibles);
            this.Controls.Add(this.lblBiblioteca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorBiblioteca";
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLibrosDisponibles;
        private System.Windows.Forms.Button btnDevolverLibro;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.Button btnRegistarUsuario;
        private System.Windows.Forms.Button btnRegistrarLibro;
    }
}

