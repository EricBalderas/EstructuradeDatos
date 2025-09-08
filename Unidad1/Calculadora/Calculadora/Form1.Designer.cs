namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radSuma = new RadioButton();
            radResta = new RadioButton();
            radMultiplicacion = new RadioButton();
            radDivision = new RadioButton();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(179, 85);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(143, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular Operacion";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(93, 21);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 1;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(319, 21);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 2;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 28);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Numero 2";
            // 
            // radSuma
            // 
            radSuma.AutoSize = true;
            radSuma.Location = new Point(12, 70);
            radSuma.Name = "radSuma";
            radSuma.Size = new Size(67, 24);
            radSuma.TabIndex = 5;
            radSuma.TabStop = true;
            radSuma.Text = "Suma";
            radSuma.UseVisualStyleBackColor = true;
            // 
            // radResta
            // 
            radResta.AutoSize = true;
            radResta.Location = new Point(12, 100);
            radResta.Name = "radResta";
            radResta.Size = new Size(66, 24);
            radResta.TabIndex = 6;
            radResta.TabStop = true;
            radResta.Text = "Resta";
            radResta.UseVisualStyleBackColor = true;
            // 
            // radMultiplicacion
            // 
            radMultiplicacion.AutoSize = true;
            radMultiplicacion.Location = new Point(12, 130);
            radMultiplicacion.Name = "radMultiplicacion";
            radMultiplicacion.Size = new Size(124, 24);
            radMultiplicacion.TabIndex = 7;
            radMultiplicacion.TabStop = true;
            radMultiplicacion.Text = "Multiplicación";
            radMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // radDivision
            // 
            radDivision.AutoSize = true;
            radDivision.Location = new Point(12, 160);
            radDivision.Name = "radDivision";
            radDivision.Size = new Size(83, 24);
            radDivision.TabIndex = 8;
            radDivision.TabStop = true;
            radDivision.Text = "Division";
            radDivision.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(179, 160);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(179, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 252);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(radDivision);
            Controls.Add(radMultiplicacion);
            Controls.Add(radResta);
            Controls.Add(radSuma);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label1;
        private Label label2;
        private RadioButton radSuma;
        private RadioButton radResta;
        private RadioButton radMultiplicacion;
        private RadioButton radDivision;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}