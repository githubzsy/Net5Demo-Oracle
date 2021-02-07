using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApi.EF;

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
            var saler_accounts = await context.SalerAccount.AsNoTracking().ToListAsync();
            saler_accounts.ForEach(account => Console.WriteLine(account.Account));
        }

        static async Task Write(SalerDbContext context)
        {
            await context.SalerAccount.AddAsync(new Saler.Core.Entities.SalerAccount
            {
                Account = "老周",
                Id = -1
            });
            await context.SaveChangesAsync();
        }
    }
}
