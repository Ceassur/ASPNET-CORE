using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MYCOMBIN.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base 
        (options){
            
        }
        
        public DbSet<SendInfo> SendInfos => Set<SendInfo>();
        public DbSet<UserInfo> UserInfos => Set<UserInfo>();
         public DbSet<UserPersona> UserPersonas => Set<UserPersona>();
        public DbSet<Persona> Personas => Set<Persona>();

    }
}