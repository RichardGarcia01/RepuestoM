namespace RepuestoM.Shared.Records;

public class UsuarioRollRecords
{
    public UsuarioRollRecords(int id, string nombre, bool permisoParaCrear, bool permisoParaEditar, bool permisoParaEliminar)
    {
       this. Id = id;
       this. Nombre = nombre;
       this. PermisoParaCrear = permisoParaCrear;
        this.PermisoParaEditar = permisoParaEditar;
       this. PermisoParaEliminar = permisoParaEliminar;
    }

    public int Id {get;set;}

 public string Nombre {get;set;} = null!;

 public bool PermisoParaCrear{get;set;}

 public bool PermisoParaEditar{get;set;}

 public bool PermisoParaEliminar{get;set;}
}
