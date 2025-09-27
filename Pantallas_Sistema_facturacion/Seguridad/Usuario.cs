namespace Pantallas_Sistema_facturacion.Seguridad
{
    public class Usuario
    {
        public int EmpleadoId { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = ""; // Solo para práctica (en producción se debe hashear)
    }
}
