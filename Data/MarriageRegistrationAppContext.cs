using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarriageRegistrationApp.Models;

namespace MarriageRegistrationApp.Data
{
    public class MarriageRegistrationAppContext : DbContext
    {
        public MarriageRegistrationAppContext (DbContextOptions<MarriageRegistrationAppContext> options)
            : base(options)
        {
        }

        public DbSet<MarriageRegistrationApp.Models.Marriage> Marriage { get; set; } = default!;
    }
}
