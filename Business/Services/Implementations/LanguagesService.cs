using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class LanguagesService : EntityService<Language, long>, ILanguagesService
    {
        public LanguagesService(ILanguageRepository repository)
            : base(repository)
        {
        }
    }
}
