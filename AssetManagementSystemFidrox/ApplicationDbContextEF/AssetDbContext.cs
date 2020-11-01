using AssetManagementSystemFidrox.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemFidrox.AssetDbContextEF
{
    public class AssetDbContext : IdentityDbContext<IdentityUser>
    {
        public AssetDbContext(DbContextOptions<AssetDbContext> options):base(options)
        {

        }
        public DbSet<AssetDetails> AssetDetails { get; set; }
        public DbSet<AssetIssueDetails> AssetIssueDetails { get; set; }
        public DbSet<GraphicsCardModel> GraphicsCardModels { get; set; }
        public DbSet<HardDiskModel> HardDiskModels { get; set; }
        public DbSet<OperatingSystemModel> OperatingSystemModels { get; set; }
        public DbSet<RamModel> RamModels { get; set; }
        public DbSet<ItemsBrand> ItemsBrands { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }





    }
}
