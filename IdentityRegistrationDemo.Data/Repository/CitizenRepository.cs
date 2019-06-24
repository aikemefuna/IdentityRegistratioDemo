using IdentityRegistrationDemo.Data.AppDbContext;
using IdentityRegistrationDemo.Data.DbEntities;
using IdentityRegistrationDemo.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityRegistrationDemo.Data.Repository
{
    public class CitizenRepository : ICitizenRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<CitizenRepository> _logger;

        public CitizenRepository(ApplicationDbContext db, ILogger<CitizenRepository> logger)
        {
            _db = db;
            _logger = logger;
        }
        public async Task<Citizen> CreateAsync(Citizen citizen)
        {
            citizen.NIN = GenerateRandomIdNumber();
            var createdCitizen = await _db.Citizens.AddAsync(citizen);
            await _db.SaveChangesAsync();
            return createdCitizen.Entity;
        }

        public bool IsExists(long bvn)
        {
            var IsDuplicateBvn = _db.Citizens.Select(x => x.BVN == bvn);
            if (IsDuplicateBvn != null)
            {
                return true;
            }
            else return false;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size    
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password    
        public string GenerateRandomIdNumber()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(10000, 99999));
            builder.Append(RandomString(3, false));
            return builder.ToString();
        }
    }
}
