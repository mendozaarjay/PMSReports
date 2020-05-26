﻿namespace Reports.Models
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
    }
}
