using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.OleDb;

namespace PryJerezIEFI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int radius = 10; // radio de las esquinas
            Rectangle bounds = txtUsuario.ClientRectangle;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Superior derecha
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Inferior derecha
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Inferior izquierda
            path.CloseAllFigures();

            txtUsuario.Region = new Region(path);
        }
        private bool ValidarLogin(string usuario, string contraseña)
        {

            using (OleDbConnection conexion = ClsBaseDatos.Conexion())
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Ingresá usuario y contraseña.");
                    return false;
                }
                string consulta = "SELECT COUNT(*) FROM Crear WHERE nombre = ? AND contraseña = ?";
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                    comando.Parameters.AddWithValue("?", contraseña);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            ClsSesion.UsuarioActual = usuario;
            ClsSesion.HoraInicio = DateTime.Now;

            if (ValidarLogin(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                frmMenu form = new frmMenu(usuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void lblOlvido_Click_2(object sender, EventArgs e)
        {
            frmModificarContraseña olvi = new frmModificarContraseña();
            olvi.Show();
        }

        private void lblCuentaNueva_Click_2(object sender, EventArgs e)
        {
            frmCrearCuenta dou = new frmCrearCuenta();
            dou.Show();
        }

        private void lblCuentaNueva_Click(object sender, EventArgs e)
        {
            frmCrearCuenta cre = new frmCrearCuenta();
            cre.Show();

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
