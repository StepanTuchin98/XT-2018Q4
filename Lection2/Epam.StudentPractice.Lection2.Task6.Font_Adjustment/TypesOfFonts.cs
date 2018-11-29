using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task6.Font_Adjustment
{
    [Flags]
    enum TypesOfFonts : byte
    {
        None,
        Bold,
        Italic,
        Underline = 4,
    }
}
