using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoRAssistWinApp.ViewModel
{
	internal class PersuasionPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private PersuasionPageViewModel() { }

		public static PersuasionPageViewModel CreateNewPersuasionPageViewModel()
		{
			return new PersuasionPageViewModel();
		}

	}
}
