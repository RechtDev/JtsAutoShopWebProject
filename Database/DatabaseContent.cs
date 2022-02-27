using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JtsAutoShopWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;


namespace JtsAutoShopWeb.Database
{
    public class DatabaseContent: IdentityDbContext
    {

        public DatabaseContent(DbContextOptions<DatabaseContent> options)
            : base(options)
        {


        }
        public virtual DbSet<CustomerModel> Products { get; set; }
        //public virtual DbSet<PersonModel> People { get; set; }
       // public virtual DbSet<StatusModel> Status { get; set; }
        public virtual DbSet<TechnicianModel> Technicians { get; set; }
        public virtual DbSet<TicketModel> Tickets { get; set; }
   
    }


    }

