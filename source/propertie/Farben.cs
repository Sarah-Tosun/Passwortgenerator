using System;
using System.Collections.Generic;
using System.Drawing;

namespace Passwortgenerator.source.propertie
{
    public class Farben
    {
        // private Color button_Active = System.Drawing.ColorTranslator.FromHtml("#EC9A3F");
        // private Color button_InActive = System.Drawing.ColorTranslator.FromHtml("#EC9A3F");
        //private Color button_Active = System.Drawing.ColorTranslator.FromHtml("#EC9A3F");
        Dictionary<string, Farbschema> colors = new Dictionary<string, Farbschema>();

        private Farbschema active;
        private Farbschema standard;
        //private Farbschema blauweis;

        public Farben()
        {
            //(1) clicked    89CC98, (2) unclicked  6FB37E
            standard = new Farbschema(System.Drawing.ColorTranslator.FromHtml("#89CC98"), System.Drawing.ColorTranslator.FromHtml("#6FB37E"));
            //blauweis = new Farbschema(System.Drawing.ColorTranslator.FromHtml("#CBE0EF"), System.Drawing.ColorTranslator.FromHtml("#5399CB"));
            colors.Add("standard", standard);
            //colors.Add("blauweis", blauweis);
            active = standard;
        }

        public Farbschema getFarbschema()
        {
            return active;
        }

        public void ChangeFarbschema(String Farbschema)
        {
            active = colors[Farbschema];
        }

        public struct Farbschema
        {
            public Color button_Active, button_InActive;

            public Farbschema(Color active, Color inactive)
            {
                button_Active = active;
                button_InActive = inactive;
            }
        }
    }
}