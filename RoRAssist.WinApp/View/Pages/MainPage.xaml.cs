using RoRAssist.WinApp.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace RoRAssist.WinApp.Pages
{
	public partial class MainPage : Page
	{
		//TODO: Gray out "continue" button if this is first game ever (check data?)

		public MainPage()
		{
			InitializeComponent();
			DataContext = new MainPageViewModel();
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