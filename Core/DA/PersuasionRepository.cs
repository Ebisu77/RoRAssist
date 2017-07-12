using RoRAssist.Core.Model;
using System.Collections.Generic;
using System;

namespace RoRAssist.Core.DA
{
	public class PersuasionRepository : XmlRepository
	{
		public void Save(Persuasion persuasion)
		{
			var pathToLastChild = "Content/Persuasion/";

			var xmlNodeHelpers = new List<XmlNodeContent>
			{
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.Oratory),
					value = persuasion.Oratory.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.Influence),
					value = persuasion.Influence.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.Bribe),
					value = persuasion.Bribe.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.Loyalty),
					value = persuasion.Loyalty.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.PersonalTreasury),
					value = persuasion.PersonalTreasury.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.CounterBribe),
					value = persuasion.CounterBribe.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.SenatorInFaction),
					value = persuasion.SenatorInFaction.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.EraEnd),
					value = persuasion.EraEnd.ToString()
				}
			};

			SaveToXml(xmlNodeHelpers);
		}

		public Persuasion GetPersuasion()
		{
			var pathToLastChild = "Content/Persuasion/";

			var result = new Persuasion()
			{
				Oratory = int.Parse(GetXmlNodeContent(pathToLastChild, "Oratory").value)
			};

			return result;
		}
	}
}