using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SamaERP.Models;

namespace SamaERP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SamaERP.Models.ACCAdvancePayment> ACCAdvancePayment { get; set; }
        public DbSet<SamaERP.Models.ACCSupliers> ACCsupliers { get; set; }
        public DbSet<SamaERP.Models.ACCDepartments> Departments { get; set; }
        public DbSet<SamaERP.Models.ACCPurchases> ACCPurchases { get; set; }
        public DbSet<SamaERP.Models.ACCEmployeeDetails> ACCEmployeeDetails { get; set; }
        public DbSet<SamaERP.Models.ACCFixedAssets> ACCFixedAssets { get; set; }
        public DbSet<SamaERP.Models.ACCFixedCategory> ACCFixedCategory { get; set; }
        public DbSet<SamaERP.Models.Brand> Brand { get; set; }
        public DbSet<SamaERP.Models.Expense> Expense { get; set; }
        public DbSet<SamaERP.Models.ExpenseType> ExpenseType { get; set; }
        
    }
}
