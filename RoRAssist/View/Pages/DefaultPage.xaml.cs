using System.Windows;
using System.Windows.Controls;

namespace RoRAssistWinApp.Pages
{
	public partial class DefaultPage : Page
	{
		public DefaultPage()
		{
			InitializeComponent();
		}

		private void persuadeButton_Click(object sender, RoutedEventArgs e)
		{
			PersuasionPage page = new PersuasionPage();
			this.FrameGameplayContent.Navigate(page);
		}

		private void stateTreasuryButton_Click(object sender, RoutedEventArgs e)
		{
			StateTreasuryPage page = new StateTreasuryPage();
			this.FrameGameplayContent.Navigate(page);
		}

		private void senateButton_Click(object sender, RoutedEventArgs e)
		{
			SenatePage page = new SenatePage();
			this.FrameGameplayContent.Navigate(page);
		}
	}
}