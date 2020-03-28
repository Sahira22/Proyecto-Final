using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace APICxCOLLEGEs.Models
{
    public class SDBContext: DbContext
    {
        public SDBContext(DbContextOptions<SDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
