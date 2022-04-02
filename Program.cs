
using System;
using System.Text.Json;
using System.IO;



namespace modul6_kelompok_04
{
    public class program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa_1302204080 objhasilbaca = ReadJSON1();
            Console.WriteLine(objhasilbaca.firstName);
            Console.WriteLine(objhasilbaca.lastName);
            Console.WriteLine(objhasilbaca.age);
            Console.WriteLine(objhasilbaca.gender);
            Console.WriteLine(objhasilbaca.address.city);
            Console.WriteLine(objhasilbaca.address.streetAddress);
            Console.WriteLine(objhasilbaca.address.state);
            Console.WriteLine(objhasilbaca.courses[0].name);
            Console.WriteLine(objhasilbaca.courses[0].code);
            Console.WriteLine(objhasilbaca.courses[1].name);
            Console.WriteLine(objhasilbaca.courses[1].code);

            TeamMembers_1302204080 objhasilread = ReadJSON2();
        }

        static DataMahasiswa_1302204080 ReadJSON1()
        {
            string jsonstring = File.ReadAllText("D:\\Project Koding Kuliah\\KPL\\jurnalmodul6\\modul6_kelompok_04\\jurnal6_1_1302204080.json");
            DataMahasiswa_1302204080 objHasilDeserialisasi = JsonSerializer.Deserialize<DataMahasiswa_1302204080>(jsonstring);
            return objHasilDeserialisasi;
        }

        static TeamMembers_1302204080 ReadJSON2()
        {
            string jsonstring = File.ReadAllText("D:\\Project Koding Kuliah\\KPL\\jurnalmodul6\\modul6_kelompok_04\\jurnal6_2_1302204080.json");
            TeamMembers_1302204080 objHasilDeserialisasi2 = JsonSerializer.Deserialize<TeamMembers_1302204080>(jsonstring);
            return objHasilDeserialisasi2;
        }

    }
}