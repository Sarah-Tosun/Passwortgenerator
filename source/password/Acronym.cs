using System;
using Passwortgenerator.source.password;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Passwortgenerator.source.password
{
    public class Acronym : Password
    {
        private string returnString = "tetssf dfdf dfd df df ";
        public Wordlist wordlist;

        public Acronym() {/* */}

        public void createAcronym(string wordList)
        {

        }

        public string GeneratePassword(Setting setting)
        {
            wordlist = new Wordlist(setting.getWordCount());
            Char delimiter = ' ';
            String[] substrings = wordlist.getString().Split(delimiter);
            foreach (var substring in substrings)
                returnString += substring[0];

            return returnString;
        }
    }

}
