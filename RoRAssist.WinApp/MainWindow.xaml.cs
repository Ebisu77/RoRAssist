namespace RoRAssist.WinApp
{
	//general ideas:
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

	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			Pages.MainPage newMainPage = new Pages.MainPage();
			MainFrame.Navigate(newMainPage);
		}
	}
}
