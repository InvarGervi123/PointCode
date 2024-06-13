using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class SingleCoordinate
    {
        int _pastV;
        int _currentValue;
        public int Value
        {
            get
            {
                return _currentValue;
            }
            set
            {
                _pastV = _currentValue;
                _currentValue = value;
            }
        }

        public int PastValue
        {
            get
            {
                return _pastV;
            }
        }
    }
}
