using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using System.Xml;

namespace RoRAssist.Pages
{
    /// <summary>
    /// Interaction logic for PlayersInputPage.xaml
    /// </summary>
    public partial class PlayersInputPage : Page
    {
        //TODO: make tooltip with descripton for solitaire, 2 player and regular game        

        #region Fields        

        //declare total number of players and names of players
        int playersCount;
        string[] names = new string[6];

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for PlayersInputPage
        /// </summary>
        public PlayersInputPage()
        {
            InitializeComponent();
            displayPlayerTextboxes();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Save aquired data into XML
        /// </summary>
        private void saveData()
        {
            //create an instance of XML document 
            XmlDocument doc = new XmlDocument();
            doc.Load(Service.Constants.pathToPlayersData);

            //save number of players into XML
            XmlNode xmlPlayersCount = doc.SelectSingleNode("/content/numberOfPlayers");
            xmlPlayersCount.InnerText = playersCount.ToString();

            //delete all old player names
            XmlNode xmlPlayers = doc.SelectSingleNode("/content/players");
            xmlPlayers.RemoveAll();

            //save new player names
            int count = 0;
            foreach (string name in names)
            {
                if (name == null)
                {
                    count++;
                    continue;
                }

                XmlNode node = doc.SelectSingleNode("/content/players");
                XmlElement element = doc.CreateElement("player");

                element.InnerText = name;
                element.SetAttribute("playerID", count.ToString());
                node.AppendChild(element);

                count++;
            }

            //save results
            doc.Save(Service.Constants.pathToPlayersData);
        }

        /// <summary>
        /// Displays textboxes for player names based on number of players
        /// </summary>
        private void displayPlayerTextboxes()
        {
            playersCount = (int)playersCountUpDownButton.Value;


            //playerID = '" + i + "'

            if (dockPanelPlayer_1 != null)
                dockPanelPlayer_1.Visibility = (playersCount > 0) ?
                Visibility.Visible : Visibility.Hidden;
            if (dockPanelPlayer_2 != null)
                dockPanelPlayer_2.Visibility = (playersCount > 1) ?
                Visibility.Visible : Visibility.Hidden;
            if (dockPanelPlayer_3 != null)
                dockPanelPlayer_3.Visibility = (playersCount > 2) ?
                Visibility.Visible : Visibility.Hidden;
            if (dockPanelPlayer_4 != null)
                dockPanelPlayer_4.Visibility = (playersCount > 3) ?
                Visibility.Visible : Visibility.Hidden;
            if (dockPanelPlayer_5 != null)
                dockPanelPlayer_5.Visibility = (playersCount > 4) ?
                Visibility.Visible : Visibility.Hidden;
            if (dockPanelPlayer_6 != null)
                dockPanelPlayer_6.Visibility = (playersCount > 5) ?
                Visibility.Visible : Visibility.Hidden;
        }

        #endregion

        #region Events

        /// <summary>
        /// Returns to main page without saving data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage newPage = new MainPage();
            this.NavigationService.Navigate(newPage);
        }

        /// <summary>
        /// Displays textboxes for names of players based on chosen number of players 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playersCountUpDownButton_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            displayPlayerTextboxes();
        }

        /// <summary>
        /// Handle click on done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            //save User input into variables
            if (playersCountUpDownButton != null)
                playersCount = (int)playersCountUpDownButton.Value;
            if (textboxPlayer1 != null)
                names[0] = textboxPlayer1.Text;
            if (textboxPlayer2 != null)
                names[1] = textboxPlayer2.Text;
            if (textboxPlayer3 != null)
                names[2] = textboxPlayer3.Text;
            if (textboxPlayer4 != null)
                names[3] = textboxPlayer4.Text;
            if (textboxPlayer5 != null)
                names[4] = textboxPlayer5.Text;
            if (textboxPlayer6 != null)
                names[5] = textboxPlayer6.Text;

            //save aquired data
            saveData();

            //load default page
            DefaultPage newPage = new DefaultPage();
            this.NavigationService.Navigate(newPage);
        }

        #endregion

    }
}
