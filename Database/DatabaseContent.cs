using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JtsAutoShopWeb.Models;
using JtsAutoShopWeb.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace JtsAutoShopWeb.Database
{
   

    public class DatabaseContent : IdentityDbContext<Users>
    {

        public DatabaseContent(DbContextOptions<DatabaseContent> options)
            : base(options)
        {


        }
        public virtual DbSet<CustomerModel> Products { get; set; }
        public virtual DbSet<PersonModel> People { get; set; }
        public virtual DbSet<StatusModel> Status { get; set; }
        public virtual DbSet<TechnicianModel> Technicians { get; set; }
        public virtual DbSet<TicketModel> Tickets { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
      
        //    modelBuilder.Entity<TicketModel>().HasData(
        //        new TicketModel
        //        {
        //            TicketId = 10,
        //            Car = "Honda Civic",
        //            ProblemDescription = "Bad Battery",
        //        }
        //            );
        //}

    }
}

