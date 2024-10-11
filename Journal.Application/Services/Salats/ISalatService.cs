using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journal.Domain.Models;

namespace Journal.Application.Services.Salats
{
    public interface ISalatService
	{
		Task <IEnumerable<Salat>> GetAllAsync();
		Task <Salat> GetAsync (int id);
		Task DeleteAsync (int id);
		Task AddAsync (Salat salat);
	}
}
