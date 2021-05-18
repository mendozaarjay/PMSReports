namespace Reports.Models
{
    public class AuditTrailModel
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Gate { get; set; }
        public string Username { get; set; }
        public string Date { get; set; }
    }
}
