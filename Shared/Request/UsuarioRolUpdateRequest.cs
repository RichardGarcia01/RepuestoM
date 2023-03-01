

using System.ComponentModel.DataAnnotations;

namespace RepuestoM.Shared.Request;

public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest
{

[Required]
public int Id {get;set;}

}


