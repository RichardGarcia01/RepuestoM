using RepuestoM.Shared.Router;

namespace RepuestoM.Shared.Router;

public class RouteApiBase
{
    public const string API = "/api";
    public int Id {get;set;}
    public const string IdParameter = "{Id:int}";
}
public class UsuarioRolRouteManager:RouteApiBase
{
 public  const string BASE = $"{API}/Roles";
 public const string GetById = $"{BASE}/{IdParameter}";
 public static string BuildRouter (int Id) =>  GetById.Replace(IdParameter,Id.ToString());
}

public class UsuarioRouteManager:RouteApiBase
{
 public  const string BASE = $"{API}/users";
}
