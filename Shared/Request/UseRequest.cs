namespace RepuestoM.Shared.Request;

public class UsuarioRequest

{
  
    public int Id {get;set;}
    public int UsuarioRolId {get;set;}
    
    public string Name {get;set;} = null!;
    public string Nickname {get;set;} = null!;
    public string password {get;set;} = null!;
    
}