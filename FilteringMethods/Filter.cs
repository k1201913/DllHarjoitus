using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{
    public interface Filter
    {

        void Insert(double mittaus);

        double Calculate();
    }
}
