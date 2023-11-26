using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.Prak
{
    public class PropertyeventArgs : EventArgs
    {
        public string PropertyName { get; private set; }

        public PropertyeventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
