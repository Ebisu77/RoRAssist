using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace RoRAssist.Core.DA
{
	public class XmlRepository
	{
		private readonly XmlDocument document;

		internal struct XmlNodeContent
		{
			internal string pathToLastChild;
			internal string propertyName;
			internal string value;
		}

		internal XmlRepository()
		{
			document = new XmlDocument();
			// TODO: path to config or embedded resource or constant? + probably class for extracting values from config...
			document.Load(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\RoRAssist.Core\Data\CurrentSession.xml"));
		}

		internal void SaveToXml(List<XmlNodeContent> nodes)
		{
			foreach (var node in nodes)
			{
				UpdateNode(node);
			}

			SaveFile();
		}

		internal XmlNodeContent GetXmlNodeContent(string pathToLastChild, string propertyName)
		{
			var node = document.SelectSingleNode(pathToLastChild + propertyName) as XmlNode;

			return new XmlNodeContent()
			{
				pathToLastChild = pathToLastChild,
				propertyName = node.Name,
				value = node.InnerText
			};
		}

		private void UpdateNode(XmlNodeContent nodeContent)
		{
			var node = document.SelectSingleNode(nodeContent.pathToLastChild + nodeContent.propertyName) as XmlNode;

			if (node.Value != nodeContent.value)
				node.InnerText = nodeContent.value;
		}

		private void SaveFile()
		{
			document.Save(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\RoRAssist.Core\Data\CurrentSession.xml"));
		}
	}
}
