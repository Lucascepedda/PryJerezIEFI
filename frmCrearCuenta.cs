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
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            string nombre = txtUsuarioNuevo.Text.Trim();
            string contraseña = txtContraseñaNueva.Text.Trim();
            string categoria = CmbCategorias.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            bool exito = ClsCuenta.RegistrarUsuario(nombre, contraseña, categoria);

            if (exito)
            {
                MessageBox.Show("Cuenta creada exitosamente.");
                frmInicio login = new frmInicio();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu me = new frmMenu();
            me.ShowDialog();
            this.Close();

        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }
    
}
