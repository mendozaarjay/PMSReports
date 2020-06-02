namespace Reports.Models
{
    public class CashierAccountabilityModel
    {
        public string Row { get; set; }
        public string RunDate { get; set; }
        public string RunTime { get; set; }
        public string Location { get; set; }
        public string Terminal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalChange { get; set; }
        public string CarParkIncome { get; set; }
        public int ReceiptsOut { get; set; }
        public decimal Amount { get; set; }
    }
}
