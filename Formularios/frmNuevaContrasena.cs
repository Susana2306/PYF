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
    public partial class frmNuevaContrasena : Form
    {
        private frmInicioSesion InicioSesion;
       
        public frmNuevaContrasena(frmInicioSesion inicioSesion)
        {
            InitializeComponent();
            this.InicioSesion = inicioSesion;
            

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion.Show();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion.inicio.Show();
        }
    }
}
