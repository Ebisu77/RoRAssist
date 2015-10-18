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

namespace RoRAssist
{
    //TODO: general ideas:             
    //- play with visibility of UI elemnts (e.g. bold fontweight)
    //- do "graphic" of ui, eg.: lines or labels (styles)
    //- calmp control values in UI (e.g. no negative numbers for personal treasury)
    //- save data of indivirual pages to xml


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();

            //create first instance of main page
            Pages.MainPage newMainPage = new Pages.MainPage();
            this.MainFrame.Navigate(newMainPage);    
        }
    }
}
