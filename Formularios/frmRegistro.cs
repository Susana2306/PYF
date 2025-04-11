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
    public partial class frmRegistro : Form
    {
        private frmInicio inicio;

        public frmRegistro(frmInicio Finicio)
        {
            InitializeComponent();
            this.inicio= Finicio;
           
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close(); //Para cerrar el formulario y volver al inicio
            inicio.Show();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            frmInicioSesion IS = new frmInicioSesion(inicio);
            IS.Show();
            this.Close();
        }
    }
}
