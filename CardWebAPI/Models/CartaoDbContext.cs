using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardWebAPI.Models
{
    public class CartaoDbContext : DbContext
    {
        public CartaoDbContext(DbContextOptions<CartaoDbContext> options) : base(options)
        {
        }

        public DbSet<CardDetail> CardDetails { get; set; }
    }
}
