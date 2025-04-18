﻿using UniversityHousingSystem.Data.Entities;

namespace UniversityHousingSystem.Service.Abstractions
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllByGovernorateIdAsync(int governorateId);

    }
}
