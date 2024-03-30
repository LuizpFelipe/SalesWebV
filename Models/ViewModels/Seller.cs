using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebV.Models.ViewModels
{
    public class Seller
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Sales {  get; set; } = new List<SallesRecord>();
        

        public Seller() {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            Department = department;
        }


        public void addSales(SallesRecord sr)
        {
            Sales.Add(sr);
        }

        public void removeSales(SallesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final ).Sum(sr => sr.Amount);
        }
    }
}
