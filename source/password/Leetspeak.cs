using System;
using System.Collections.Generic;
using Passwortgenerator.source.password;

namespace Passwortgenerator.source.password
{
    public class Leetspeak : Password
    {
        Dictionary<char, string> leetSpeackTable = new Dictionary<char, string>();
        string returnString;
        string leetString;
        string upperLeetString;
        //public Wordlist wordlist;
        public Leetspeak()
        {
            leetSpeackTable.Add('A', "@");
            leetSpeackTable.Add('B', "8");
            leetSpeackTable.Add('C', "(");
            leetSpeackTable.Add('E', "3");
            leetSpeackTable.Add('G', "6");
            leetSpeackTable.Add('H', "4");
            leetSpeackTable.Add('I', "!");
            leetSpeackTable.Add('K', "|{");
            leetSpeackTable.Add('L', "1");
            leetSpeackTable.Add('M', "/\\/\\"); //gibt /\/\ der \ musste nur maskiert werden
            leetSpeackTable.Add('N', "/\\/");
            leetSpeackTable.Add('O', "0");
            leetSpeackTable.Add('P', "8");
            leetSpeackTable.Add('S', "5");
            leetSpeackTable.Add('T', "7");
            leetSpeackTable.Add('U', "LI");
            leetSpeackTable.Add('V', "\\/");
            leetSpeackTable.Add('X', "><");
        }

        public string GeneratePassword(Setting setting)
        {
            leetString = "";
            leetString = setting.getLeetString();
            upperLeetString = "";
            upperLeetString = leetString.ToUpper();
            returnString = "";

            foreach (char c in upperLeetString)
            {
                if (leetSpeackTable.ContainsKey(c))
                {
                    returnString += leetSpeackTable[c];
                }
                else
                {
                    returnString += c;
                }
            }
            return returnString;
        }
    }
}