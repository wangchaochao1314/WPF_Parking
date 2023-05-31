using Microsoft.EntityFrameworkCore;
using System;
using WPF.SmartParking.Server.Models;

namespace WPF停车场.Server.EFCore
{
    public class EFCoreContext:DbContext
    {


        private string strConn = "Server=localhost;Port=3306;Database=wpf_smartparking_database; User=root;Password=root;sslmode=none;";
   //     public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options) { }
        protected override void  OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //连接字符串
            dbContextOptionsBuilder.UseMySQL(strConn);

          //  base.OnConfiguring(dbContextOptionsBuilder);
        }



        public DbSet <SysUserInfo>  SysUserInfo { get; set; }
    }
}
