using System;
using System.Collections.Generic;
using System.Text;
using Lab5.Models;
using Lab5.Serviсes;

namespace Lab5.BusinessLogic
{
    public class MainLogic
    {
        private readonly ClientService clientService;
        private readonly MaterialService materialService;
        private readonly OrderService orderService;
        private readonly ServiceSrvices serviceSrvices;
        private readonly SuppliersService suppliersService;

        public MainLogic(ClientService clientService, MaterialService materialService, OrderService orderService, ServiceSrvices serviceSrvices, SuppliersService suppliersService)
        {
            this.suppliersService = suppliersService;
            this.serviceSrvices = serviceSrvices;
            this.orderService = orderService;
            this.materialService = materialService;
            this.clientService = clientService;
        }

        public void CreateClient(string Name, string Surname, string Adress, int Phone)
        {
            Client client = new Client()
            {
                Name = Name,
                Surname = Surname,
                Adress = Adress,
                Phone_Numper = Phone
            };
            clientService.Create(client);
        }

        public void CreateMaterial(string Name, int Sum, int OrderId, int SupplierId)
        {
            Material material = new Material()
            {
                Name_Material = Name,
                Sum = Sum,
                OrderId = OrderId,
                SupplierId = SupplierId
            };
            materialService.Create(material);
        }

        public void CreateOrder(string Name, string Adress, DateTime date, int ClientId)
        {
            Order order = new Order()
            {
                Name_Order = Name,
                Adress = Adress,
                Data_of_Complection = date,
                ClientId = ClientId
            };
            orderService.Create(order);
        }

        public void CreateService(string Name, int Sum, int ClientId)
        {
            Service service = new Service()
            {
                Name_Service = Name,
                Sum = Sum,
                ClientId = ClientId
            };
            serviceSrvices.Create(service);
        }

        public void CreateSupplier(string Name, string Adress, int Phone)
        {
            Supplier supplier = new Supplier()
            {
                Name_Organization = Name,
                Adress = Adress,
                Phone_Number = Phone
            };
            suppliersService.Create(supplier);
        }

        public void ReadClient()
        {
            var list = clientService.Read();
            foreach (var p in list)
            {
                Console.Write(p.Id + " " + p.Name + " " + p.Surname);
                Console.WriteLine();
            }
        }

        public void OrderClient()
        {
            clientService.OrderClientName();
        }

        public void ClientService()
        {
            clientService.Zapros_2();
        }

        public void ClientOrderMaterial()
        {
            clientService.Zapros_3();
        }

        public void h()
        {
            suppliersService.Zapros_4();
        }
    }
}
