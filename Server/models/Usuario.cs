using RepuestoM.Shared.Request;
using System.ComponentModel.DataAnnotations;

namespace RespuestoM.Server.Models;

public class Usuario
{

    [Key]
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public UsuarioRol UsuarioRol { get; set; } = default!;
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string password { get; set; } = null!;
    public static Usuario Crear(UsuarioRequest request)
    {
        return new Usuario()
        {
            UsuarioRolId = request.UsuarioRolId,
            Name = request.Name,
            Nickname = request.Nickname,
            password = request.password
        };
    }
    public void Editar(UsuarioRequest request)
    {
        UsuarioRolId = request.UsuarioRolId;
        Name = request.Name;
        Nickname = request.Nickname;
        password = request.password;

    }

    internal object ToRecord()
    {
        throw new NotImplementedException();
    }
}