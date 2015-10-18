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
    /// Interaction logic for SenatePage.xaml
    /// </summary>
    public partial class SenatePage : Page
    {

        //TODO: add visibility of element based on number of players

        #region Fields

        //data support
        int playersCount;
        string[] playerNames = new string[6];        

        #endregion

        #region Constructors

        /// <summary>
        /// Senate Page constructor
        /// </summary>
        public SenatePage()
        {
            InitializeComponent();
            retrievePlayerData();
            displayResults();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Display results in UI
        /// </summary>
        private void displayResults()
        {
            //set visibility of stackpanels
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

            //show proper player names in labels
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

        /// <summary>
        /// retrieve names of players from xml
        /// </summary>
        private void retrievePlayerData()
        {
            //create an instance of xml document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\Anakin\OneDrive\Programming\Repo\RoRAssist\RoRAssist\Data\Players.xml");

            //retrieve number of players
            playersCount = Convert.ToInt32(xmlDoc.SelectSingleNode("//numberOfPlayers").InnerText);

            //retrieve player names and save them into array
            for (int i = 0; i < playersCount; i++)
            {
                XmlElement element = xmlDoc.SelectSingleNode("//*[@playerID='" + i + "']") as XmlElement;
                playerNames[i] = element.InnerText;
            }           
        }

        #endregion

        #region Events

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        #endregion
    }
}
