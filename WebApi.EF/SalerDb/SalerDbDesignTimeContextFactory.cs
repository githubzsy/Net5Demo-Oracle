using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.EF.SalerDb
{
    public class SalerDbDesignTimeContextFactory : IDesignTimeDbContextFactory<SalerDbContext>
    {
        public SalerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalerDbContext>();
            optionsBuilder.UseOracle(Consts.ORACLE_CONNSTR);

            return new SalerDbContext(optionsBuilder.Options);
        }
    }
}
