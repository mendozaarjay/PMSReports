namespace Reports.Models
{
    public class RegularParkerModel
    {
        public string Id { get; set; }
        public string RFID { get; set; }
        public string Parker { get; set; }
        public string Company { get; set; }
        public string DateIssued { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public string Status { get; set; }
    }
}
