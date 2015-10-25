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
    //- play with visibility of UI elemnts (e.g. bold fontweight, tooltips, better grids, 
    //  center everything on window size change, maybe grid spliter where it is logical)
    //- do "graphic" of ui, eg.: lines or labels (styles)
    //- calmp control values in UI (e.g. no negative numbers for personal treasury)
    //- save data of indivirual pages to xml
    //- go through labes and decide which of them will become textboxes (after styles are decided)
    //- Add toolbar on default page? Settings, save, help, update...
    //- Add options to main page (font size, colors...)
    //- add todo and pictures to readme.md
    //- play with grids in UI, so things stay in center of window
    //- add sliders under UI controls where input range might be huge (e.g. state treasury)
    //- put underscores into menu items (and create menu items: save, options, help, exit...)
    //- make page for fast sequence of play with main rules (+put rules numbers there for easy search in rules, 
    //  probably use flow document reader for this)    

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
