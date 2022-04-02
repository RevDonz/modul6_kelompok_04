
using System;
using System.Text.Json;
using System.IO;


namespace Jurnal6
{
    public class program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa_1302204080 objhasilbaca = ReadJSON();
            Console.WriteLine(objhasilbaca.firstName);
        }

        static DataMahasiswa_1302204080 ReadJSON()
        {
            string jsonstring = File.ReadAllText("D:\\Project Koding Kuliah\\KPL\\jurnalmodul6\\modul6_kelompok_04\\tp6_1_1302204080.json");
            DataMahasiswa_1302204080 objHasilDeserialisasi = JsonSerializer.Deserialize<DataMahasiswa_1302204080>(jsonstring);
            return objHasilDeserialisasi;
        }

    }
}