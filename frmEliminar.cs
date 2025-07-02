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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text;

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (ClsCuenta.EliminarUsuario(usuario, contrasena))
            {
                MessageBox.Show("Usuario Eliminado.");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario o la contraseña es incorrecta.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu asd = new frmMenu();
            asd.Show();
            this.Close();
        }
    }
}
