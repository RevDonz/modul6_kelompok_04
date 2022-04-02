
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_04;

internal class MainClass
{
    public static void Main(string[] args)
    {
        // Doni
        DataMahasiswa1302204051.readJSON();
        TeamMembers1302204051.readJSON();
        GlossaryItem1302204051.readJSON();
      
        // Naufal
        DataMahasiswa_1302200022 mhs1 = new DataMahasiswa_1302200022();
        mhs1.ReadJson();

        TeamMembers_1302200022 team1 = new TeamMembers_1302200022();
        team1.ReadJson();

        GlossaryItem_1302200022 glossaryItem1 = new GlossaryItem_1302200022();
        glossaryItem1.ReadJson();
        
        // Zahrandi
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
      
    }
  
    static DataMahasiswa_1302204080 ReadJSON1()
    {
        string jsonstring = File.ReadAllText("D:\\Project Koding Kuliah\\KPL\\jurnalmodul6\\modul6_kelompok_04\\jurnal6_1_1302204080.json");
        DataMahasiswa_1302204080 objHasilDeserialisasi = JsonSerializer.Deserialize<DataMahasiswa_1302204080>(jsonstring);
        return objHasilDeserialisasi;
    }
}
