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

namespace RoRAssist.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        //TODO: Gray out "continue" button if this is first game ever (check data?)

        #region Constructors

        /// <summary>
        /// Constructor for Main Page
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Handling of continue button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultPage newPage = new DefaultPage();
            this.NavigationService.Navigate(newPage);
        }

        /// <summary>
        /// Handling of start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            PlayersInputPage newPage = new PlayersInputPage();
            this.NavigationService.Navigate(newPage);
        }

        /// <summary>
        /// Handling of quit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        #endregion

    }
}
