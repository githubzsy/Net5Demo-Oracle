using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SalerDb
{
    [Table("SALER_SCORE")]
    public class SalerScore
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 主键序列
        /// </summary>
        public static string SEQ_SALER_SCORE_ID = "SEQ_SALER_SCORE_ID";

        public int SalerId { get; set; }

        public int Score { get; set; }
    }
}
