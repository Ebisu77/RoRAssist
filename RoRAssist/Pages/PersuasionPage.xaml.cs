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

namespace RoRAssist.Pages
{
    /// <summary>
    /// Interaction logic for PersuasionPage.xaml
    /// </summary>
    public partial class PersuasionPage : Page
    {
        #region Fields
        string displayResultNumber = "test1";    

        #endregion


        public PersuasionPage()
        {
            InitializeComponent();
            displayResults();             
        }

        //TODO: (VM) Create method for displaying results in lower half of the screen (data binding...)
        private void displayResults()
        {
            LabelResultNumber.DataContext = "Test2";
        }


        #region Controllers
        //TODO: Implement behaviour for changed values in one of boxes 
        //(event handlers? ... alternative: simple button called "calculate")
        private void valueChanged()
        {
            Service.Calculations.CalculatePersuasion();            
        }

        private void SetOratory_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            valueChanged();            
        }
        #endregion
    }
}
