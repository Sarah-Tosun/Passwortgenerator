using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Passwortgenerator.source.propertie
{
    
    public class Whirlpool
    {
        public string newPassword;
        public string rand;
        public int wordCount;
        public Whirlpool(String charset, int wordCount)
        {
            char[] array = charset.ToCharArray();
            this.wordCount = wordCount;
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            newPassword = string.Join("", array);

        }

        public string getPassword()
        {
            return newPassword.Substring(0, wordCount+1);
        }
    }
}