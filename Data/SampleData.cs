using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public static class SampleData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                City.GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
                Province.GetProvinces()
            );
        }
    }
}
