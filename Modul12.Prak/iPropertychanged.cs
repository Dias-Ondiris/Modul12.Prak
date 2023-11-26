using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.Prak
{
    public delegate void PropertyeventHandler(object sender, PropertyeventArgs e);

    public interface iPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
