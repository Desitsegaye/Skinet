using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entitis;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Data
{
    public class StorContext : DbContext
    {
        public StorContext(  DbContextOptions<StorContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}