using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library1;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Linq;
using LibraryExceptions;

namespace RepairManModule.Helpers
{
    public class RepairManDataManager
    {
		public RepairMan rm;

        string _path = @"..\..\..\Data\repairmen\";
        XmlSerializer _serializer;
		BinaryFormatter _bf;

        List<Order> curr_order;


        public RepairManDataManager()
        {
            _serializer = new XmlSerializer(typeof(RepairMan));
            _bf = new BinaryFormatter();
        }

        public void LoadDataOfRepM(string name)
        {
            _path += $@"{name}\{name}.xml";

            using (FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                rm = (RepairMan)_serializer.Deserialize(fs);
            }
        }

        public List<Order> LoadTasks()
        {
            curr_order = new List<Order>();

            foreach (var path in rm.PathsOfOrders)
            {

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    curr_order.Add((Order)_bf.Deserialize(fs));
                }
            }

            return curr_order;
        }

        public void SaveTasks()
        {
            //path += @"\vasyan.xml";
            int j = 0;

            foreach (string p in rm.PathsOfOrders)
            {

                using (FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Write))
                {
                    _bf.Serialize(fs, curr_order[j]);
                }
                j++;
            }
        }


        public bool LogIn()
        {
            int chancesToEnterPassword = 3;

            Console.Write("\n>Enter your name: ");
            string name = Console.ReadLine();
            name = name.ToLower();

            bool succeed_entry = false;


            if (IsValid(name))
            {

                do
                {
                    if (EnterPassword(name))
                    {
                        succeed_entry = true;
                        break;
                    }
                    else
                    {
                        chancesToEnterPassword--;
                        Console.Write($"\nSorry! Password is incorrect! You got {chancesToEnterPassword} chances\n\n");
                    }
                }
                while (chancesToEnterPassword != 0);


            }
            else
            {
                Console.Write($"Sorry! There is no such person.");
            }

            return succeed_entry;
        }
        public bool IsValid(string enteredName)
        {

            DirectoryInfo di = new DirectoryInfo(_path + enteredName);

			if (!di.Exists)
			{
                throw new Exception("Employee with this name doesn't exists");
			}

            return true;
        }

        public bool CheckPassword(string validName, string enteredPass)
		{
            XDocument doc = XDocument.Load(_path + validName + $@"\{validName}.xml");
            
            XElement rep = doc.Element("RepairMan");

            var real_pasw = rep.Element("AccountData").Element("Password").Value;

            if (real_pasw != enteredPass)
			{
                throw new PasswordException("Password is incorrect", enteredPass);
			}

            return true;
		}

        private bool EnterPassword(string nameInDir)
        {
            bool success = false;

            Console.Write("\n>Password: ");
            string enteredPassword = Console.ReadLine();

            LoadDataOfRepM(nameInDir);

            if (enteredPassword == rm.AccountData.Password)
            {
                success = true;
            }

            return success;
        }

        public void DisplayCurrentTasks()
        {

            LoadTasks();

            foreach (var item in curr_order)
            {
                Console.WriteLine(item);
            }
        }

        public void MarkTaskReady()
        {
            try
            {


                Console.Write("\n> What task you would like to mark as ready: ");
                Int32.TryParse(Console.ReadLine(), out int choice);
                //LoadTasks();

                curr_order[choice - 1].Actual = false;

                SaveTasks();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry there is no such position");
            }
        }
        public void MarkInProgress()
        {

            try
            {


                Console.Write("\n> What task you would like to mark as ready: ");
                Int32.TryParse(Console.ReadLine(), out int choice);
                //LoadTasks();

                curr_order[choice - 1].Actual = true;

                SaveTasks();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry there is no such position");
            }
        }
    }
}
