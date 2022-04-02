using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Mod6
{
	public class TeamMembers1302200028
	{
		public void ReadJson()
		{
			string json = File.ReadAllText("D:\\repo_kpl\\modul6_kelompok_04\\tp6_2_1302200028.json");
			dynamic data = JsonConvert.DeserializeObject(json);
			Console.WriteLine("Team member list: ");
            foreach (var item in data.members)
            {
				Console.WriteLine(item.nim + ": " + item.firstName + " " + item.lastName + "(" + item.age + " " + item.gender + ")");
            }
		}
	}
}
