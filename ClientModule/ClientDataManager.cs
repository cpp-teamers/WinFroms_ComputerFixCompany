using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Library1;
using System.Runtime.Serialization.Formatters.Binary;
using LibraryExceptions;

namespace ClientModule
{
    class ClientDataManager
    {
        private BinaryFormatter bf = new BinaryFormatter();
        public string ID { get; set; }
        public string Unique_Id()
        {
            Random random = new Random();

            string LoginId = Convert.ToString(random.Next(100000, 999999));

            string path = $@"..\..\..\Data\clients\{LoginId}";

            int counterRescuer = 0; // Для предотвращения замыкания цикла while
            while (Directory.Exists(path))
            {
                LoginId = Convert.ToString(random.Next(100000, 999999));
                path = $@"..\..\..\Data\clients\{LoginId}";
                // 
                counterRescuer++;
                if (counterRescuer == 999999)
                {
                    // Console.WriteLine("ADMIIIIIN"); // Notifier !!!!!!!!!!!!
                    break;
                }
            }
            return LoginId;
        }
        public void SaveClient(Client client)
        {
            string path = $@"..\..\..\Data\clients\{client.AccountData.Login}";
            DirectoryInfo directoryInfo = Directory.CreateDirectory(Convert.ToString(path));
            path += @"\data.dat";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, client);
            }
        }
        public Client LoadClient(string id)
        {
            Client client = new Client();

            if (FindDirectory(id) == true)
            {
                string path = $@"..\..\..\Data\clients\{id}\data.dat";
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    client = (Client)bf.Deserialize(fs);
                }
            }
            return client;
        }
        public bool FindDirectory(string id)
        {
            string path = $@"..\..\..\Data\clients\";
            bool access = false;
            DirectoryInfo d = new DirectoryInfo(path);
            DirectoryInfo[] clients = d.GetDirectories(); // Считал название всех файликов
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].Name == id)
                {
                    access = true;
                    break;
                }
            }
            return access;
        }
        public string Password(Client client)
        {
            return client.AccountData.Password;
        }
        public void ShowAllOrders(string id, List<Order> orders)
        {
            string path = $@"..\..\..\Data\clients\{id}\";
            Order order = new Order();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.dat");

            if (files.Length > 1)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Name != "data.dat")
                    {
                        path = $@"..\..\..\Data\clients\{id}\{files[i].Name}";
                        order = LoadOrder(path);
                        orders.Add(order);
                    }
                }
            }
        }
        public void SaveOrder(string id, Order order)
        {
            string path = $@"..\..\..\Data\clients\{id}\";
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.dat");

            int fileCounter = 1;
            string FileName = $"{fileCounter}.dat";
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name != "data.dat" && files[i].Name != FileName)
                {
                    break;
                }
                else
                {
                    fileCounter++;
                    FileName = $"{fileCounter}.dat";
                }
            }
            FileName = $"{fileCounter}.dat";
            // Окончательный путь файла
            path += $"{FileName}";
            // Запись заказа
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, order);
            }
            Console.WriteLine("               Order was successfully created! ");
        }
        public Order LoadOrder(string path)
        {
            Order order = new Order();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                order = (Order)bf.Deserialize(fs);
            }
            return order;
        }

    }
}
