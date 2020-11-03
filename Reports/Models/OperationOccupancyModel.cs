namespace Reports.Models
{
    public class OperationOccupancyModel
    {
        public int RowNum { get; set; }
        public string Time { get; set; }
        public int In { get; set; }
        public int Out { get; set; }
        public int Remaining { get; set; }
    }
}
