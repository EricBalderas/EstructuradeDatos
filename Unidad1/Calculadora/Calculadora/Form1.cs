namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radSuma.Checked)
            {
                double Suma = double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text);
                MessageBox.Show($"El resultado de su operacion es: {Suma}");
            }
            else
            {
                if (radResta.Checked)
                {
                    double Resta = double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text);
                    MessageBox.Show($"El resultado de su operacion es: {Resta}");
                }
                else
                {
                    if (radMultiplicacion.Checked)
                    {
                        double Multiplicacion = double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text);
                        MessageBox.Show($"El resultado de su operacion es: {Multiplicacion}");
                    }
                    else
                    {
                        if (radDivision.Checked)
                        {
                            double Div = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                            MessageBox.Show($"El resultado de su operacion es: {Div}");
                        }
                    }

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(txtNum1.Text);
            }
            catch (Exception)
            {
                txtNum1.Clear();

            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                txtNum1.Clear();

            }
        }
    }
}