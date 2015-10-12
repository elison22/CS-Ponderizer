using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ponderizer.Library.Content
{
    interface IContent
    {
        string getText();
        string getDisplayName();
        string getFooter();
    }
}
