﻿using UniversityHousingSystem.Data.Entities;
using UniversityHousingSystem.Infrastructure.Context;
using UniversityHousingSystem.Infrastructure.GenericBases;
using UniversityHousingSystem.Infrastructure.Repositories;

namespace UniversityHousingSystem.Infrastructure.implementation
{
    public class HighSchoolRepository : GenericRepositoryAsync<HighSchool>, IHighSchoolRepository
    {
        public HighSchoolRepository(AppDbContext context) : base(context)
        {

        }
    }
}
