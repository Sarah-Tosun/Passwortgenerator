using Passwortgenerator.source;
using Passwortgenerator.source.propertie;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Passwortgenerator.source.password;

namespace Passwortgenerator
{
    public partial class Passwortgenerator : System.Web.UI.Page
    {
        public static Setting setting = new Setting();
        public static Farben farben = new Farben();
        public static Charset charset = new Charset();
        public static Leetspeak leetspeak = new Leetspeak();
        public static Whirlpool whirlpool;
        /*private Password alg;

        void SetAlg(Password alg)
        {
            this.alg = alg;
        }*/


        protected void button_azK_Click(object sender, EventArgs e)
        {
            if (setting.getStatus("alpha"))
            {
                button_azK.BackColor = farben.getFarbschema().button_Active;
                setting.ChangeStatus(false, "alpha");
                clearTextfield_All();
            }
            else
            {
                resetWhenChar();
                button_azK.BackColor = farben.getFarbschema().button_InActive;
                setting.ChangeStatus(true, "alpha");
                setTextInput();
                
            }
        }


        protected void button_azG_Click(object sender, EventArgs e)
        {
            if (setting.getStatus("capAlpha"))
            {
                button_azG.BackColor = farben.getFarbschema().button_Active;
                setting.ChangeStatus(false, "capAlpha");
                clearTextfield_All();
            }
            else
            {
                resetWhenChar();
                button_azG.BackColor = farben.getFarbschema().button_InActive;
                setting.ChangeStatus(true, "capAlpha");
                setTextInput();
            
            }
        }

        protected void button_Space_Click(object sender, EventArgs e)
        {
            if (setting.getStatus("space"))
            {
                button_Space.BackColor = farben.getFarbschema().button_Active;
                setting.ChangeStatus(false, "space");
                clearTextfield_All();
            }
            else
            {
                resetWhenChar();
                button_Space.BackColor = farben.getFarbschema().button_InActive;
                setting.ChangeStatus(true, "space");
                setTextInput();
          
            }
        }


        protected void button_Words_Click(object sender, EventArgs e)
        {
            //button_Words.BackColor = farben.getFarbschema().button_Active;
            //setting.ChangeStatus(true, "words");
            resetAll();
            textfeld1.Text = "";
            //button_Words.BackColor = farben.getFarbschema().button_InActive;
            //setting.ChangeStatus(true, "words");
        }


        protected void button_09_Click(object sender, EventArgs e)
        {
            if (setting.getStatus("num"))
            {
                button_09.BackColor = farben.getFarbschema().button_Active;
                setting.ChangeStatus(false, "num");
                clearTextfield_All();
            }
            else
            {
                resetWhenChar();
                button_09.BackColor = farben.getFarbschema().button_InActive;
                setting.ChangeStatus(true, "num");
                setTextInput();
                

            }
        }


        protected void button_sonder_Click(object sender, EventArgs e)
        {
            if (setting.getStatus("specialChar"))
            {
                button_sonder.BackColor = farben.getFarbschema().button_Active;
                setting.ChangeStatus(false, "specialChar");
                clearTextfield_All();
            }
            else
            {
                resetWhenChar();
                button_sonder.BackColor = farben.getFarbschema().button_InActive;
                setting.ChangeStatus(true, "specialChar");
                setTextInput();
              
            }
        }
        
        
        //
        // ToDo: Funktion noch machen
        //
        protected void button_Anagr_Click(object sender, EventArgs e)
        {
           /* if (setting.getAcronym())
            {
                button_Anagr.BackColor = farben.getFarbschema().button_Active;
                setting.setAcronym(false);
                clearTextfield_All();
            }
            else
            {
                button_Leet.BackColor = farben.getFarbschema().button_Active;
                setting.setLeet(false);

                button_Anagr.BackColor = farben.getFarbschema().button_InActive;
                setting.setAcronym(true);
                textfeld2.Visible = true;
                //textfeld2.Text = "Pwd-länge hier ändern (Std: 10)";
                resetWhenWord();
                setTextInput_Ana_Leet();
                SetAlg(new Acronym());
            }*/
        }


        //
        // ToDo: Funktion noch machen
        //
        protected void button_Leet_Click(object sender, EventArgs e)
        {
            if(setting.getLeet())
            {
                button_Leet.BackColor = farben.getFarbschema().button_Active;
                setting.setLeet(false);
                textfeld2.Visible = false;
                clearTextfield_All();
            }
            else
            {
                button_Anagr.BackColor = farben.getFarbschema().button_Active;
                //setting.setAcronym(false);
                button_Leet.BackColor = farben.getFarbschema().button_InActive;
                setting.setLeet(true);
                textfeld2.Visible = true;
                resetWhenWord();
                textfeld2.Text = "Passwortstring";
                textfeld2.ForeColor = System.Drawing.Color.Gray;
            }
            
        }


        //
        // ToDo: Div-Box "Ausgabe" Sichtbarkeit bearbeiten
        //
        protected void button_gen_Click(object sender, EventArgs e)
        {
            textfeld1.Text = "";
            ausgabe_feld.Visible = true;            //Damit Server auf HTML-ID zugreifen kann, muss "runat=server" bei dem entspr. Element stehen
                    
            if (setting.getLeet())// || setting.getAcronym())
            {
                /*try
                {
                    setting.setWordCount(Int32.Parse(textfeld2.Text));
                }
                catch (FormatException)
                {
                    textfeld2.Text = "Keine Zahl, Länge wird auf 10 gesetzt";
                }*/
                //try
                //{
                    setting.setLeetString(textfeld2.Text);
                    textfeld1.Text = leetspeak.GeneratePassword(setting);
                ausgabe_feld.InnerText = leetspeak.GeneratePassword(setting);
                //}
                // catch (NullReferenceException)
                //{

                //}
            }
            else
            {
                setting.setWordCount(textfeld2.Text);
                whirlpool = new Whirlpool(charset.createCharset(setting),setting.getWordCount());
                textfeld1.Text = whirlpool.getPassword();
                ausgabe_feld.InnerText = whirlpool.getPassword();
            }
        }


        public void resetWhenChar()
        {
            button_Leet.BackColor = farben.getFarbschema().button_Active;
            setting.setLeet(false);
            button_Anagr.BackColor = farben.getFarbschema().button_Active;
            //setting.setAcronym(false);
        }

        public void resetAll()
        {
            button_Leet.BackColor = farben.getFarbschema().button_Active;
            setting.setLeet(false);
            button_Anagr.BackColor = farben.getFarbschema().button_Active;
            //setting.setAcronym(false);
            button_sonder.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "specialChar");
            button_09.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "num");
            button_Words.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "words");
            button_Space.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "space");
            button_azG.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "capAlpha");
            button_azK.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "alpha");
        }

        public void resetWhenWord()
        {
            button_sonder.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "specialChar");
            button_09.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "num");
            button_Words.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "words");
            button_Space.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "space");
            button_azG.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "capAlpha");
            button_azK.BackColor = farben.getFarbschema().button_Active;
            setting.ChangeStatus(false, "alpha");
        }

        public void setTextInput()
        {
            textfeld2.Visible = true;
            textfeld2.Text = "16";
            textfeld2.ForeColor = System.Drawing.Color.Gray;
        }

        public void clearTextfield_All()
        {
            textfeld1.Text = "";
        }
    }

}