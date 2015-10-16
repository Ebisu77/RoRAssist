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
        //TODO: make boxes for player apear and dissapear based on number of players chosen
        //probably use style triggers?
        //TODO: implement special cases of solitare and 2-player game


        #region Fields

        int playersCount;
        string playerName1, playerName2, playerName3, playerName4, playerName5, playerName6;

        #endregion
        
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public PlayersInputPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Save aquired data into XML
        /// </summary>
        private void saveData()
        {
            // Create an instance of XML document 
            XmlDocument doc = new XmlDocument(); 
            doc.Load(@"C:\Users\Anakin\OneDrive\Programming\Repo\RoRAssist\RoRAssist\Data\Players.xml");

            //save number of players into XML
            XmlElement xElementCount = doc.SelectSingleNode("/players/numberOfPlayers") as XmlElement;
            xElementCount.InnerText = playersCount.ToString();

            //TODO: save names of players
            XmlElement xElementPlayers = doc.SelectSingleNode("/players/player") as XmlElement;

            doc.Save(@"C:\Users\Anakin\OneDrive\Programming\Repo\RoRAssist\RoRAssist\Data\Players.xml");
        }       

        #endregion

        #region Events

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: implement return to main page without saving data            
        }

        /// <summary>
        /// Handle click on finished button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            //Save User input into variable
            if (playersCountUpDownButton != null)            
                playersCount = (int)playersCountUpDownButton.Value;
            if (textboxPlayer1 != null)
                playerName1 = textboxPlayer1.Text;
            if (textboxPlayer2 != null)
                playerName2 = textboxPlayer2.Text;
            if (textboxPlayer3 != null)
                playerName3 = textboxPlayer3.Text;
            if (textboxPlayer4 != null)
                playerName4 = textboxPlayer4.Text;
            if (textboxPlayer5 != null)
                playerName5 = textboxPlayer5.Text;
            if (textboxPlayer6 != null)
                playerName6 = textboxPlayer6.Text;

            //save aquired data
            saveData();

            //load default page
            DefaultPage newPage = new DefaultPage();
            this.NavigationService.Navigate(newPage);
        }

        #endregion
                
    }
}
