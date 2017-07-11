using RoRAssistWinApp.ViewModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace RoRAssistWinApp.Pages
{
	public partial class MainPage : Page
	{
		//TODO: Gray out "continue" button if this is first game ever (check data?)

		public MainPage()
		{
			InitializeComponent();
			DisplayVersionNumber();
		}

		private void DisplayVersionNumber()
		{
			var vm = new MainPageViewModel();
			versionTextBlock.DataContext = vm.VersionNumber;
		}

		private void ContinueButton_Click(object sender, RoutedEventArgs e)
		{
			DefaultPage newPage = new DefaultPage();
			NavigationService.Navigate(newPage);
		}

		private void StartButton_Click(object sender, RoutedEventArgs e)
		{
			PlayersInputPage newPage = new PlayersInputPage();
			NavigationService.Navigate(newPage);
		}

		private void QuitButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}