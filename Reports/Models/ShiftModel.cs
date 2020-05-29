namespace Reports.Models
{
    public class ShiftModel
    {
        public string SRNumber { get; set; }
        public string Type { get; set; }
        public string DateTimeIn { get; set; }
        public string DateTimeOut { get; set; }
        public int ExitCount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Vatable { get; set; }
        public decimal Vat { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal Change { get; set; }
        public decimal ChangeFund { get; set; }
        public decimal TenderDeclaration { get; set; }
        public decimal Variance { get; set; }
        public string Cashier { get; set; }
        public string Username { get; set; }

    }
}
