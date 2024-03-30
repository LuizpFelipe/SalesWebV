using SalesWebV.Models.ViewModels.Enums;
using System;

namespace SalesWebV.Models.ViewModels
{
    public class SallesRecord
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SallesStatus status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord()
        {
        }

        public SallesRecord(int id, DateTime date, double amount, SallesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
