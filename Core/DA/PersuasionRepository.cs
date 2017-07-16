using RoRAssist.Core.Model;
using System.Collections.Generic;
using System;

namespace RoRAssist.Core.DA
{
	public class PersuasionRepository : XmlRepository
	{
		readonly string pathToLastChild = "Content/Persuasion/";

		public void Save(Persuasion persuasion)
		{
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
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.ResultBaseNumber),
					value = persuasion.ResultBaseNumber.ToString()
				},
				new XmlNodeContent()
				{
					pathToLastChild = pathToLastChild,
					propertyName = nameof(persuasion.ResultDiceRoll),
					value = persuasion.ResultDiceRoll.ToString()
				}
			};

			SaveToXml(xmlNodeHelpers);
		}

		public Persuasion GetPersuasion()
		{
			return new Persuasion()
			{
				Oratory = int.Parse(GetXmlNodeContent(pathToLastChild, "Oratory").value),
				Influence = int.Parse(GetXmlNodeContent(pathToLastChild, "Influence").value),
				Bribe = int.Parse(GetXmlNodeContent(pathToLastChild, "Bribe").value),
				CounterBribe = int.Parse(GetXmlNodeContent(pathToLastChild, "CounterBribe").value),
				PersonalTreasury = int.Parse(GetXmlNodeContent(pathToLastChild, "PersonalTreasury").value),
				Loyalty = int.Parse(GetXmlNodeContent(pathToLastChild, "Loyalty").value),
				SenatorInFaction = Convert.ToBoolean(GetXmlNodeContent(pathToLastChild, "SenatorInFaction").value),
				EraEnd = Convert.ToBoolean(GetXmlNodeContent(pathToLastChild, "EraEnd").value),
				ResultBaseNumber = int.Parse(GetXmlNodeContent(pathToLastChild, "ResultBaseNumber").value),
				ResultDiceRoll = int.Parse(GetXmlNodeContent(pathToLastChild, "ResultDiceRoll").value)
			};
		}
	}
}