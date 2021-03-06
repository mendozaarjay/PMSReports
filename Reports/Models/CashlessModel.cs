﻿namespace Reports.Models
{
    public class CashlessModel
    {
        public int TransitId { get; set; }
        public string ORNo { get; set; }
        public string PaymentType { get; set; }
        public string PlateNo { get; set; }
        public string TicketNo { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string Duration { get; set; }
        public string RateName { get; set; }
        public string Coupon { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal Change { get; set; }
        public decimal Vatable { get; set; }
        public decimal Vat { get; set; }
        public decimal VatExempt { get; set; }
        public decimal ZeroRated { get; set; }
        public int Reprint { get; set; }
        public string Description { get; set; }
        public string UpdateUser { get; set; }
        public string Username { get; set; }
        public bool IsErased { get; set; }
        public string Entrance { get; set; }
        public string Exit { get; set; }
        public string SCPWDName { get; set; }
        public string SCPWDAddress { get; set; }
        public string SCPWDId { get; set; }
        public decimal LostCardPenalty { get; set; }
        public string LostCardName { get; set; }
        public string LostCardLicenseNo { get; set; }
        public string LostCardORCR { get; set; }
        public decimal OvernightPenalty { get; set; }
        public string CashlessType { get; set; }
        public string CashlessTransactionNo { get; set; }
    }
}
