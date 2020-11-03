using System;

namespace Reports.Models
{
    public class CardClearingModel
    {
        public string Id { get; set; }
        public string Row { get; set; }
        public string EntranceGate { get; set; }
        public string PlateNo { get; set; }
        public string TicketNo { get; set; }
        public string DateTimein { get; set; }
        public string Comment { get; set; }
        public string ClearedUser { get; set; }

    }
}
