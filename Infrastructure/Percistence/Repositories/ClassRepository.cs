using Core.Repositories;
using Infrastructure.Percistence.Context;

namespace Infrastructure.Percistence.Repositories;

public class ClassRepository : BaseRepository, IClassRepository
{
    public ClassRepository(AppDbContext context) : base(context) {}

}
