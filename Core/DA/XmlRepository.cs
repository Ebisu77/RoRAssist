using System.Xml;

namespace RoRAssist.Core.DA
{
	public class XmlRepository
	{
		internal void SaveToXmlNode(string targetNode, string value)
		{
			var document = new XmlDocument();
			// TODO: path to config or embeded resource
			document.Load(@"D:\Repository\RoRAssist\Core\Data\CurrentSession.xml");

			var node = document.SelectSingleNode(targetNode) as XmlNode;
			node.InnerText = value;

			document.Save(@"D:\Repository\RoRAssist\Core\Data\CurrentSession.xml");
		}
	}
}