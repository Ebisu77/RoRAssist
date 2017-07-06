using RoRAssistWinApp.Model;

namespace RoRAssistWinApp.ViewModel
{
	internal class MainPageViewModel
	{
		internal string GetVersionNumber()
		{
			var model = new MetaDataModel();
			var versionInfo = model.GetFileVersionInfo();

			return $"v. {versionInfo.ProductMajorPart}.{versionInfo.ProductMinorPart}.{versionInfo.ProductBuildPart}";
		}
	}
}