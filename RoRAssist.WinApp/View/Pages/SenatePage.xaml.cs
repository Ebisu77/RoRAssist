using System;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace RoRAssist.WinApp.Pages
{
	public partial class SenatePage : Page
	{
		//TODO: add visibility of element based on number of players

		//data support
		private int playersCount;

		private string[] playerNames = new string[6];
		private int[] playersOratory = new int[6];
		private int[] playersKnights = new int[6];
		private int[] playersTalents = new int[6];

		public SenatePage()
		{
			InitializeComponent();
			retrievePlayerData();
			displayResults();
		}

		private void retrievePlayerData()
		{
			// create an instance of xml document
			var xmlDoc = new XmlDocument();
			xmlDoc.Load(Service.Constants.PathToPlayersData);

			// retrieve number of players
			playersCount = Convert.ToInt32(xmlDoc.SelectSingleNode("//numberOfPlayers").InnerText);

			// retrieve player names and save them into array
			for (int i = 0; i < playersCount; i++)
			{
				XmlElement element = xmlDoc.SelectSingleNode("//*[@playerID='" + i + "']") as XmlElement;
				playerNames[i] = element.InnerText;
			}
		}

		private void displayResults()
		{
			// set visibility of stackpanels
			if (stackPlayer1 != null)
			{
				stackPlayer1.Visibility = (playersCount > 0) ?
				Visibility.Visible : Visibility.Hidden;
			}
			if (stackPlayer2 != null)
			{
				stackPlayer2.Visibility = (playersCount > 1) ?
				Visibility.Visible : Visibility.Hidden;
			}
			if (stackPlayer3 != null)
			{
				stackPlayer3.Visibility = (playersCount > 2) ?
				Visibility.Visible : Visibility.Hidden;
			}
			if (stackPlayer4 != null)
			{
				stackPlayer4.Visibility = (playersCount > 3) ?
				Visibility.Visible : Visibility.Hidden;
			}
			if (stackPlayer5 != null)
			{
				stackPlayer5.Visibility = (playersCount > 4) ?
				Visibility.Visible : Visibility.Hidden;
			}
			if (stackPlayer6 != null)
			{
				stackPlayer6.Visibility = (playersCount > 5) ?
				Visibility.Visible : Visibility.Hidden;
			}

			// show proper player names in labels
			if (labelPlayer_1 != null)
				labelPlayer_1.DataContext = playerNames[0];
			if (labelPlayer_2 != null)
				labelPlayer_2.DataContext = playerNames[1];
			if (labelPlayer_3 != null)
				labelPlayer_3.DataContext = playerNames[2];
			if (labelPlayer_4 != null)
				labelPlayer_4.DataContext = playerNames[3];
			if (labelPlayer_5 != null)
				labelPlayer_5.DataContext = playerNames[4];
			if (labelPlayer_6 != null)
				labelPlayer_6.DataContext = playerNames[5];
		}

		private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
		{
			// save players oratory into array
			if (oratoryUpDown_player1 != null)
				playersOratory[0] = (int)oratoryUpDown_player1.Value;
			if (oratoryUpDown_player2 != null)
				playersOratory[1] = (int)oratoryUpDown_player2.Value;
			if (oratoryUpDown_player3 != null)
				playersOratory[2] = (int)oratoryUpDown_player3.Value;
			if (oratoryUpDown_player4 != null)
				playersOratory[3] = (int)oratoryUpDown_player4.Value;
			if (oratoryUpDown_player5 != null)
				playersOratory[4] = (int)oratoryUpDown_player5.Value;
			if (oratoryUpDown_player6 != null)
				playersOratory[5] = (int)oratoryUpDown_player6.Value;

			// save number of player knighs into array
			if (knightsUpDown_player1 != null)
				playersKnights[0] = (int)knightsUpDown_player1.Value;
			if (knightsUpDown_player2 != null)
				playersKnights[1] = (int)knightsUpDown_player2.Value;
			if (knightsUpDown_player3 != null)
				playersKnights[2] = (int)knightsUpDown_player3.Value;
			if (knightsUpDown_player4 != null)
				playersKnights[3] = (int)knightsUpDown_player4.Value;
			if (knightsUpDown_player5 != null)
				playersKnights[4] = (int)knightsUpDown_player5.Value;
			if (knightsUpDown_player6 != null)
				playersKnights[5] = (int)knightsUpDown_player6.Value;

			// save players talents into array
			if (talentsUpDown_player1 != null)
				playersTalents[0] = (int)talentsUpDown_player1.Value;
			if (talentsUpDown_player2 != null)
				playersTalents[1] = (int)talentsUpDown_player2.Value;
			if (talentsUpDown_player3 != null)
				playersTalents[2] = (int)talentsUpDown_player3.Value;
			if (talentsUpDown_player4 != null)
				playersTalents[3] = (int)talentsUpDown_player4.Value;
			if (talentsUpDown_player5 != null)
				playersTalents[4] = (int)talentsUpDown_player5.Value;
			if (talentsUpDown_player6 != null)
				playersTalents[5] = (int)talentsUpDown_player6.Value;
		}
	}
}