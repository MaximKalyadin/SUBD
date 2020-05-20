using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Serviсes
{
    public class SuppliersService  : ILogic<Supplier>
    {
        private static SubdLab5DataBase db = Program.db;

        public void Create(Supplier model)
        {
            var supplier = db.Suppliers.FirstOrDefault(c => c.Name_Organization == model.Name_Organization);
            if (supplier != null)
            {
                throw new Exception("Такой поставщик уже есть");
            }
            db.Suppliers.Add(model);
            db.SaveChanges();
        }

        public void Delete(Supplier model)
        {
            var supplier = db.Suppliers.FirstOrDefault(c => c.Name_Organization == model.Name_Organization);
            if (supplier == null)
            {
                throw new Exception("Такого поставщика нет");
            }
            db.Suppliers.Remove(model);
            db.SaveChanges();
        }

        public void Update(Supplier model)
        {
            var supplier = db.Suppliers.FirstOrDefault(c => c.Name_Organization == model.Name_Organization);
            if (supplier == null)
            {
                throw new Exception("Такого поставщика нет");
            }
            supplier.Adress = model.Adress;
            supplier.Name_Organization = model.Name_Organization;
            supplier.Phone_Number = model.Phone_Number;
            db.SaveChanges();
        }

        public List<Supplier> Read()
        {
            return db.Suppliers.ToList();
        }

        public Supplier Get(int Id)
        {
            return db.Suppliers.FirstOrDefault(c => c.Id == Id);
        }

        public void Zapros_4()
        {
            var suppliers = db.Suppliers
                .Include(s => s.Material)
                .ToList()
                .OrderByDescending(s => s.Material.Sum(m => m.Sum))
                .GroupBy(s => s.Name_Organization)
                .Take(10)
                .Select(s => new
                {
                    NameOrg = s.Key,
                    sum = s.ToList().Sum(s => s.Material.Sum(m => m.Sum))
                }); 
            foreach (var c in suppliers)
            {
                Console.WriteLine(c.NameOrg + " " + c.sum);
            }

                            
        }
    }
}
