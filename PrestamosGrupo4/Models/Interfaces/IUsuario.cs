using PrestamosGrupo4.Models.Entidades;

namespace PrestamosGrupo4.Models.Interfaces

{
    public interface IUsuario
    {
        IEnumerable<UsuarioModel> GetUsuarios();
        string AgregarUsuario(UsuarioModel usuario);
        string EditarUsuario(UsuarioModel usuario);
        string EliminarUsuario(UsuarioModel usuario);
        UsuarioModel Buscar(int id);
        IEnumerable<rolModel> GetRoles();
        string AgregarRolUsuario(rolModel rol, UsuarioModel usuario);
        string EliminarRolUsuario(int idRol, int idUsuario);

    }
}
