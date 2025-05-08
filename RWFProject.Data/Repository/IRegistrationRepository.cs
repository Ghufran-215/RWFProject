using RWFProject.Data.Models.Domain;

namespace RWFProject.Data.Repository;

public interface IRegistrationRepository
{
    Task<IEnumerable<Registration>> GetAllAsync();
    string? GetById(int id);
    Task<Registration?> GetByIdAsync(int id);


}
