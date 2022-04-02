using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_04
{
    internal class GlossaryItem1302204100
    {
        public static void ReadJSON()
        {
            // Membaca File JSON
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            String jsonString = File.ReadAllText(path + "\\jurnal6_3_1302204100.json");

            // Convert JSON menjadi Array
            dynamic temp = JsonConvert.DeserializeObject(jsonString);
            dynamic data = temp.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("Menampilkan Data Glossary : ");
            Console.WriteLine("SortAs        : " + data.SortAs);
            Console.WriteLine("GlossTerm     : " + data.GlossTerm);
            Console.WriteLine("Acronym       : " + data.Acronym);
            Console.WriteLine("Abbrev        : " + data.Abbrev);
            Console.WriteLine("GlossDef      ");
            Console.WriteLine(" para         : " + data.GlossDef.para);
            Console.Write(" GlossSeeAlso : ");
            foreach (var item in data.GlossDef.GlossSeeAlso)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("GlossSee      : " + data.GlossSee);
            Console.WriteLine();
        }
    }
}
