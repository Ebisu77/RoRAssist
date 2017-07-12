using System;
using System.Diagnostics;
using System.Reflection;

namespace RoRAssistWinApp.Model
{
	internal class MetaDataModel : BaseModel
	{
		public override void SaveData(object viewModel)
		{
			throw new NotImplementedException();
		}

		internal FileVersionInfo GetFileVersionInfo()
		{
			var executingAssembly = Assembly.GetExecutingAssembly();
			return FileVersionInfo.GetVersionInfo(executingAssembly.Location);
		}
	}
}