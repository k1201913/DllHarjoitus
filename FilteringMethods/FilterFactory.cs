using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{
    public class FilterFactory 
    {

        public static Filter CreateFilter(FilterType type, int lenght)
        {
            Filter filter = null;
            switch (type)
            {
                case FilterType.Average:
                    {
                        filter = (Filter)new AverageFilter(lenght);
                        break;
                    }

                case FilterType.Median:
                    {
                        filter = (Filter)new MedianFilter(lenght);
                        break;
                    }
            }
            return filter;

        }

    
    }
}
