using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Mod6
{
	public class TeamMembers1302200028
	{
		public void ReadJson()
		{
			String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			string json = File.ReadAllText(path + "\\tp6_2_1302200028.json");
			dynamic data = JsonConvert.DeserializeObject(json);
			Console.WriteLine("Team member list: ");
            foreach (var item in data.members)
            {
				Console.WriteLine(item.nim + ": " + item.firstName + " " + item.lastName + "(" + item.age + " " + item.gender + ")");
            }
		}
	}
}
