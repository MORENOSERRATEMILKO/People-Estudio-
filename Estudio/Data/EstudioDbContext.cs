using Estudio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudio.Data
{
    public class EstudioDbContext: DbContext
    {
        public DbSet<Music> Songs{ get; set; } //pq no hay plural de music (songs deberia ser music)


        public EstudioDbContext(DbContextOptions<EstudioDbContext>options): base(options)//enlaza la base de datos c/ el entity framework 

        {
                
        }
    }
}
