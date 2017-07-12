using System.Collections.Generic;
using System.Xml;

namespace RoRAssist.Core.DA
{
	public class XmlRepository
	{
		private XmlDocument document;

		internal struct XmlNodeContent
		{
			internal string pathToLastChild;
			internal string propertyName;
			internal string value;
		}

		internal XmlRepository()
		{
			document = new XmlDocument();
			// TODO: path to config or embeded resource or constant? + probably class for extracting values from config...
			document.Load(@"D:\Repository\RoRAssist\Core\Data\CurrentSession.xml");
		}

		internal void SaveToXml(List<XmlNodeContent> nodes)
		{
			foreach (var node in nodes)
			{
				UpdateNode(node);
			}

			SaveFile();
		}

		private void UpdateNode(XmlNodeContent nodeContent)
		{
			var node = document.SelectSingleNode(nodeContent.pathToLastChild + nodeContent.propertyName) as XmlNode;
			if (node.Value != nodeContent.value)
			{
				node.InnerText = nodeContent.value;
			}
		}

		private void SaveFile()
		{
			document.Save(@"D:\Repository\RoRAssist\Core\Data\CurrentSession.xml");
		}
	}
}