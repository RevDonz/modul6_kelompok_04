using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Mod6
{
	public class GlossaryItem1302200028
	{
		public void ReadJson()
		{
			String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			string json = File.ReadAllText(path + "\\tp6_3_1302200028.json");
			dynamic data = JsonConvert.DeserializeObject(json);
			dynamic entry = data.glossary.GlossDiv.GlossList.GlossEntry;
			Console.WriteLine("[" + entry.Abbrev + "] " + entry.GlossTerm + " (" + entry.Acronym + ")");
			Console.WriteLine(entry.GlossDef.para);
		}
	}
}
