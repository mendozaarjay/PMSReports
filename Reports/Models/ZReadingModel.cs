namespace Reports.Models
{
    public class ZReadingModel
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string NewORNo { get; set; }
        public string OldORNo { get; set; }
        public string NewFRNo { get; set; }
        public string OldFRNo { get; set; }
        public decimal TodaySales { get; set; }
        public decimal NewSales { get; set; }
        public decimal OldSales { get; set; }
    }
}
