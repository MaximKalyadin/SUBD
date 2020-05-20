using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Lab5.Interface;
using Lab5.Models;

namespace Lab5.Serviсes
{
    public class OrderService : ILogic<Order>
    {
        private static SubdLab5DataBase db = Program.db;

        public void Create(Order model)
        {
            var order = db.Orders.FirstOrDefault(c => c.Name_Order == model.Name_Order);
            if (order != null)
            {
                throw new Exception("Такой заказ уже есть");
            }
            db.Orders.Add(model);
            db.SaveChanges();
        }

        public void Update(Order model)
        {
            var order = db.Orders.FirstOrDefault(c => c.Id == model.Id);
            if (order == null)
            {
                throw new Exception("Такого заказа нет");
            }
            order.Adress = model.Adress;
            order.Data_of_Complection = model.Data_of_Complection;
            order.Name_Order = model.Name_Order;
            db.SaveChanges();
        }

        public void Delete(Order model)
        {
            var order = db.Orders.FirstOrDefault(c => c.Name_Order == model.Name_Order);
            if (order == null)
            {
                throw new Exception("Такого заказа нет");
            }
            db.Orders.Remove(order);
            db.SaveChanges();
        }

        public List<Order> Read()
        {
            return db.Orders.ToList();
        }

        public Order Get(int Id)
        {
            return db.Orders.FirstOrDefault(c => c.Id == Id);
        }
    }
}
