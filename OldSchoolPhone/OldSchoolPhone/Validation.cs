using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldSchoolPhone
{
   public class Validation
    {
        public static bool IsLetterValid(char letterOfSentence)
        {
            int asciiOfLetter = (int)letterOfSentence;
            if (((asciiOfLetter > 96) && (asciiOfLetter < 123)) || (asciiOfLetter == 42)
            || (asciiOfLetter == 46) || (asciiOfLetter == 32)
            || (asciiOfLetter == 35))
            {
                return true;
            }
            return false;
        }
    }
}
