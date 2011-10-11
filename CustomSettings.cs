using System;
using System.Configuration;

namespace ConfigurationSectionSample
{
	public class CustomSettings:ConfigurationSection
	{
		public CustomSettings () { }
		
		[ConfigurationProperty("propertyOne",IsRequired=true)]
		public string PropertyOne 
		{
			get
			{
				return this["propertyOne"] as string;
			}
		}
		
		[ConfigurationProperty("propertyTwo",IsRequired=true)]
		public string PropertyTwo 
		{
			get
			{
				return this["propertyTwo"] as string;
			}
		}
		
		[ConfigurationProperty("propertyThree",IsRequired=true)]
		public string PropertyThree 
		{
			get
			{
				return this["propertyThree"] as string;
			}
		}
	}
}

