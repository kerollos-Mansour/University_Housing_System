﻿using UniversityHousingSystem.Data.Entities;
using UniversityHousingSystem.Data.Helpers.Enums;

namespace UniversityHousingSystem.Service.Abstractions
{
    public interface IOldStudentService
    {
        Task<IEnumerable<OldStudent>> GetAllAsync();
        IQueryable<OldStudent> GetAllQueryable(string? search, EnStudentOrdering? studentOrderingEnum);
        Task<OldStudent?> GetAsync(int id);
        Task<OldStudent> CreateAsync(OldStudent oldStudent);
        Task<OldStudent> UpdateAsync(OldStudent oldStudentToUpdate);
        Task<bool> DeleteAsync(OldStudent oldStudentToDelete);
    }
}
