using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners23.Models;

namespace CapenexisLearners.Data
{
    public class CapenexisLearnersContext : DbContext
    {
        public CapenexisLearnersContext (DbContextOptions<CapenexisLearnersContext> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners23.Models.Learners> Learners { get; set; } = default!;

        public DbSet<CapenexisLearners23.Models.Courses> Courses { get; set; } = default!;

        public DbSet<CapenexisLearners23.Models.Facilitators> Facilitators { get; set; } = default!;
    }
}
