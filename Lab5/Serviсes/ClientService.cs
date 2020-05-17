using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5.Interface;
using Lab5.Models;

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
            var client = db.Clients.FirstOrDefault(c => c.Name == model.Name);
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
    }
}
