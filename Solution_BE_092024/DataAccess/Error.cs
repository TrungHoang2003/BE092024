using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public enum Error
    {
        Is_Number = 0,
        Is_String = 1,
        Not_Number = -1,
        Not_String = -2,
        String_Empty = -3,
        Valid_String = -4,
        String_Have_HTML = -5,
        String_Have_SpeicalChars = -6,
    }
}
