using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryJerezIEFI
{
    public partial class frmMenu : Form
    {
        private Timer timerUso;

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string NombreUsuario)
        {
            InitializeComponent();

            tssUno.Text = "Bienvenido, " + NombreUsuario;

            ClsSesion.UsuarioActual = NombreUsuario;
            ClsSesion.HoraInicio = DateTime.Now;

            // Registrar ingreso en la base de datos
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb"))
            {
                conn.Open();
                string insert = "INSERT INTO Sesiones (Usuario, Fecha_Ingreso) VALUES (?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("?", ClsSesion.UsuarioActual);
                    cmd.Parameters.AddWithValue("?", ClsSesion.HoraInicio.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Inicializa el timer y muestra la fecha/hora actual
            timerUso = new Timer();
            timerUso.Interval = 1000; // 1 segundo
            timerUso.Tick += TimerUso_Tick;
            timerUso.Start();

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void TimerUso_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempo = DateTime.Now - ClsSesion.HoraInicio;
            lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // actualiza la fecha en tiempo real
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            timerUso.Stop();
            this.Close(); // dispara FormClosed
            frmInicio login = new frmInicio();
            login.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeSpan tiempoUso = DateTime.Now - ClsSesion.HoraInicio;
            string tiempoUsoString = tiempoUso.ToString(@"hh\:mm\:ss");

            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb"))
            {
                conn.Open();
                string query = "UPDATE Sesiones SET TiempoUso = ? WHERE Usuario = ? AND Fecha_Ingreso = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tiempoUsoString);
                    cmd.Parameters.AddWithValue("?", ClsSesion.UsuarioActual);
                    cmd.Parameters.AddWithValue("?", ClsSesion.HoraInicio.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // El resto de tus métodos para los botones del menú:
        private void aUDITORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria a = new frmAuditoria();
            a.ShowDialog();
        }

        private void eLIMINARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar aa = new frmEliminar();
            aa.ShowDialog();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar aa = new frmEliminar();
            aa.ShowDialog();
        }

        private void aUDITORIAToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmAuditoria di = new frmAuditoria();
            di.ShowDialog();
            this.Close();
        }

        private void eLIMINARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEliminar aa = new frmEliminar();
            aa.ShowDialog();
        }

        private void auditoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAuditoria au = new frmAuditoria();
            au.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearCuenta cue = new frmCrearCuenta();
            cue.ShowDialog();
            this.Close();
        }

        private void eliminarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar eli = new frmEliminar();
            eli.ShowDialog();
            this.Close();
        }

        private void tssUno_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void lblFecha_Click(object sender, EventArgs e) { }
    }
}

