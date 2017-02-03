using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Passwortgenerator.source.password;

namespace Passwortgenerator.source.password
{
    public class Charset
    {
        string alpha;
        string capAlpha;
        string num;
        string specialChar;
        string space;

        public string charset = "";

        public Charset()
        {
            alpha = "abcdefghijklmnopqrstuvwxyz";
            capAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            num = "0123456789";
            specialChar = "!§$%&/()=?`#´*+~'-_@|,.:;";
            space = " "; /* <-- lol */
        }

        public string createCharset(Setting wordSetting)
        {
            charset = "";
            if (wordSetting.getStatus("alpha") == true)
            {
                charset += alpha;
            }
            if (wordSetting.getStatus("capAlpha") == true)
            {
                charset += capAlpha;
            }
            if (wordSetting.getStatus("num") == true)
            {
                charset += num;
            }
            if (wordSetting.getStatus("specialChar") == true)
            {
                charset += specialChar;
            }
            if (wordSetting.getStatus("space") == true)
            {
                charset += space;
            }
            return charset;
        }
    }


}