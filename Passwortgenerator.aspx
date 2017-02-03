<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Passwortgenerator.aspx.cs" Inherits="Passwortgenerator.Passwortgenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Passwort Generator</title>
    <link rel="stylesheet" href="css/style.css" />
    <!--kommt das noch weg? Anfang-->
    <style type="text/css">
        #Reset1 {
            margin-left: 10px;
        }
        #Submit1 {
            margin-left: 172px;
        }
    </style>
    <!--kommt das noch weg? Ende-->
</head>


<body id="background_main">
    <form id="form1" runat="server">
        <div class="img_hintergrund">
            <div id="div-buttongroup1">
                <asp:Button ID="button_azK" runat="server" class="round-button" text="a-z" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Kleinbuchstaben" OnClick="button_azK_Click" /> 
                <asp:TextBox ID="textfeld1" runat="server" CssClass="glowing-border" style="text-align: center"></asp:TextBox>
                <script type="text/javascript">
                    <!-- function clearTextfield() { document.getElementById(' textfeld1.ClientID ').value = ""; } 
                </script>            

                <asp:Button ID="button_09" runat="server" class="round-button" text="0-9" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Zahlen" OnClick="button_09_Click" />  
            </div>
            <div id="div-buttongroup2">
                <asp:Button ID="button_azG" runat="server" class="round-button" text="A-Z" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Großbuchstaben" OnClick="button_azG_Click" /> 
                <asp:Button ID="button_sonder" runat="server" class="round-button" text="!$%§" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Sonderzeichen" OnClick="button_sonder_Click" /> 
                <asp:TextBox ID="textfeld2" runat="server" CssClass="glowing-border" Visible="false" style="text-align: center" onclick="clearTextfield2();"></asp:TextBox>
                <script type="text/javascript">
                    function clearTextfield2() {
                        document.getElementById('<%= textfeld2.ClientID %>').value = "";
                    }
                </script> 
                <div runat="server" id="ausgabe_feld" Visible="false"></div>
            </div>  

            <div id="div-buttongroup3">
                <asp:Button ID="button_Space" runat="server" class="round-button" text="Space" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Leerzeichen (bitte mit anderen Buttons verwenden)" OnClick="button_Space_Click" /> 
                <asp:Button ID="button_Anagr" runat="server" class="round-button" text="Anagr." style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Anagramme" OnClick="button_Anagr_Click" /> 
            </div>
              
            <div id="div-buttongroup4">
                <asp:Button ID="button_Words" runat="server" class="round-button" text="Reset" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Reset" OnClick="button_Words_Click" /> 
                <asp:Button ID="button_Leet" runat="server" class="round-button" text="Leet" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Leetspeak" OnClick="button_Leet_Click" /> 
            </div>
              
            <div id="div-buttongroup5">
                <asp:Button ID="button_gen" runat="server" class="round-button-elip" text="generate" style="font-family:'Arial'; font-size: 1.0em; font-weight: bold;" ToolTip="Passwort generieren" OnClick="button_gen_Click" /> 
            </div> 
        </div>
    </form>
</body>
</html>
