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
    }
}