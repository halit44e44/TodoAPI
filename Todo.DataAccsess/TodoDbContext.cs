using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.DataAccsess
{
    public class TodoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=W7-BILGISAYAR\\SQLEXPRESS; Database=TodoDb; uid=sa; pwd=123;"); // Db Bağlantı Ayarlarını Gerçekleştiriyoruz
        }

        // TodoDbContext Çağrıldığında DbSet Olarak TodoSamples Dönecek.
        public DbSet<TodoSample> TodoSamples { get; set; }
    }
}
