using RoRAssist.Core.Model;
using System.Collections.Generic;

namespace RoRAssist.Core.DA
{
	public class PersuasionRepository : XmlRepository
	{
		public void Save(Persuasion persuasionDA)
		{
			var rootPath = "content/persuasion/";

			var xmlNodeHelpers = new List<XmlNodeContent>
			{
				new XmlNodeContent()
				{
					pathToLastChild = rootPath,
					propertyName = "oratory",
					value = persuasionDA.Oratory.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = rootPath,
					propertyName = "influence",
					value = persuasionDA.Influence.ToString()
				}
			};

			SaveToXml(xmlNodeHelpers);
		}
	}
}