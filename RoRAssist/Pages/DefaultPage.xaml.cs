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
    /// Interaction logic for DefaultPage.xaml    
    /// </summary>
    public partial class DefaultPage : Page
    {


        #region Constructors

        /// <summary>
        /// DefaultPage constructor
        /// </summary>
        public DefaultPage()
        {
            InitializeComponent();            
        }

        #endregion

        #region Events

        /// <summary>
        /// Load PersuasionPage into main frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void persuadeButton_Click(object sender, RoutedEventArgs e)
        {
            PersuasionPage page = new PersuasionPage();
            this.FrameGameplayContent.Navigate(page);
        }

        /// <summary>
        /// Load StateTreasuryPage into main frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stateTreasuryButton_Click(object sender, RoutedEventArgs e)
        {
            StateTreasuryPage page = new StateTreasuryPage();
            this.FrameGameplayContent.Navigate(page);
        }

        #endregion
    }
}
