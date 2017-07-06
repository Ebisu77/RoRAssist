using System.Diagnostics;
using System.Reflection;

namespace RoRAssistWinApp.Model
{
	internal class MetaDataModel
	{
		internal FileVersionInfo GetFileVersionInfo()
		{
			var executingAssembly = Assembly.GetExecutingAssembly();
			return FileVersionInfo.GetVersionInfo(executingAssembly.Location);
		}
	}
}