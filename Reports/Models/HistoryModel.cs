namespace Reports.Models
{
    public class HistoryModel
    {
        public int Id { get; set; }
        public string Terminal { get; set; }
        public string ORNumber { get; set; }
        public string Type { get; set; }
        public string PlateNo { get; set; }
        public string TicketNumber { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string Duration { get; set; }
        public string RateName { get; set; }
        public string Coupon { get; set; }
        public string MonthlyRFID { get; set; }
        public string MonthlyName { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateId { get; set; }
        public byte[] EntranceImage { get; set; }
        public byte[] ExitImage { get; set; }
        public string EntranceGate { get; set; }
        public string SCPWDName { get; set; }
        public string SCPWDAddress { get; set; }
        public string SCPWDId { get; set; }
        public decimal LostCardPenalty { get; set; }
        public string LostCardName { get; set; }
        public string LostCardLicenseNo { get; set; }
        public string LostCardORCR { get; set; }
        public decimal OvernightPenalty { get; set; }

    }
}
