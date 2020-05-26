namespace Reports.Models
{
    public class BIRModel
    {
        public string Date { get; set; }
        public string BeginningOR { get; set; }
        public string EndingOR { get; set; }
        public decimal BeginningSales { get; set; }
        public decimal EndingSales { get; set; }
        public decimal TotalSales { get; set; }
        public decimal DiscountSC { get; set; }
        public decimal DiscountPWD { get; set; }
        public decimal DiscountOthers { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Vatable { get; set; }
        public decimal Vat { get; set; }
        public decimal VatExempt { get; set; }
        public decimal ZeroRated { get; set; }
        public string ResetCount { get; set; }
        public string ZCounter { get; set; }
        public string Remarks { get; set; }
    }
}
