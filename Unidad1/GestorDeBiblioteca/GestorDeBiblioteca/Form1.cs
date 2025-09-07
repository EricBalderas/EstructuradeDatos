using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Biblioteca miBiblioteca = new Biblioteca();
        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            // Crear instancia del nuevo Form
            formRegistrarLibro frm = new formRegistrarLibro();
             
            // Mostrarlo
            frm.Show(); // Se puede usar ShowDialog() si quieres que sea modal
        }

        private void btnRegistarUsuario_Click(object sender, EventArgs e)
        {
            formRegistrarLibro frm = new formRegistrarLibro();
            frm.Show();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            formPrestamoLibro frm = new formPrestamoLibro();
            frm.Show();
        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            formDevolucionLibro frm = new formDevolucionLibro();
            frm.Show();
        }

        private void btnLibrosDisponibles_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
