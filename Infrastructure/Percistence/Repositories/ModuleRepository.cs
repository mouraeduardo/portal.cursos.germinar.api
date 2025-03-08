using Core.Repositories;
using Infrastructure.Percistence.Context;

namespace Infrastructure.Percistence.Repositories;

public class ModuleRepository : BaseRepository, IModuleRepository
{
    public ModuleRepository(AppDbContext context) : base(context) {}

}
