using Microsoft.EntityFrameworkCore;
using Models.SalerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.EF.SalerDb
{
    public class SalerDbContext : DbContext
    {
        public SalerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalerInfo> SalerInfo { get; set; }

        public DbSet<SalerScore> SalerScore { get; set; }

        public DbSet<SalerAddress> SalerAddress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //判断当前数据库是Oracle 需要手动添加Schema(DBA提供的数据库账号名称)
            if (this.Database.IsOracle())
            {
                // 设定当前默认table space
                modelBuilder.HasDefaultSchema("SALER");
            }

            modelBuilder.Entity<SalerInfo>(entity =>
            {
                entity.Property(e => e.Id).UseHiLo(Models.SalerDb.SalerInfo.SEQ_SALERINFO_ID);
            });

            modelBuilder.Entity<SalerScore>(entity =>
            {
                entity.Property(e => e.Id).UseHiLo(Models.SalerDb.SalerScore.SEQ_SALER_SCORE_ID);
            });

            modelBuilder.Entity<SalerAddress>(entity =>
            {
                entity.Property(e => e.Id).UseHiLo(Models.SalerDb.SalerAddress.SEQ_SALER_ADDRESS_ID);
            });

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle(Consts.ORACLE_CONNSTR);

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
