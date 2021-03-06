﻿using Repository.Models.Core;

namespace Repository.Models
{
    /// <summary>
    /// Skill Entity
    /// </summary>
    public class Skill : Entity<long>
    {
        public string Title { get; set; }

        public int Score { get; set; }

        public long? PersonID { get; set; }

        public Person Person { get; set; }
    }
}
