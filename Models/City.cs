using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class City
    {
        [Display(Name = "ID")]
        public int CityId { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>()
            {
                new City()
                {
                    CityId = 1,
                    CityName = "Calgary",
                    ProvinceCode = "AB",
                    Population = 1392609
                },
                new City()
                {
                    CityId = 2,
                    CityName = "Edmonton",
                    ProvinceCode = "AB",
                    Population = 1321426
                },
                new City()
                {
                    CityId = 3,
                    CityName = "Lethbridge",
                    ProvinceCode = "AB",
                    Population = 117394
                },
                new City()
                {
                    CityId = 4,
                    CityName = "Kelowna",
                    ProvinceCode = "BC",
                    Population = 127380
                },
                new City()
                {
                    CityId = 5,
                    CityName = "Vancouver",
                    ProvinceCode = "BC",
                    Population = 2463431
                },
                new City()
                {
                    CityId = 6,
                    CityName = "Victoria",
                    ProvinceCode = "BC",
                    Population = 367770
                },
                new City()
                {
                    CityId = 7,
                    CityName = "Brandon",
                    ProvinceCode = "MB",
                    Population = 48859
                },
                new City()
                {
                    CityId = 8,
                    CityName = "Steinbach",
                    ProvinceCode = "MB",
                    Population = 15829
                },
                new City()
                {
                    CityId = 9,
                    CityName = "Winnipeg",
                    ProvinceCode = "MB",
                    Population = 778489
                },
                new City()
                {
                    CityId = 10,
                    CityName = "Ottawa",
                    ProvinceCode = "ON",
                    Population = 934243
                },
                new City()
                {
                    CityId = 11,
                    CityName = "Hamilton",
                    ProvinceCode = "ON",
                    Population = 747545
                },
                new City()
                {
                    CityId = 12,
                    CityName = "Toronto",
                    ProvinceCode = "ON",
                    Population = 5928040
                },
                new City()
                {
                    CityId = 13,
                    CityName = "Montreal",
                    ProvinceCode = "QC",
                    Population = 4098927
                },
                new City()
                {
                    CityId = 14,
                    CityName = "Quebec City",
                    ProvinceCode = "QC",
                    Population = 798162
                },
                new City()
                {
                    CityId = 15,
                    CityName = "Sherbrooke",
                    ProvinceCode = "QC",
                    Population = 212105
                },
                new City()
                {
                    CityId = 16,
                    CityName = "Prince Albert",
                    ProvinceCode = "SK",
                    Population = 32546
                },
                new City()
                {
                    CityId = 17,
                    CityName = "Regina",
                    ProvinceCode = "SK",
                    Population = 236481
                },
                new City()
                {
                    CityId = 18,
                    CityName = "Saskatoon",
                    ProvinceCode = "SK",
                    Population = 295095
                }
            };
            return cities;
        }
    }
}
