using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Passwortgenerator.source.password;
using System.IO;

/*Nutzer-Handbuch*/
/*Abschlusspräsentation Projekt letzte Woche*/
/*Bisschen was zum Code sagen*/
/*Bisschen was zum Projektverlauf sagen*/
/*Anwendung zeigen*/

namespace Passwortgenerator.source.password
{
    public class Wordlist
    {
        public string wordString = "";

        public Wordlist(int wordCount)
        {
            Random rnd = new Random();

            for (int i = 0; i < wordCount; i++)
            {
                wordString += File.ReadLines("woerter.txt").Skip(rnd.Next(1, 286291)).Take(1).First() + " "; //gibt [n] wörter mit space getrennt zurück
            }
        }

        public String getString()
        {
            return wordString;
        }
    }
}