using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryJerezIEFI
{
    public partial class frmModificarContraseña : Form
    {
        public frmModificarContraseña()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioNuevo.Text.Trim();
            string nueva = txtContraseñaNueva.Text;
            string confirmar = txtContraseñaRepe.Text;

            if (usuario == "" || nueva == "" || confirmar == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (ClsCuenta.UsuarioExiste(usuario))
            {
                ClsCuenta.ActualizarContraseña(usuario, nueva);
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }

            frmInicio login = new frmInicio();
            login.Show();
            this.Close();
        }
    }
    
}
