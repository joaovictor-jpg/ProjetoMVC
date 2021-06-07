﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using System.Globalization;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SelesRecord.Any())
            {
                return; // DB HAS BEEN SEEDED
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "João", "joaovictor@gmail.com", new DateTime(2000, 3, 16), 5000.0, d1);
            Seller s2 = new Seller(2, "Lucas", "Lucas@gmail.com", new DateTime(1997, 6, 12), 5000.0, d1);
            Seller s3 = new Seller(3, "Vitor", "Vitor@gmail.com", new DateTime(1997, 2, 19), 5000.0, d1);
            Seller s4 = new Seller(4, "Gabriel", "Gabriel@gmail.com", new DateTime(1996, 12, 30), 5000.0, d3);
            Seller s5 = new Seller(5, "Douglas", "Douglas@gmail.com", new DateTime(1996, 6, 20), 5000.0, d3);
            Seller s6 = new Seller(6, "David", "David@gmail.com", new DateTime(1998, 1, 23), 5000.0, d3);
            Seller s7 = new Seller(7, "Carol", "Carol@gmail.com", new DateTime(2000, 4, 4), 5000.0, d4);
            Seller s8 = new Seller(8, "Bianca", "Biaca@gmail.com", new DateTime(2001, 3, 31), 5000.0, d4);
            Seller s9 = new Seller(9, "Karla", "Karla@gmail.com", new DateTime(2000, 7, 16), 5000.0, d4);

            SelesRecord r1 = new SelesRecord(1, new DateTime(2021, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SelesRecord r2 = new SelesRecord(2, new DateTime(2021, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SelesRecord r3 = new SelesRecord(3, new DateTime(2021, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SelesRecord r4 = new SelesRecord(4, new DateTime(2021, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SelesRecord r5 = new SelesRecord(5, new DateTime(2021, 09, 21), 3000.0, SaleStatus.Billed, s9);
            SelesRecord r6 = new SelesRecord(6, new DateTime(2021, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SelesRecord r7 = new SelesRecord(7, new DateTime(2021, 09, 28), 13000.0, SaleStatus.Billed, s7);
            SelesRecord r8 = new SelesRecord(8, new DateTime(2021, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SelesRecord r9 = new SelesRecord(9, new DateTime(2021, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SelesRecord r10 = new SelesRecord(10, new DateTime(2021, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SelesRecord r11 = new SelesRecord(11, new DateTime(2021, 09, 13), 6000.0, SaleStatus.Billed, s7);
            SelesRecord r12 = new SelesRecord(12, new DateTime(2021, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SelesRecord r13 = new SelesRecord(13, new DateTime(2021, 09, 29), 10000.0, SaleStatus.Billed, s8);
            SelesRecord r14 = new SelesRecord(14, new DateTime(2021, 09, 4), 3000.0, SaleStatus.Billed, s9);
            SelesRecord r15 = new SelesRecord(15, new DateTime(2021, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SelesRecord r16 = new SelesRecord(16, new DateTime(2021, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SelesRecord r17 = new SelesRecord(17, new DateTime(2021, 10, 1), 12000.0, SaleStatus.Billed, s9);
            SelesRecord r18 = new SelesRecord(18, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, s8);
            SelesRecord r19 = new SelesRecord(19, new DateTime(2021, 10, 22), 8000.0, SaleStatus.Billed, s7);
            SelesRecord r20 = new SelesRecord(20, new DateTime(2021, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SelesRecord r21 = new SelesRecord(21, new DateTime(2021, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SelesRecord r22 = new SelesRecord(22, new DateTime(2021, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SelesRecord r23 = new SelesRecord(23, new DateTime(2021, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SelesRecord r24 = new SelesRecord(24, new DateTime(2021, 10, 12), 8000.0, SaleStatus.Billed, s8);
            SelesRecord r25 = new SelesRecord(25, new DateTime(2021, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SelesRecord r26 = new SelesRecord(26, new DateTime(2021, 10, 6), 5000.0, SaleStatus.Billed, s3);
            SelesRecord r27 = new SelesRecord(27, new DateTime(2021, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SelesRecord r28 = new SelesRecord(28, new DateTime(2021, 10, 7), 4000.0, SaleStatus.Billed, s9);
            SelesRecord r29 = new SelesRecord(29, new DateTime(2021, 10, 23), 12000.0, SaleStatus.Billed, s2);
            SelesRecord r30 = new SelesRecord(30, new DateTime(2021, 10, 12), 5000.0, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9);
            _context.SelesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19,
                r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.SaveChanges();
        }
    }
}
