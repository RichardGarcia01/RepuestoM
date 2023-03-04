

using System.ComponentModel.DataAnnotations;

namespace RepuestoM.Shared.Request;

public class UsuarioRolCreateRequest
{
    [Required(ErrorMessage = "se debe poner el nombre del ROl"),
    MinLength(5,ErrorMessage = "Debe tener almenos 5 carateres "),
    MaxLength(50,ErrorMessage ="No puede superal los 50 caracteres")
    ]

 public string Nombre {get;set;} = null!;
 public bool PermisoParaCrear{get;set;}
 public bool PermisoParaEditar{get;set;}
 public bool PermisoParaEliminar{get;set;}
}


