using Journal.Domain.Models;
namespace Journal.Application
{
    using System.Collections.Generic;
  
    namespace Journal.Application
    {
        public interface ISalatRepository
		{
            // List<Domain.Models.Salat> GetAllMembers();

            Task<IEnumerable<Salat>> GetAllAsync();
            Task<Salat> GetAsync(int id);
            Task DeleteAsync(int id);
            Task AddAsync(Salat salat);
        }
    }
}
