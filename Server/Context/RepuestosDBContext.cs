using Microsoft.EntityFrameworkCore;
using RespuestoM.Server.Models;
namespace RepuestoM.Server.Context;
internal interface IMyDbContext
{
    DbSet<Usuario> Usuarios { get; set; }
    DbSet<Usuario> UsuariosRoles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

internal class RepuestosDBContext : DbContext, IMyDbContext
{
    protected readonly IConfiguration _configuration;
    public RepuestosDBContext(IConfiguration configuration)
    {
      _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("RepuestoM"));
    }

    #region  tabla de la BD.
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Usuario> UsuariosRoles { get; set; } = null!;
    #endregion
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default!)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}