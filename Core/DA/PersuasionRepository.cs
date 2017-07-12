using RoRAssist.Core.Model;

namespace RoRAssist.Core.DA
{
	public class PersuasionRepository : XmlRepository
	{
		public void Save(Persuasion persuasionDA)
		{
			var rootPath = "content/persuasion/";

			SaveToXmlNode(rootPath + "oratory", persuasionDA.Oratory.ToString());
		}
	}
}