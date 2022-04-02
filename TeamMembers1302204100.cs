using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_04
{
    internal class TeamMembers1302204100
    {
        public void ReadJSON()
        {
            // Membaca File JSON
            String jsonString = File.ReadAllText("D:/KULIAH SMT 4/KONTRUKSI PERANGKAT LUNAK/modul6_1302204100/jurnal6_2_1302204100.json");

            // Convert JSON menjadi Array
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("List Group Members : ");
            foreach (var item in data.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + "( " + item.age + " " + item.nim + " )");
            }
        }
    }
}

