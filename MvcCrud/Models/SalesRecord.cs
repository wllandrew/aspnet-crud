﻿using MvcCrud.Models.Enums;

namespace MvcCrud.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
        }
    }
}
