using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Neighbourhood_Alert.Models
{
    public class Neighbourhood_AlertContext : DbContext
    {
        public Neighbourhood_AlertContext (DbContextOptions<Neighbourhood_AlertContext> options)
            : base(options)
        {
        }

        public DbSet<Neighbourhood_Alert.Models.CrimesReported> CrimesReported { get; set; }
    }
}
