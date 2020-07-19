﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSalles(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSalles(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            /*var total = 0.0;
            foreach (SalesRecord s in Sales)
            {
                if (s.Date >= initial && s.Date <= final)
                {
                    total += s.Amount;
                }
            }
            return total;*/
            
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum((sr) => sr.Amount);
            
        }
        

    }
}
