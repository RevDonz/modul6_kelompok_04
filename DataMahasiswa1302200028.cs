using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Mod6
{
	public class DataMahasiswa1302200028
	{
		public void ReadJson()
		{
			string json = File.ReadAllText("D:\\repo_kpl\\modul6_kelompok_04\\tp6_1_1302200028.json");
			dynamic data = JsonConvert.DeserializeObject(json);
			Console.WriteLine("Nama: " + data.firstName);
			Console.WriteLine("Jenis Kelamin: " + data.gender);
			Console.WriteLine("Usia: " + data.age);
			Console.WriteLine("Alamat: " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
			Console.WriteLine("Mata Kuliah: ");
            foreach (var item in data.courses)
            {
				Console.WriteLine("\t- " + item.code + ": " + item.name);
            }
		}
	}
}
