using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Services
{
    public interface IPeopleService
    {
        Task<List<Person>> GetAllPeopleAsync();
    }
}
