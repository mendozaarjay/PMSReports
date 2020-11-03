namespace Reports.Models
{
    public class PeakLoadModel
    {
        public int Row { get; set; }
        public string Time { get; set; }
        public decimal GrossIn { get; set; }
        public decimal Cancel { get; set; }
        public decimal NetIn { get; set; }
        public decimal InPercentage { get; set; }
        public decimal NetOut { get; set; }
        public decimal OutPercentage { get; set; }
        public decimal Amount { get; set; }

    }
}
