﻿namespace TravelReservation.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int id { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public float price { get; set; }
        public int capacity { get; set; }
    }
}
