using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Pantallas_Sistema_facturación
{
    public class LoginService
    {
        // Cadena de conexión para SQL Server Express
        private string conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=BD_FACTURAS;Integrated Security=True";

        // Método para validar usuario y contraseña

public bool ValidarUsuario(string usuario, string contraseña)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT ContraseñaHash FROM Usuarios WHERE Usuario=@usuario";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar).Value = usuario;
                    var hashDb = cmd.ExecuteScalar() as string;
                    if (hashDb == null) return false;

                    // Calcular hash de la contraseña ingresada
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                        string hashInput = BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
                        return hashInput == hashDb;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Loguear el error o manejarlo según corresponda
            return false;
        }
    }
    }
}

