using MyWebApp.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebApp.Services
{
    public class PeopleService : IPeopleService
    {
        private PeopleContext _context;

        public peopleservice(peoplecontext context)

        {

            _context = context;

        }

        public async Task<List<Person>> GetAllPeopleAsync()
        {
            return await _context.Person.ToListAsync();
        }
    }
}
