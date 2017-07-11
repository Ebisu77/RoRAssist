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

		private void PersuadeButton_Click(object sender, RoutedEventArgs e)
		{
			PersuasionPage page = new PersuasionPage();
			FrameGameplayContent.Navigate(page);
		}

		private void StateTreasuryButton_Click(object sender, RoutedEventArgs e)
		{
			StateTreasuryPage page = new StateTreasuryPage();
			FrameGameplayContent.Navigate(page);
		}

		private void SenateButton_Click(object sender, RoutedEventArgs e)
		{
			SenatePage page = new SenatePage();
			FrameGameplayContent.Navigate(page);
		}
	}
}