using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_04
{
    internal class GlossaryItem1302204051
    {
        public static void readJSON()
        {
            // Membaca File JSON
            String jsonString = File.ReadAllText("E://SEMESTER 4/Konstruksi Perangkat Lunak/Praktikum/Modul 6/modul6_kelompok_04/jurnal6_3_1302204051.json");

            // Convert JSON menjadi Array
            dynamic temp = JsonConvert.DeserializeObject(jsonString);
            dynamic data = temp.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("Menampilkan Data Glossary : ");
            Console.WriteLine("SortAs        : " + data.SortAs);
            Console.WriteLine("GlossTerm     : " + data.GlossTerm);
            Console.WriteLine("Acronym       : " + data.Acronym);
            Console.WriteLine("Abbrev        : " + data.Abbrev);
            Console.WriteLine("GlossSee      : " + data.GlossSee);
            Console.WriteLine("GlossDef      ");
            Console.WriteLine(" para         : " + data.GlossDef.para);
            Console.Write(" GlossSeeAlso : ");
            foreach (var item in data.GlossDef.GlossSeeAlso)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
