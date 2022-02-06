using JtsAutoShopWeb.BLL;
using JtsAutoShopWeb.Models;
using JtsAutoShopWeb.Models.ModelBuilders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //not actuall code example on how i want it to work with the controllers
            
            //var ticket = new TicketModelBuilder()
            //    .AddCreator(person1)
            //    .AddDropOffTime(new DateTime(2022, 1, 10))
            //    .AddTicketDescription("My car engine leaking fluid")
            //    .AddCarToBeServiced("1990 Toyota Tundra")
            //    .AssignTechnicain()
            //    .Build();
            //var ticketCreation = new TicketingCRUDRule("create");

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
