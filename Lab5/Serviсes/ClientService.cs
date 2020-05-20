using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Serviсes
{
    public class ClientService : ILogic<Client>
    {
        private static SubdLab5DataBase db = Program.db;

        public void Create(Client model)
        {
            var client = db.Clients.FirstOrDefault(c => c.Name == model.Name);
            if (client != null)
            {
                throw new Exception("Такой клиент уже есть");
            }
            db.Clients.Add(model);
            db.SaveChanges();
        }

        public void Delete(Client model)
        {
            var client = db.Clients.FirstOrDefault(c => c.Name == model.Name);
            if (client == null)
            {
                throw new Exception("Такого клиента нет");
            }
            db.Clients.Remove(model);
            db.SaveChanges();
        }

        public void Update(Client model)
        {
            var client = db.Clients.FirstOrDefault(c => c.Id == model.Id);
            if (client == null)
            {
                throw new Exception("Такого клиента нет");
            }
            client.Adress = model.Adress;
            client.Name = model.Name;
            client.Phone_Numper = model.Phone_Numper;
            client.Surname = model.Surname;
            db.SaveChanges();
        }

        public List<Client> Read()
        {
            return db.Clients.ToList();
        }

        public Client Get(int Id)
        {
            return db.Clients.FirstOrDefault(c => c.Id == Id);
        }

        public void OrderClientName()
        {
            var client = db.Clients.OrderBy(c => c.Surname);
            foreach (Client c in client)
            {
                Console.Write(c.Surname + " " + c.Name + " " + c.Adress + " " + c.Phone_Numper);
            }
        }

        public void Zapros_2()
        {
            var client = from p in db.Services
                         join c in db.Clients on p.ClientId equals c.Id
                         select new { c.Surname, c.Name, c.Adress, p.Name_Service };
            foreach (var c in client)
            {
                Console.WriteLine(c.Surname + " " + c.Name + " " + c.Adress + " " + c.Name_Service);
            }
        }

        public void zap_2()
        {
            var client = db.Services
                .Join(db.Clients,
                c => c.ClientId,
                s => s.Id,
                (c,s) => new
                {
                    s.Surname,
                    s.Name,
                    s.Adress,
                    c.Name_Service
                });
            foreach (var c in client)
            {
                Console.WriteLine(c.Surname + " " + c.Name + " " + c.Adress + " " + c.Name_Service);
            }
        }
        public void Zapros_3()
        {
            var client = from p in db.Materials
                         join c in db.Orders on p.OrderId equals c.Id
                         join r in db.Clients on c.ClientId equals r.Id
                         select new { r.Surname, r.Name, c.Adress, p.Name_Material, p.Sum };
            foreach (var c in client)
            {
                Console.WriteLine(c.Surname + " " + c.Name + " " + c.Adress + " " + c.Name_Material + " " + c.Sum);
            }
        }
    }
}
