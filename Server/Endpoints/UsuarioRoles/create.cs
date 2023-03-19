using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepuestoM.Server.Context;
using RepuestoM.Shared.Wrapper;
using RespuestoM.Server.Models;

namespace RepuestoM.Server.Endpoints.UsuarioRoles;

using Request = RepuestoM.Shared.Request.UsuarioRolCreateRequest;
using Repuesta = Resultlist<int>;

public class create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Repuesta>
{
    public create(IMyDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public IMyDbContext DbContext { get; }

    public override async Task<ActionResult<Repuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            #region validaciones 
            var rol = await DbContext.UsuariosRoles.FirstOrDefaultAsync(r => r.Nombre.ToLower() == request.Nombre.ToLower());
            if (rol != null)
                return Repuesta.fail($"Ya existe un rol con este nombre'({request.Nombre}).");
            #endregion
            rol = UsuarioRol.Create(request);
            DbContext.UsuariosRoles.Add(rol);
            await DbContext.SaveChangesAsync(cancellationToken);
            return Repuesta.success(rol.Id);

        }
        catch (Exception e)
        {
            return Repuesta.fail(e.Message);

        }
        
    }
}

     

    