using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldSchoolPhone
{
   public class BusinessLogic
    {
        public string ConvertToPhoneKeys(string englishSentence, Form1 form)
        {
            Form1 MainForm= form;
            List<string> keypad = MapKeysWithLetters();
            double minTime = 0.0;
            char letterOfSentence;
            string numberedText = "";
            for (int i = 0; i < englishSentence.Length; i++)
            {
                letterOfSentence = englishSentence[i];
                if (IsLetterValid(letterOfSentence))
                {
                    foreach (var keySequence in keypad)
                    {
                        int positionOfLetterInKeySequence = keySequence.IndexOf(letterOfSentence);
                        if (positionOfLetterInKeySequence > -1)
                        {
                            numberedText+=PrintKeyNTimes(keypad.IndexOf(keySequence), positionOfLetterInKeySequence + 1);
                            minTime += CalculateTimeForAKey(positionOfLetterInKeySequence);
                        }
                    }
                }
                else
                {
                    MainForm.ValidateUserInput();
                    break;
                }
            }
            MainForm.PrintRequiredTime(minTime);
            return numberedText;
        }

        private string PrintKeyNTimes(int key, int n)
        {
            string numberedText="";
            for (int i = 0; i < n; i++)
            {
                numberedText += key.ToString();
            }
            return numberedText;
        }

        private bool IsLetterValid(char letterOfSentence)
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


        private double CalculateTimeForAKey(int positionOfLetterInKeySequence)
        {
            return (positionOfLetterInKeySequence + 1) * 0.1 + positionOfLetterInKeySequence * 0.5;
        }

        private List<string> MapKeysWithLetters()
        {
            //index of the list represents the key on the phone index 0 is zero-space, index 1 is key 1-dot, index 2 is abc etc 
            return new List<string>
            {
                //assumption: if user's input is .*# the result will be 11011
               " ",".", "abc","def","ghi","jkl","mno","pqrs","tuv","wxyz","*","#"
            };
        }




    }
}
