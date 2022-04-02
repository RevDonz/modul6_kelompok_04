using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_04
{
    internal class GlossaryItem_1302200022
    {
        public void ReadJson()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // Membaca File JSON
            string jsonString = File.ReadAllText(path + "\\jurnal6_3_1302200022.json");

            // Convert JSON menjadi Array
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            //
            Console.WriteLine(data);
        }
    }
}
