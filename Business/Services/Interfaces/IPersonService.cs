using Business.Core;
using Repository.Models;

namespace Business.Services.Interfaces
{
    public interface IPersonService : IEntityService<Person, long>
    {
    }
}
