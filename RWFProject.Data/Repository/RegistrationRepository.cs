using RWFProject.Data.DataAccess;
using RWFProject.Data.Models.Domain;
using RWFProject.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMvcDemo.Data.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ISqlDataAccess _db;

        public RegistrationRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        // Get all registrations
        public async Task<IEnumerable<Registration>> GetAllAsync()
        {
            return await _db.GetData<Registration, dynamic>("sp_GetRegistrations", new { });
        }

        public string? GetById(int id)
        {
            throw new NotImplementedException();
        }

        // Get a registration by ID
        public async Task<Registration?> GetByIdAsync(int id)
        {
            var results = await _db.GetData<Registration, dynamic>("sp_GetRegistrationById", new { RegistrationId = id });
            return results.FirstOrDefault(); // Return first or null
        }

    }
}
