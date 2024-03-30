using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SalesWebV.Models.ViewModels
{
    public class Department
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSallers(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double totalSellers(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.totalSales(initial, final));
        }
    }
}
