using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_04
{
    internal class DataMahasiswa1302204100
    {
		public void ReadJSON()
		{
			// Membaca File JSON
			String jsonString = File.ReadAllText("D:/KULIAH SMT 4/KONTRUKSI PERANGKAT LUNAK/modul6_1302204100/jurnal6_1_1302204100.json");

			// Convert JSON menjadi Array
			dynamic data = JsonConvert.DeserializeObject(jsonString);

			//
			Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
			Console.WriteLine("Gender : " + data.gender);
			Console.WriteLine("Umur : " + data.age);
			Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
			Console.WriteLine("Mata Kuliah : ");
			foreach (var item in data.courses)
			{
				Console.WriteLine();
				Console.WriteLine("Kode matkul : " + item.code);
				Console.WriteLine("Nama matkul : " + item.name);
			}
			Console.WriteLine();
		}
    }
}
