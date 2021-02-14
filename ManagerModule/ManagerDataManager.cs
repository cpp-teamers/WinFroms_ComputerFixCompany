using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Library1;
using System.Runtime.Serialization.Formatters.Binary;


namespace ManagerModule
{
    class ManagerDataManager
    {
        private string path_managers = @"..\..\..\Data\managers\";
        private string path_clients = @"..\..\..\..\Data\clients\";
        private string path_repairs = @"..\..\..\..\Data\repairmen\";
        private BinaryFormatter bf = new BinaryFormatter();
        private XmlSerializer xml = new XmlSerializer(typeof(RepairMan));

        public bool PasswordIsCorrect(string id, string password)
        {
            string path = path_managers + id + @"\" + "data.dat";
            Manager manager = null;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                manager = (Manager)bf.Deserialize(fs);
            }
            return (password == manager.AccountData.Password);
        }

    }
}
