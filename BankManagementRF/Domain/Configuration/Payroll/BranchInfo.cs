using Domain.Aggregates;
using System.ComponentModel.DataAnnotations;
using RapidFireLib.Lib.Core;
using System;


namespace Domain.Configuration.Payroll
{
    public class Branch : BaseModel
    {
        [Key]
        public int BranchId { get; set; }
        public int BankId { get; set; }

        public string BranchName { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int Status { get; set; }
        //public Bank Bank { get; set; }

    }

    public class BranchList
    {
        [Key]
        public int SerialNo { get; set; }
        //[Key]
        public int BranchId { get; set; }
        public int BankId { get; set; }

        public string BranchName { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? Status { get; set; }
        public long TotalRecord { get; set; }

        //public Bank Bank { get; set; }

    }
}
