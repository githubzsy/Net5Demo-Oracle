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
            var saler_accounts = await context.SalerInfo.AsNoTracking().ToListAsync();
            saler_accounts.ForEach(account => Console.WriteLine(account.UserName));
        }

        static async Task Write(SalerDbContext context)
        {
            await context.SalerInfo.AddAsync(new SalerInfo
            {
                UserName = "老周",
                Id = -1,
                AccountId =-1
            });
            await context.SaveChangesAsync();
        }
    }
}
