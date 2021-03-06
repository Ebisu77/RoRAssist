﻿using RoRAssist.WinApp.Model;

namespace RoRAssist.WinApp.ViewModel
{
	internal class MainPageViewModel : BaseViewModel
	{
		private MetaDataModel model;

		public string VersionNumber => GetVersionNumber();

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