using Domain.Aggregates;
using System.ComponentModel.DataAnnotations;
using RapidFireLib.Lib.Core;
using System;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;


namespace Domain.Configuration.Payroll
{
    public class Bank : BaseModel
    {
        [Key]
        public int BankId { get; set; }

        public string BankCode { get; set; }
        [Required(ErrorMessage = "BankName is required")]

        public string BankName { get; set; }
        public int? CountryId { get; set; }
        public int? Status { get; set; }
        public List<Branch> Branch { get; set; } = new();
    }

    public class BankList : IModel
    {
        [Key]
        public int BankId { get; set; }

        public string BankCode { get; set; }
        public string BankName { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string Status { get; set; }
        public int SerialNo { get; set; }
        public long TotalRecord { get; set; }
        public List<Branch> Branch { get; set; } = new();
    }

    public class FilterModel : IModel
    {
        public string QuickFilter { get; set; }
        public DateTime? FromDate { get; set; } = DateTime.Now.AddMonths(-1);
        public DateTime? ToDate { get; set; } = DateTime.Now;

        // Stored procedure filters
        public string EmployeeId { get; set; }
        public string Name { get; set; }

        public int? OfficeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public int? GradeId { get; set; }

        public int? EmployeeTypeId { get; set; }
        public int? WorkingDays { get; set; }

        // Month/Year filter
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal? ExchangeRate { get; set; } = 0;

        public int FiscalYearId { get; set; }
        public string ReportFormat { get; set; } = "PDF";

    }
}
