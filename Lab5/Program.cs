using Lab5.BusinessLogic;
using Lab5.Serviсes;
using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        public static readonly SubdLab5DataBase db = new SubdLab5DataBase();
        static void Main(string[] args)
        {
            MainLogic logic = new MainLogic(new ClientService(), new MaterialService(), new OrderService(), new ServiceSrvices(), new SuppliersService());
            Insert(logic);
            Stopwatch clock = new Stopwatch();
            clock.Start();
            //logic.CreateClient("Test", "Tester", "Yliza", 32123);
            //logic.ReadClient();
            //logic.UpdateClient(6, "T", "Tr", "hg", 1);
            //logic.DeleteClient(6, "T", "Tr", "hg", 1);
            //logic.ClientService();
            //logic.ClientOrderMaterial();
            //logic.MaterialSupplier();
            logic.OrderClient();
            clock.Stop();
            Console.WriteLine(clock.ElapsedMilliseconds);

        }
        public static void Insert(MainLogic logic)
        {
            /*logic.CreateClient("Maxim","Kalyadin","Kievski 13", 12321);
            logic.CreateClient("Dmitry", "Lagin", "Karbsheva", 34542);
            logic.CreateClient("Ivan", "Ivanov", "Ylyanovski prospect", 675849);
            logic.CreateClient("Vadim", "Smirnov", "Sozidateley 48", 98778);
            logic.CreateClient("Anton", "Lyadov", "Tuleneva", 934577);
            
            logic.CreateService("ysluga 1", 450, 1);
            logic.CreateService("ysluga 2", 1000, 2);
            logic.CreateService("ysluga 3", 2000, 3);
            logic.CreateService("ysluga 4", 560, 4);
            logic.CreateService("ysluga 5", 321, 5);

            logic.CreateOrder("zakaz 1", "bulvar 2", DateTime.Parse("5.11.2019"), 1);
            logic.CreateOrder("zakaz 2", "bulvar 3", DateTime.Parse("21.11.2020"), 2);
            logic.CreateOrder("zakaz 3", "bulvar 4", DateTime.Parse("7.11.2020"), 3);
            logic.CreateOrder("zakaz 4", "bulvar 6", DateTime.Parse("3.11.2019"), 4);
            logic.CreateOrder("zakaz 5", "bulvar 22", DateTime.Parse("14.11.2018"), 5);

            logic.CreateSupplier("name organization 1", "prospect 1", 43215);
            logic.CreateSupplier("name organization 23", "prospect 2", 5682);
            logic.CreateSupplier("name organization 2", "prospect 3", 457346);
            logic.CreateSupplier("name organization 54", "prospect 4", 98002);
            logic.CreateSupplier("name organization 65", "prospect 5", 12440);

            logic.CreateMaterial("material 1", 4500, 1, 1);
            logic.CreateMaterial("material 2", 100, 2, 2);
            logic.CreateMaterial("material 3", 8000, 3, 3);
            logic.CreateMaterial("material 4", 5560, 4, 4);
            logic.CreateMaterial("material 5", 3277, 5, 5);*/


        }

    }
}
