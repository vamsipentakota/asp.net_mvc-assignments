using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using codebase6.Model;

namespace codebase6.Data
{
    public class codebase6Context : DbContext
    {
        public codebase6Context (DbContextOptions<codebase6Context> options)
            : base(options)
        {
        }

        public DbSet<codebase6.Model.Employee> Employee { get; set; }
    }
}
