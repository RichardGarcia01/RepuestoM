using RepuestoM.Shared.Wrapper;
using RepuestoM.Shared.Records;
using RepuestoM.Shared.Router;
using RepuestoM.Client.Extensions;

namespace RepuestoM.Client.Managers;

public interface IUsuarioRolManagers
{
    Task<Resultlist<UsuarioRollRecords>> GetAsync();
}

public class UsuarioRolManagers : IUsuarioRolManagers
{
    private readonly HttpClient httpClient;

    public UsuarioRolManagers(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<Resultlist<UsuarioRollRecords>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(UsuarioRolRouteManager.BASE);
            var resultado = await response.ToResultList<UsuarioRollRecords>();
            return resultado;

        }
        catch (Exception e)
        {
            return Resultlist<UsuarioRollRecords>.fail(e.Message);

        }
    }

}