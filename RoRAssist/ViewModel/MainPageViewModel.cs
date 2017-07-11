using RoRAssistWinApp.Model;

namespace RoRAssistWinApp.ViewModel
{
	internal class MainPageViewModel
	{
		private MetaDataModel model;

		internal string VersionNumber => GetVersionNumber();

		public MainPageViewModel()
		{
			model = new MetaDataModel();
		}

		private string GetVersionNumber()
		{
			var versionInfo = model.GetFileVersionInfo();
			return $"v. {versionInfo.ProductMajorPart}.{versionInfo.ProductMinorPart}.{versionInfo.ProductBuildPart}";
		}
	}
}