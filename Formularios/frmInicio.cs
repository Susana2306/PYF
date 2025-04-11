using PYF.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYF
{
    public partial class frmInicio : Form
    {
        private Form activeForm = null;
        
        public frmInicio()
        {
            InitializeComponent();
            inicial();
        }

        void inicial()
        {
            pnlFacultades.Visible = false;
            pnlIngenieria.Visible = false;
            pnlCienciasEmp.Visible = false;
            pnlCienciasSalud.Visible = false;
        }

        //Oculta los submenus dependiendo de donde este visible
        void ocultarSubmenu()
        {

            if (pnlIngenieria.Visible == true)
                pnlIngenieria.Visible = false;
            if (pnlCienciasEmp.Visible == true)
                pnlCienciasEmp.Visible = false;
            if (pnlCienciasSalud.Visible == true)
                pnlCienciasSalud.Visible = false;

        }

        //Llamado al submenu
        void mostrarSubmenu(Panel submenu)
        {
            ocultarSubmenu();
            submenu.Visible = true;
        }
        //Abre el panel dependiendo el padre
        private void AbrirenPanel(Form frmHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            pnlVista.Controls.Clear();
            pnlVista.Controls.Add(frmHijo);
            pnlVista.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void btnFacultades_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlFacultades);
        }

        private void btnIngenieria_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlIngenieria);
        }

        private void btnCienciasEmp_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlCienciasEmp);
        }

        private void btnCienciasSalud_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlCienciasSalud);
        }

        private void lblInicioSesion_Click(object sender, EventArgs e)
        {
            frmInicioSesion InicioSesion = new frmInicioSesion(this);
            InicioSesion.Show();
            this.Hide();//Permite ocultar la ventana de inicio
           
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro Registro = new frmRegistro(this);
            Registro.Show();
            this.Hide();
        }
    }
}
