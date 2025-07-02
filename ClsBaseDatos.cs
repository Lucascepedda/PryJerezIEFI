using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryJerezIEFI
{
    class ClsBaseDatos
    {
        public static string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inicio.mdb";

        public static OleDbConnection Conexion()
        {
            OleDbConnection conexion = new OleDbConnection(CadenaConexion);

            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }

            return conexion;
        }
    }
}
