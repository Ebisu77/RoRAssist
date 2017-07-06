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
			displayVersionNumber();
		}

		private void displayVersionNumber()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);

			string versionMajor = versionInfo.ProductMajorPart.ToString();
			string versionMinor = versionInfo.ProductMinorPart.ToString();
			string versionBuild = versionInfo.ProductBuildPart.ToString();

			versionTextBlock.DataContext = "v. " + versionMajor + "." + versionMinor + "." + versionBuild;
		}

		private void continueButton_Click(object sender, RoutedEventArgs e)
		{
			DefaultPage newPage = new DefaultPage();
			this.NavigationService.Navigate(newPage);
		}

		private void startButton_Click(object sender, RoutedEventArgs e)
		{
			PlayersInputPage newPage = new PlayersInputPage();
			this.NavigationService.Navigate(newPage);
		}

		private void quitButton_Click(object sender, RoutedEventArgs e)
		{
			App.Current.Shutdown();
		}
	}
}