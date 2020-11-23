using System;
using System.Collections.Generic;

namespace Dimension_Data_Collab.Models
{
    public partial class Department
    {
        public string DepartmentId { get; set; }
        public string DepartmentType { get; set; }
        public string BusinessTravel { get; set; }
        public string JobRole { get; set; }
        public int? JobLevel { get; set; }
        public int? JobInvolve { get; set; }
    }
}
