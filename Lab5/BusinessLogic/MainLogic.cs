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

        public void CreateMaterial(string Name, int Sum, int orderId, int supplierId)
        {
            Material material = new Material()
            {
                Name_Material = Name,
                Sum = Sum,
                OrderId = orderId,
                SupplierId = supplierId
            };
            materialService.Create(material);
        }

        public void CreateOrder(string Name, string Adress, DateTime date, int clientId)
        {
            Order order = new Order()
            {
                Name_Order = Name,
                Adress = Adress,
                Data_of_Complection = date,
                ClientId = clientId
            };
            orderService.Create(order);
        }

        public void CreateService(string Name, int Sum, int clientId)
        {
            Service service = new Service()
            {
                Name_Service = Name,
                Sum = Sum,
                ClientId = clientId
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


    }
}
