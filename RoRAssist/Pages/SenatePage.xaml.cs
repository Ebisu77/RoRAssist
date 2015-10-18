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

        #region Fields

        //data support
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
            labelPlayer_1.DataContext = playerNames[0];
            labelPlayer_2.DataContext = playerNames[1];
            labelPlayer_3.DataContext = playerNames[2];
            labelPlayer_4.DataContext = playerNames[3];
            labelPlayer_5.DataContext = playerNames[4];
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

            //TODO: retrieve number of players

            //retrieve player names and save them into array
            for (int i = 0, playerCount = playerNames.Length; i < playerCount; i++)
            {
                XmlElement element = xmlDoc.SelectSingleNode("//*[@playerID='" + i + "']") as XmlElement;
                playerNames[i] = element.InnerText;
            }           
        }

        #endregion

    }
}
