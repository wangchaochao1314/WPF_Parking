using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF.SmartParking.Server.Models
{
    [Table("sys_user_info")]
    public class SysUserInfo
    {
        [Key]
        [Column("_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        [Column("use_name")]
        public string UseName { get; set; }
        [Column("password")]
        public string  PassWord { get; set; }
    }
}
