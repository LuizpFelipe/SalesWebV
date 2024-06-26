﻿using SalesWebV.Models.ViewModels.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebV.Models.ViewModels
{
    public class SallesRecord
    {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = ("{0:dd/MM/yyyy}"))]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Amount { get; set; }
        public SallesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord()
        {
        }

        public SallesRecord(int id, DateTime date, double amount, SallesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.Status = status;
            Seller = seller;
        }
    }
}
