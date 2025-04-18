﻿using Microsoft.EntityFrameworkCore;
using UniversityHousingSystem.Data.Entities;
using UniversityHousingSystem.Infrastructure.Repositories;
using UniversityHousingSystem.Service.Abstractions;

namespace UniversityHousingSystem.Service.implementation
{
    public class CityService : ICityService
    {
        #region Fields
        private readonly ICityRepository _cityRepository;
        #endregion

        #region Contructors
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<City>> GetAllByGovernorateIdAsync(int governorateId)
        {
            return await _cityRepository.GetTableNoTracking()
                .Where(c => c.GovernorateId == governorateId)
                .Include(v => v.Villages)
                .ToListAsync();
        }
        #endregion
    }
}
