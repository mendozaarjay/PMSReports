namespace Reports.Models
{
    public class CardEncodingModel
    {
        public string Id { get; set; }
        public string EntranceGate { get; set; }
        public string No { get; set; }
        public string TimeIn { get; set; }
        public string PlateNo { get; set; }
        public string TicketNumber { get; set; }
        public byte[] EntranceImage { get; set; }
    }
}
