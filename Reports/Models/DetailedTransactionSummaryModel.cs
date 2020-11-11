namespace Reports.Models
{
    public class DetailedTransactionSummaryModel
    {
        public int TransitId { get; set; }
        public string Location { get; set; }
        public string ORNumber { get; set; }
        public string RateName { get; set; }
        public string EntranceDate { get; set; }
        public string EntranceTime { get; set; }
        public string ExitDate { get; set; }
        public string ExitTime { get; set; }
        public string TotalHours { get; set; }
        public string PlateNo { get; set; }
        public decimal Amount { get; set; }
        public string Duration { get; set; }
        public string CardNumber { get; set; }
        public string Cashier { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string Username { get; set; }
        public byte[] EntranceImage { get; set; }
        public byte[] ExitImage { get; set; }
        public string SCPWDName { get; set; }
        public string SCPWDAddress { get; set; }
        public string SCPWDId { get; set; }
        public decimal LostCardPenalty { get; set; }
        public string LostCardName { get; set; }
        public string LostCardLicenseNo { get; set; }
        public string LostCardORCR { get; set; }
        public decimal OvernightPenalty { get; set; }
        public string EntranceGate { get; set; }
        public string Terminal { get; set; }

    }
}
