namespace PrestamosGrupo4.Models
{
    public class usuarioRolModel
    {
        public int idRol { get; set; }
        public int idUsuario { get; set; }
        public string? nombreRol { get; set; }
        public string? nombreUsuario { get; set; }
        public  List<rolModel>? roles { get; set; }

    }
}
