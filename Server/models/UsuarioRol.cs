using System.ComponentModel.DataAnnotations;
using RepuestoM.Shared.Request;
using RepuestoM.Shared.Records;



namespace RespuestoM.Server.Models;



public class UsuarioRol

{
    [Key]
 public int Id {get;set;}
 public string Nombre {get;set;} = null!;
 public bool PermisoParaCrear{get;set;}
 public bool PermisoParaEditar{get;set;}
 public bool PermisoParaEliminar{get;set;}
 public virtual ICollection<UsuarioRol>? Usuarios {get;set;}= null!;

public static UsuarioRol Create(UsuarioRolCreateRequest request)
{
    return new UsuarioRol(){
        Nombre= request.Nombre,
        PermisoParaCrear= request.PermisoParaCrear,
        PermisoParaEditar= request.PermisoParaEditar,
        PermisoParaEliminar= request.PermisoParaEliminar,
    };
}
public void Modificar(UsuarioRolUpdateRequest request){
    if(Nombre!= request.Nombre)
       Nombre = request.Nombre;
    if(PermisoParaCrear!= request.PermisoParaCrear)
       PermisoParaCrear = request.PermisoParaCrear;
    if(PermisoParaEditar != request.PermisoParaEditar)
       PermisoParaEditar = request.PermisoParaEditar;
    if(PermisoParaEliminar != request.PermisoParaEliminar)
       PermisoParaEditar = request.PermisoParaEliminar;      
}
public UsuarioRollRecords ToRecord()
{
    return new UsuarioRollRecords(Id,Nombre,PermisoParaCrear,PermisoParaEditar,PermisoParaEliminar);
}
}