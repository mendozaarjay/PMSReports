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
    }
}
