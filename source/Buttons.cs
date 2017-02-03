using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Buttons
{
        public static Setting ThisSetting = new Setting();
        public static Generator ThisGenerator = new Generator();
        /*public static */
        Charset thisCharset = new Charset();

        public void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_azK_Click(object sender, EventArgs e)
        {
            if (button_azK.BackColor == Color.Yellow)       //sender holt sich die ID, die in der .aspx für den Button gesetzt wurde
            {
                button_azK.BackColor = Color.Blue;
                ThisSetting.alpha = false;
            }
            else
            {
                button_azK.BackColor = Color.Yellow;
                ThisSetting.alpha = true;
            }
        }

        protected void button_azG_Click(object sender, EventArgs e)
        {
            if (button_azG.BackColor == Color.Yellow)
            {
                button_azG.BackColor = Color.Blue;
                ThisSetting.capAlpha = false;
            }
            else
            {
                button_azG.BackColor = Color.Yellow;
                ThisSetting.capAlpha = true;
            }
        }

        protected void button_09_Click(object sender, EventArgs e)
        {
            if (button_09.BackColor == Color.Yellow)
            {
                button_09.BackColor = Color.Blue;
                ThisSetting.num = false;
            }
            else
            {
                button_09.BackColor = Color.Yellow;
                ThisSetting.num = true;
            }
        }

        protected void button_sonder_Click(object sender, EventArgs e)
        {
            if (button_sonder.BackColor == Color.Yellow)
            {
                button_sonder.BackColor = Color.Blue;
                ThisSetting.specialChar = false;
            }
            else
            {
                button_sonder.BackColor = Color.Yellow;
                ThisSetting.specialChar = true;
            }
        }

        protected void button_Space_Click(object sender, EventArgs e)
        {
            if (button_Space.BackColor == Color.Yellow)
            {
                button_Space.BackColor = Color.Blue;
                ThisSetting.space = false;
            }
            else
            {
                button_Space.BackColor = Color.Yellow;
                ThisSetting.space = true;
            }
        }


    protected void button_Anagr_Click(object sender, EventArgs e)
    {
        if (button_Anagr.BackColor == Color.Yellow)
        {
            button_Anagr.BackColor = Color.Blue;
            ThisSetting.anagr = false;
        }
        else
        {
            button_Anagr.BackColor = Color.Yellow;
            ThisSetting.anagr = true;
        }
    }

    protected void button_Word_Click(object sender, EventArgs e)
    {
        if (button_Word.BackColor == Color.Yellow)
        {
            button_Word.BackColor = Color.Blue;
            ThisSetting.word = false;
        }
        else
        {
            button_Word.BackColor = Color.Yellow;
            ThisSetting.word = true;
        }
    }

    protected void button_Leet_Click(object sender, EventArgs e)
    {
        if (button_Leet.BackColor == Color.Yellow)
        {
            button_Leet.BackColor = Color.Blue;
            ThisSetting.leet = false;
        }
        else
        {
            button_Leet.BackColor = Color.Yellow;
            ThisSetting.leet = true;
        }
    }

    protected void button_gen_Click(object sender, EventArgs e)
        {
            newPassword.Text += thisCharset.createCharset(ThisSetting);
            //newPassword.Text += ThisSetting.alpha.ToString();
        }
    }

