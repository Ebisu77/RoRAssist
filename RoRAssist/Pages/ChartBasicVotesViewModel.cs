using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace RoRAssist.Pages
{    
    public class ChartBasicVotesViewModel
    {

        public ChartBasicVotesViewModel()
        {

            var plotmodel1 = new PlotModel();


            //this.Title = "Example 2";
            //ColumnSeries theSeries = new ColumnSeries();
            //ColumnItem haha = new ColumnItem();
            //haha.Value = 7;
            //theSeries.Items.Add(haha);

            ////this.Points = new List<DataPoint>
            ////                  {
            //                      new DataPoint(0, 4),
            //                      new DataPoint(10, 13),
            //                      new DataPoint(20, 15),
            //                      new DataPoint(30, 16),
            //                      new DataPoint(40, 12),
            //                      new DataPoint(50, 12)
            //                  };

        }

        public string Title { get; private set; }

        public PlotModel plotModel { get; set; }

        public IList<DataPoint> Points { get; private set; }
    }
}
