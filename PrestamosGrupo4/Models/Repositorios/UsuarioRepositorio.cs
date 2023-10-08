using PrestamosGrupo4.Models.Entidades;
using PrestamosGrupo4.Models.Interfaces;
using System.Data.SqlClient;

namespace PrestamosGrupo4.Models.Repositorios
{
    public class UsuarioRepositorio : IUsuario
    {
        private string cadena;

        public UsuarioRepositorio()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("connection");
        }


        public string AgregarRolUsuario(rolModel rol, UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public string AgregarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public string EditarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public string EliminarRolUsuario(int idRol, int idUsuario)
        {
            throw new NotImplementedException();
        }

        public string EliminarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<rolModel> GetRoles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetUsuarios()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            using(SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand command = new SqlCommand("sp_GetListaUsuarios", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    usuarios.Add(new UsuarioModel
                    {
                        idUsuario = dr.GetInt32(0),
                        nombres = dr.GetString(1),
                        password = dr.GetString(2),
                        fechaRegistro = dr.GetDateTime(3),
                        fechaNacimiento = dr.GetDateTime(4),
                        estado = dr.GetInt32(5),
                        email = dr.GetString(6),
                        aPaterno = dr.GetString(7),
                        numeroDocumento = dr.GetString(8),
                        aMaterno = dr.GetString(9),
                        telefono = dr.GetString(10),
                    }) ;
                }
                return usuarios;
            }
        }
    }
}

