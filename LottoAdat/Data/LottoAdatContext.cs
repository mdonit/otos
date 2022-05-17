using LottoSzimulator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoSzimulator.Data
{
    public class LottoAdatContext:DbContext
    {
        public DbSet<Huzas> Otos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;database=SzoftI3Lotto;Trusted_Connection=true"); 
        }
    }
}
