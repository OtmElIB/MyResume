using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class LinksService : EntityService<Link, long>, ILinksService
    {
        public LinksService(ILinkRepository repository)
            : base(repository)
        {
        }
    }
}
