﻿namespace UniversityHousingSystem.Core.Features.Events.Queries.Results
{
    public class GetAllGuardiansResponse
    {
        public int GuardianId { get; set; }
        public string FirstName { get; set; } = default!;
        public string SecondName { get; set; } = default!;
        public string ThirdName { get; set; } = default!;
        public string FourthName { get; set; } = default!;
        public string Job { get; set; } = default!;
        public string NationalId { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string GuardianRelation { get; set; } = default!;
    }
}
