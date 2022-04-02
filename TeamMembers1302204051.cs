using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_04
{
    internal class TeamMembers1302204051
    {
        public static void readJSON()
        {
            // Membaca File JSON
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            String jsonString = File.ReadAllText(path + "\\jurnal6_2_1302204051.json");

            // Convert JSON menjadi Array
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Anggota Kelompok : ");
            foreach (var item in data.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + "( " + item.age + " " + item.nim + " )");
            }
            Console.WriteLine();
        }
    }
}
