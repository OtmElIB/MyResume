using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class PersonService : EntityService<Person, long>, IPersonService
    {
        public PersonService(IPersonRepository repository)
            : base(repository)
        {
        }
    }
}
