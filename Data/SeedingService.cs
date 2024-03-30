using Microsoft.EntityFrameworkCore.Internal;
using SalesWebV.Models.ViewModels;
using SalesWebV.Models.ViewModels.Enums;
using System;

namespace SalesWebV.Data
{
    public class SeedingService
    {
        private SalesWebVContext _context;


        public SeedingService(SalesWebVContext context) 
        {
            _context = context;
        }

        public void Seed()
        {
            if( _context.Department.Any() || _context.Seller.Any() || _context.SallesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Eletronicos");
            Department d2 = new Department(2, "Eletrodomesticos");
            Department d3 = new Department(3, "Mercado");
            Department d4 = new Department(4, "Serviços");

            Seller seller1 = new Seller(1,"Ricardo Barros", "ricardinho18@gmail.com", new DateTime(1992,3,21),2000,d1);
            Seller seller2 = new Seller(2,"Maria Antonieta", "mariaBananinha@gmail.com", new DateTime(1999,12,21),3000,d1);

            Seller seller3 = new Seller(3,"Leonardo Bichira", "afogado@gmail.com", new DateTime(1993,1,2),4999,d2);
            Seller seller4 = new Seller(4,"Pedro Miranha", "miranhaDaGalera@gmail.com", new DateTime(1982,5,1),6900,d2);

            Seller seller5 = new Seller(5, "Maria Eduarda", "Leitecompera@gmail.com", new DateTime(2006, 8, 25), 8000, d3);
            Seller seller6 = new Seller(6, "Vanuza Pimentel", "carretaFuracao@gmail.com", new DateTime(1997, 2, 5), 2900, d3);

            Seller seller7 = new Seller(7, "Gene Viveoumorre", "sera@gmail.com", new DateTime(1998, 4, 12), 2500, d4);
            Seller seller8 = new Seller(8, "Soldado Pimentel", "Tamnhodobilau@gmail.com", new DateTime(1995, 7, 2), 3100, d4);

            SallesRecord record1 = new SallesRecord(1, new DateTime(2023,02,23), 10000, SallesStatus.Billed,seller2);
            SallesRecord record2 = new SallesRecord(2, new DateTime(2023,02,22), 23333, SallesStatus.Billed,seller3);
            SallesRecord record3 = new SallesRecord(3, new DateTime(2023,02,24), 12222, SallesStatus.Billed,seller1);
            SallesRecord record4 = new SallesRecord(4, new DateTime(2023,02,25), 1777, SallesStatus.Billed,seller6);
            SallesRecord record5 = new SallesRecord(5, new DateTime(2023,02,25), 2000, SallesStatus.Billed,seller8);
            SallesRecord record6 = new SallesRecord(6, new DateTime(2023,02,26), 3000, SallesStatus.Billed,seller4);
            SallesRecord record7 = new SallesRecord(7, new DateTime(2023,02,27), 57000, SallesStatus.Billed,seller7);
            SallesRecord record8 = new SallesRecord(8, new DateTime(2023,02,22), 1000, SallesStatus.Billed,seller5);
            SallesRecord record9 = new SallesRecord(9, new DateTime(2023,02,21), 600, SallesStatus.Billed,seller3);
            SallesRecord record10 = new SallesRecord(10, new DateTime(2023,02,21), 6200, SallesStatus.Billed,seller3);
            SallesRecord record11 = new SallesRecord(11, new DateTime(2023,02,21), 6400, SallesStatus.Billed,seller3);
            SallesRecord record12 = new SallesRecord(12, new DateTime(2023,02,22), 12300, SallesStatus.Billed,seller5);
            SallesRecord record13 = new SallesRecord(13, new DateTime(2023,02,24), 12200, SallesStatus.Billed,seller6);
            SallesRecord record14 = new SallesRecord(14, new DateTime(2023,02,26), 1200, SallesStatus.Billed,seller5);
            SallesRecord record15 = new SallesRecord(15, new DateTime(2023,02,24), 14200, SallesStatus.Billed,seller4);
            SallesRecord record16 = new SallesRecord(16, new DateTime(2023,02,24), 15200, SallesStatus.Billed,seller2);
            SallesRecord record17 = new SallesRecord(17, new DateTime(2023,02,28), 19200, SallesStatus.Billed,seller7);
            SallesRecord record18 = new SallesRecord(18, new DateTime(2023,02,22), 17200, SallesStatus.Billed,seller8);
            SallesRecord record19 = new SallesRecord(19, new DateTime(2023,02,23), 10, SallesStatus.Billed,seller5);
            SallesRecord record20 = new SallesRecord(20, new DateTime(2023,02,26), 6200, SallesStatus.Billed,seller4);
            SallesRecord record21 = new SallesRecord(21, new DateTime(2023,02,27), 5200, SallesStatus.Billed,seller4);
            SallesRecord record22 = new SallesRecord(22, new DateTime(2023,02,23), 3200, SallesStatus.Billed,seller3);
            SallesRecord record23 = new SallesRecord(23, new DateTime(2023,02,25), 8200, SallesStatus.Billed,seller1);
            SallesRecord record24 = new SallesRecord(24, new DateTime(2023,02,21), 2200, SallesStatus.Billed,seller1);
            SallesRecord record25 = new SallesRecord(25, new DateTime(2023,02,20), 5400, SallesStatus.Billed,seller3);
            SallesRecord record26 = new SallesRecord(26, new DateTime(2023,02,24), 76500, SallesStatus.Billed,seller6);
            SallesRecord record27 = new SallesRecord(27, new DateTime(2023,02,27), 5670, SallesStatus.Billed,seller5);
            SallesRecord record28 = new SallesRecord(28, new DateTime(2023,02,28), 76440, SallesStatus.Billed,seller7);
            SallesRecord record29 = new SallesRecord(29, new DateTime(2023,02,27), 56574, SallesStatus.Billed,seller3);
            SallesRecord record30 = new SallesRecord(30, new DateTime(2023,02,26), 5656, SallesStatus.Billed,seller5);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6, seller7, seller8);
            _context.SallesRecord.AddRange(record1, record2, record3, record4, record5, record6, record7, record8, record9
                , record10, record11, record12, record13, record14, record15, record16, record17, record18, record19, record20, record21
                , record22, record23, record24, record25, record26, record27, record28, record29, record30);

            _context.SaveChanges();
        }
    }
}
