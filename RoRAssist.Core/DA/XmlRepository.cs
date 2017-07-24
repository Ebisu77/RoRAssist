using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace RoRAssist.Core.DA
{
	public class XmlRepository
	{
		private readonly XmlDocument _document;
		private readonly string _pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\RoRAssist.Core\Data\CurrentSession.xml");

		internal struct XmlNodeContent
		{
			internal string pathToLastChild;
			internal string propertyName;
			internal string value;
		}

		internal XmlRepository()
		{
			_document = new XmlDocument();
			_document.Load(_pathToXmlFile);
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
			var node = _document.SelectSingleNode(pathToLastChild + propertyName) as XmlNode;

			return new XmlNodeContent()
			{
				pathToLastChild = pathToLastChild,
				propertyName = node.Name,
				value = node.InnerText
			};
		}

		private void UpdateNode(XmlNodeContent nodeContent)
		{
			var node = _document.SelectSingleNode(nodeContent.pathToLastChild + nodeContent.propertyName) as XmlNode;

			if (node.Value != nodeContent.value)
				node.InnerText = nodeContent.value;
		}

		private void SaveFile()
		{
			_document.Save(_pathToXmlFile);
		}
	}
}
