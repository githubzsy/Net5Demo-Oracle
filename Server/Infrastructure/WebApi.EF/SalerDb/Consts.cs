using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.EF.SalerDb
{
    public static class Consts
    {
        internal static string ORACLE_CONNSTR = "User Id = saler; password=welcome;Data Source = localhost:1521/sale;";

        internal static string MYSQL_CONNSTR = "Server=localhost;Port=3306;Database=saler; User=root;Password=welcome;";
    }
}
