using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApi.EF;
using WebApi.EF.SalerDb;

namespace Net5Demo
{
    class Program
    {
        private static async Task Main(string[] args)
        {

            var options = new DbContextOptions<SalerDbContext>();

            await using var context = new SalerDbContext(options);
            await Write(context);
            await Read(context);

        }

        static async Task Read(SalerDbContext context)
        {
            //await context.SalerInfo.AsNoTracking().ToListAsync().ContinueWith(t => Console.WriteLine(t.Result.Count));
            //await context.SalerScore.AsNoTracking().ToListAsync().ContinueWith(t => Console.WriteLine(t.Result.Count));
            await context.SalerAddress.AsNoTracking().ToListAsync().ContinueWith(t => t.Result.ForEach(a=>Console.WriteLine(a.Address)));
        }

        static async Task Write(SalerDbContext context)
        {
            var r = await context.SalerInfo.AddAsync(new SalerInfo
            {
                UserName = "老周",
            });

            await context.SalerScore.AddAsync(new SalerScore
            {
                SalerId = r.Entity.Id,
                Score = 10
            });

            await context.SalerAddress.AddAsync(new SalerAddress
            {
                SalerId = r.Entity.Id,
                Address ="十里铺"
            });

            await context.SaveChangesAsync();
        }
    }
}
