namespace Reports.Models
{
    public class HourlyAccountabilityModel
    {
        public string TimeString { get; set; }
        public int TotalCard { get; set; }
        public int CardCounter { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountCounter { get; set; }
    }
}
