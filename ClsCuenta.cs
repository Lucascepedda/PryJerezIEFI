using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryJerezIEFI
{
    class ClsCuenta
    {
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        public static bool RegistrarUsuario(string nombre, string contraseña, string categoria)
        {
            // Intenta registrar un nuevo usuario en la tabla NewCuenta
            // Usa parámetros para evitar SQL Injection
            // Si se afecta al menos una fila, devuelve true (registro exitoso)
            try
            {
                using (OleDbConnection conexion = ClsBaseDatos.Conexion()) // Usa tu método que devuelve una conexión abierta
                {
                    string consulta = "INSERT INTO Crear (Nombre, Contraseña, Categoria) VALUES (?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", categoria);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
                return false;
            }
        }
        public static bool UsuarioExiste(string usuario)
        {
            // Verifica si un usuario ya está en la base de datos
            // Devuelve true si lo encuentra, false si no existe
            using (OleDbConnection conexion = ClsBaseDatos.Conexion())
            {
                string consulta = "SELECT COUNT(*) FROM Crear WHERE Nombre = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", usuario);

                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }
        public static bool ActualizarContraseña(string usuario, string nuevaContraseña)
        {
            // Actualiza la contraseña de un usuario específico
            // Devuelve true si se actualizó correctamente
            // Muestra mensajes de confirmación o error
            using (OleDbConnection conexion = ClsBaseDatos.Conexion())
            {
                string consulta = "UPDATE Crear SET Contraseña = ? WHERE Nombre = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", nuevaContraseña);
                comando.Parameters.AddWithValue("?", usuario);

                int filas = comando.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Contraseña Reestablecida.");
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo Reestablecer la contraseña.");
                    return false;
                }
            }
        }
        public static bool EliminarUsuario(string usuario, string contrasena)
        {
            // Elimina un usuario si el nombre y la contraseña coinciden
            // Devuelve true si se eliminó correctamente
            using (OleDbConnection conexion = ClsBaseDatos.Conexion())
            {
                string consulta = "DELETE FROM Crear WHERE Nombre = ? AND Contraseña = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);

                comando.Parameters.AddWithValue("?", usuario);
                comando.Parameters.AddWithValue("?", contrasena);

                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }

        }
    }
}
