using System.Net;
using RepuestoM.Shared.Wrapper;
using Newtonsoft.Json;
namespace RepuestoM.Client.Extensions;

internal static class ResultExtension
{
    internal static async Task<Result<T>> ToResult<T>(this HttpResponseMessage response)
    {
        var repuesta_a_texto  = await response.Content.ReadAsStringAsync();
        var objeto = JsonConvert.DeserializeObject<Result<T>>(repuesta_a_texto);
        return objeto!; 
    }
    internal static async Task<Resultlist<T>> ToResultList<T>(this HttpResponseMessage response)
    {
        var repuesta_a_texto  = await response.Content.ReadAsStringAsync();
        var objeto = JsonConvert.DeserializeObject<Resultlist<T>>(repuesta_a_texto);
        return objeto!; 
    }
}
