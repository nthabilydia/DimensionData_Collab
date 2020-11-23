using System;
using System.Collections.Generic;

namespace Dimension_Data_Collab.Models
{
    public partial class Salary
    {
        public string SalaryId { get; set; }
        public decimal? HourlyRate { get; set; }
        public string OverTime { get; set; }
        public decimal? MonthlyIncome { get; set; }
    }
}
