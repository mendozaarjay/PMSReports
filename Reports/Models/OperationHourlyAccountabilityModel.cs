namespace Reports.Models
{
    public class OperationHourlyAccountabilityModel
    {
        public int RowNum { get; set; }
        public string DurationHours { get; set; }
        public int NumberOfVehicles { get; set; }
        public decimal Amount { get; set; }
    }
}
