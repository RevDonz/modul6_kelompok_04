﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_04
{
    internal class TeamMembers1302204051
    {
        public void readJSON()
        {
            // Membaca File JSON
            String jsonString = File.ReadAllText("E://SEMESTER 4/Konstruksi Perangkat Lunak/Praktikum/Modul 6/modul6_kelompok_04/jurnal6_2_1302204051.json");

            // Convert JSON menjadi Array
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Anggota Kelompok : ");
            foreach (var item in data.members)
            {
                Console.WriteLine();
                Console.WriteLine("Nama depan    : " + item.firstName);
                Console.WriteLine("Nama belakang : " + item.lastName);
                Console.WriteLine("Gender        : " + item.gender);
                Console.WriteLine("Umur          : " + item.age);
                Console.WriteLine("NIM           : " + item.nim);
            }
        }
    }
}
