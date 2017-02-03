using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Passwortgenerator.source.propertie;

namespace Passwortgenerator.source.password
{
    public class Setting
    {
        Dictionary<string, bool> currentSetting = new Dictionary<string, bool>();
        int wordCount = 0;
        string leetString;
        //private bool acronym = false;
        private bool leetspeak = false;
        public Setting()
        {
            currentSetting.Add("alpha", false);
            currentSetting.Add("capAlpha", false);
            currentSetting.Add("num", false);
            currentSetting.Add("specialChar", false);
            currentSetting.Add("space", false);
            currentSetting.Add("leet", false);
            currentSetting.Add("words", false);
            currentSetting.Add("anag", false);
            currentSetting.Add("genPwd", false);
        }

        public void ChangeStatus(bool status, String name)  //true oder false sowie names eines keys
        {
            currentSetting[name] = status;
        }
        public bool getStatus(String name)
        {
            return currentSetting[name];
        }


        public void setWordCount(string count)
        {
            this.wordCount = Int32.Parse(count);
        }
        public int getWordCount()
        {
            if (this.wordCount != 0)
            {
                return this.wordCount;
            }
            else
            {
                return 16; //default 16 Zeichen
            }
        }

        public void setLeet(bool value)
        {
            this.leetspeak = value;
        }
        public bool getLeet()
        {
            return this.leetspeak;
        }
        public void setLeetString(string leetString)
        {
            this.leetString = leetString;
        }
        public string getLeetString()
        {
            return leetString;
        }
    }
}