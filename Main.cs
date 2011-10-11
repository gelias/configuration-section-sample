using System;
using System.Configuration;
namespace ConfigurationSectionSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var settingsAsSection = ConfigurationManager.GetSection("CustomSettings") as CustomSettings;
			Console.WriteLine (settingsAsSection.PropertyOne);
			Console.WriteLine (settingsAsSection.PropertyTwo);
			Console.WriteLine (settingsAsSection.PropertyThree);
		}
	}
}

