using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Models;

namespace Lab5.Serviсes
{
    public class ServiceSrvices : ILogic<Service>
    {
        private static SubdLab5DataBase db = Program.db;

        public void Create(Service model)
        {
            var service = db.Services.FirstOrDefault(c => c.Name_Service == model.Name_Service);
            if (service != null)
            {
                throw new Exception("Такой сервис уже есть");
            }
            db.Services.Add(model);
            db.SaveChanges();
        }

        public void Delete(Service model)
        {
            var service = db.Services.FirstOrDefault(c => c.Name_Service == model.Name_Service);
            if (service == null)
            {
                throw new Exception("Такоого сервиса нет");
            }
            db.Services.Remove(model);
            db.SaveChanges();
        }

        public void Update(Service model)
        {
            var service = db.Services.FirstOrDefault(c => c.Name_Service == model.Name_Service);
            if (service == null)
            {
                throw new Exception("Такоого сервиса нет");
            }
            service.Name_Service = model.Name_Service;
            service.Sum = model.Sum;
            db.SaveChanges();
        }

        public List<Service> Read()
        {
            return db.Services.ToList();
        }

        public Service Get(int Id)
        {
            return db.Services.FirstOrDefault(c => c.Id == Id);
        }
    }
}
