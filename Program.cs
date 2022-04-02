
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
        DataMahasiswa1302204051.readJSON();
        TeamMembers1302204051.readJSON();
        GlossaryItem1302204051.readJSON();
      
        DataMahasiswa_1302200022 mhs1 = new DataMahasiswa_1302200022();
        mhs1.ReadJson();

        TeamMembers_1302200022 team1 = new TeamMembers_1302200022();
        team1.ReadJson();

        GlossaryItem_1302200022 glossaryItem1 = new GlossaryItem_1302200022();
        glossaryItem1.ReadJson();
    }
}
