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
    public partial class frmRecuperacionContrasena : Form
    {
        private frmInicioSesion InicioSesion;
        public frmRecuperacionContrasena(frmInicioSesion inicioSesion)
        {
            InitializeComponent();
            this.InicioSesion = inicioSesion;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNuevaContrasena nuevaContrasena = new frmNuevaContrasena(this.InicioSesion);
            nuevaContrasena.Show();
        }
    }
}
