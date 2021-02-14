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

        public List<Order> curr_order;


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

    }
}
