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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb"))
            {
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Usuario, Fecha_Ingreso, TiempoUso FROM Sesiones ORDER BY Fecha_Ingreso DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAuditoria.DataSource = dt;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu vol = new frmMenu();
            vol.ShowDialog();
            this.Hide();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {

        }
    }
}
