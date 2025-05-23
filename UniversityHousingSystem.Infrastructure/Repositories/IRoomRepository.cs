﻿using UniversityHousingSystem.Data.Entities;
using UniversityHousingSystem.Infrastructure.GenericBases;

namespace UniversityHousingSystem.Infrastructure.Repositories
{
    public interface IRoomRepository : IGenericRepositoryAsync<Room>
    {
        Task<List<Student>> GetStudentsByRoomIdAsync(int roomId);
        Task SaveChangesAsync();
    }
}
