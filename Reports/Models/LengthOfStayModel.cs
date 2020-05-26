using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Models
{
    public class LengthOfStayModel
    {
        public string RowNum            {get;set;}
        public string DurationHour      {get;set;}
        public int NumberOfVehicles  {get;set;}
        public decimal Amount { get; set; }
    }
}
