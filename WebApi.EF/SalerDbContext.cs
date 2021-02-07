using Microsoft.EntityFrameworkCore;
using Saler.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace WebApi.EF
{
    public class SalerDbContext : DbContext
    {
        public SalerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalerAccount> SalerAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //判断当前数据库是Oracle 需要手动添加Schema(DBA提供的数据库账号名称)
            if (this.Database.IsOracle())
            {
                // 设定当前默认table space
                modelBuilder.HasDefaultSchema("SALER");
            }

            modelBuilder.Entity<SalerAccount>(entity =>
            {
                entity.Property(e => e.Id).UseHiLo(Consts.SEQ_SALER_ID);
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=saler;password=welcome;Data Source=localhost:1521/salepdb;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
