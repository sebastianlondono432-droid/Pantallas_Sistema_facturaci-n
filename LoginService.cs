using System;

namespace Pantallas_Sistema_Facturación.Services
{
    public static class LoginService
    {
        private const string Usuario = "admin";
        private const string Contraseña = "1234";

        public static bool ValidarUsuario(string usuario, string password)
        {
            if (usuario == null || password == null) return false;

            var u = usuario.Trim();
            var p = password.Trim();

            return string.Equals(u, Usuario, StringComparison.OrdinalIgnoreCase) && p == Contraseña;
        }
    }
}
