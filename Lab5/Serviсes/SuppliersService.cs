using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Models;

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
    }
}
