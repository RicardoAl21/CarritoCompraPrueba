using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Negocio.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; } = 0;

        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public bool EsAdmin { get; set; } = false;

        public DateTime? FechaRegistro { get; set; } = null;
    }
}
