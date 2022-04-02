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
        DataMahasiswa1302204100 mhs1 = new DataMahasiswa1302204100();
        mhs1.ReadJSON();
        TeamMembers1302204100 mhs2 = new TeamMembers1302204100();
        mhs2.ReadJSON();

    }
}