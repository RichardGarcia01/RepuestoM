using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepuestoM.Server.Context;
using RepuestoM.Shared.Records;
using RepuestoM.Shared.Router;
using RepuestoM.Shared.Wrapper;

namespace RepuestoM.Server.Endpoints.UsuarioRoles;
using Repuesta = Resultlist<UsuarioRollRecords>;
public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Repuesta>
{
    private readonly IMyDbContext dbContext;
    
    public  Get(IMyDbContext dbContext)
    {
        this .dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.BASE)]

    public override async Task<ActionResult<Repuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {   try{ 
         var roles = await dbContext.UsuariosRoles
        .Select(rol=>rol.ToRecord())
        .ToListAsync(cancellationToken);

         return Repuesta.success(roles);
       }
            catch(Exception ex )
            {
                return Repuesta.fail(ex.Message);
            }
      }
    }

     

    