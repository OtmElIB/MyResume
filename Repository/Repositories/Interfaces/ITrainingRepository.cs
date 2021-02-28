﻿using Repository.Models;
using Repository.Repositories.Interfaces.Core;

namespace Repository.Repositories.Interfaces
{
    public interface ITrainingRepository : IEntityRepository<Training, long>
    {
    }
}
