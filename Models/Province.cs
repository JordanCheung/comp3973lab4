using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [Display(Name = "Province")]
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>
            {
                new Province()
                {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province()
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province()
                {
                    ProvinceCode = "MB",
                    ProvinceName = "Manitoba"
                },
                new Province()
                {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                },
                new Province()
                {
                    ProvinceCode = "QC",
                    ProvinceName = "Quebec"
                },
                new Province()
                {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatoon"
                }
            };
            return provinces;
        }
    }
}
