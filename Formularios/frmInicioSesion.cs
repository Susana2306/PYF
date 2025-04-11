using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYF.Formularios
{
    public partial class frmInicioSesion : Form
    {
        public frmInicio inicio;
        
        public frmInicioSesion(frmInicio Finicio)
        {
            InitializeComponent();
            this.inicio = Finicio;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistro registro = new frmRegistro(inicio);
            registro.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close(); //Para "cerrar" el formulario y volver al inicio
            inicio.Show();
        }

        private void lblOlvidasteC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecuperacionContrasena RecContra = new frmRecuperacionContrasena(this);
            RecContra.Show();
        }
    }
}
