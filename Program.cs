// See https://aka.ms/new-console-template for more information
using System;

namespace Mod6
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa1302200028 mahasiswa = new DataMahasiswa1302200028();
            TeamMembers1302200028 team = new TeamMembers1302200028();
            mahasiswa.ReadJson();
            Console.WriteLine();
            team.ReadJson();
        }
    }

}