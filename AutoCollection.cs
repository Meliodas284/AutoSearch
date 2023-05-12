using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearch
{
    internal class AutoCollection
    {
        public ObservableCollection<Auto> Cars { get; }
        
        public void Add(Auto auto)
        {
            Cars.Add(auto);
        }
    }
}
