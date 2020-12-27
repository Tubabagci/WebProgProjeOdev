using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProjeOdev.Models
{
    public class Context: DbContext   /*Model için EF Core işlevselliği (oluşturma, okuma, güncelleştirme, silme)
                                      koordine etmek için bir veritabanı bağlamı sınıfı gerekir.
                                      Veritabanı bağlamı Microsoft. EntityFrameworkCore.DbContext
                                      öğesinden türetilir ve veri modeline dahil edilecek varlıkları belirtir.*/
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-GS8GRQE0\\MSSQLSERVER01; database=AnalogDB; integrated security=true; ");
        }

        public DbSet<AnalogMakine> AnalogMakines { get; set; }     /*Önceki kod, varlık kümesi için bir Dbset<> özelliği oluşturur. 
                                                                    Entity Framework terminolojisinde, genellikle bir varlık kümesi bir veritabanı tablosuna karşılık gelir. 
                                                                    Bir varlık, tablodaki bir satıra karşılık gelir.*/
        public DbSet<AnalogFotograf> AnalogFotografs { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
