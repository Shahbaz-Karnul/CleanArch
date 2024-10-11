using Journal.Application.Journal.Application;
using Journal.Domain.Models;
using Journal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Journal.Infrastructure.Repositories
{
    public class SalatRepository : ISalatRepository
    {
        //public static List<Salat> lstMembers = new List<Salat>()
        //{
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1" },
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1"},
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1"},
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1"},
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1"},
        //   new Salat {Id=1, Din=DateTime.Now, Fajr="Yes",Zohr="Yes",Asar="Yes",Maghreb="No",Isha="Yes",Remarks="Test1"}
        //};
        //public List<Salat> GetAllMembers()
        //{
        //    return lstMembers;
        //}

        private readonly AppDBContext _context;
        public SalatRepository (AppDBContext context)
        {
            _context = context;
        }

        Task ISalatRepository.AddAsync(Salat salat)
        {
            throw new NotImplementedException();
        }

        Task ISalatRepository.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Salat>>ISalatRepository.GetAllAsync()
        {
            return  await _context.Salats.ToListAsync();
            
        }

        Task<Salat> ISalatRepository.GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

