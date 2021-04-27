using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.EF.SalerDb
{
    [Table("SALER_ADDRESS")]
    public class SalerAddress
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 主键序列
        /// </summary>
        public static string SEQ_SALER_ADDRESS_ID = "SEQ_SALER_ADDRESS_ID";

        public string Address { get; set; }

        public int SalerId { get; set; }
    }
}
