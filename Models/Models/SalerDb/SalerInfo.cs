using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.SalerDb
{
    [Table("SALER_INFO")]
    public class SalerInfo
    {
        public string UserName { get; set; }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 主键序列
        /// </summary>
        public static string SEQ_SALERINFO_ID = "SEQ_SALERINFO_ID";

        public int AccountId { get; set; }
    }
}
