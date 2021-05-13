using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.SalerDb
{
    /// <summary>
    /// 销售员信息
    /// </summary>
    [Table("SALER_INFO")]
    public class SalerInfo
    {
        /// <summary>
        /// 销售员名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 主键序列
        /// </summary>
        public static string SEQ_SALERINFO_ID = "SEQ_SALERINFO_ID";

        /// <summary>
        /// 账户Id
        /// </summary>
        public int AccountId { get; set; }
    }
}
