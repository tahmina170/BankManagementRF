using Domain.Aggregates;
using System.ComponentModel.DataAnnotations;
using RapidFireLib.Lib.Core;
using System;

namespace Domain.Configuration.Employment
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityAddress { get; set; }
        public int? Status { get; set; }

    }
}
