using Journal.Application.Journal.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journal.Domain.Models;

namespace Journal.Application.Services.Salats
{
    public class SalatService : ISalatService
	{
		private readonly ISalatRepository _repository;
		public SalatService(ISalatRepository salatRepository) {
			_repository = salatRepository;
		}

        Task ISalatService.AddAsync(Salat salat)
        {
            throw new NotImplementedException();
        }

        Task ISalatService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Salat>> ISalatService.GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        Task<Salat> ISalatService.GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
