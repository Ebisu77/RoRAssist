using RoRAssist.WinApp.ViewModel;
using System.Windows.Controls;

namespace RoRAssist.WinApp.Pages
{
	public partial class PersuasionPage : Page
	{
		public PersuasionPage()
		{
			InitializeComponent();
			DataContext = new PersuasionPageViewModel();
		}
	}
}
