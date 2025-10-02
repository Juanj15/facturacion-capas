namespace Capa_Negocio
{
    public class EmpleadoService
    {
        private readonly NEGEmpleados _negEmpleados = new NEGEmpleados();

        public void Create(EmpleadoDTO dto, string usuarioModifico)
        {
            _negEmpleados.Create(
                dto.Nombre,
                long.Parse(dto.Documento),
                dto.Direccion,
                dto.Telefono,
                dto.Correo,
                dto.NombreRol,
                usuarioModifico
            );
        }

        public void Update(EmpleadoDTO dto, string usuarioModifico)
        {
            _negEmpleados.Update(
                dto.Id,
                dto.Nombre,
                long.Parse(dto.Documento),
                dto.Telefono,
                dto.Correo,
                dto.Direccion,
                dto.NombreRol,
                usuarioModifico
            );
        }
    }
}

