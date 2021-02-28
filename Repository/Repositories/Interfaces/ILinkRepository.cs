using Repository.Models;
using Repository.Repositories.Interfaces.Core;

namespace Repository.Repositories.Interfaces
{
    public interface ILinkRepository : IEntityRepository<Link, long>
    {
    }
}
