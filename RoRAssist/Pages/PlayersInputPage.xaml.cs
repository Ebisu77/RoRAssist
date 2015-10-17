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
        //probably use style triggers
        //TODO: implement special cases of solitare and 2-player game (checkboxes?, maybe tooltips 
        //when 1or2 players are chosen in box)
        //TODO: clamp min/max number of players in UI (1-6 or 3-6 depending on solitaire solution)

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
            doc.Load(@"C:\Users\Anakin\OneDrive\Programming\Repo\RoRAssist\RoRAssist\Data\Players.xml");

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
                if (name != null)
                {
                    XmlNode node = doc.SelectSingleNode("/content/players");
                    XmlElement element = doc.CreateElement("player");

                    element.InnerText = name;
                    element.SetAttribute("playerID", count.ToString());
                    node.AppendChild(element);

                    count++;
                }
            }
            
            //save results
            doc.Save(@"C:\Users\Anakin\OneDrive\Programming\Repo\RoRAssist\RoRAssist\Data\Players.xml");
        }       

        #endregion

        #region Events

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: implement return to main page without saving data            
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
