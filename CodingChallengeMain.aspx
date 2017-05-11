<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodingChallengeMain.aspx.cs" Inherits="CodingChallengeMain" %>

<!DOCTYPE html>

<!--
     * Using C#, write a web-api method that parses a sentence and replaces each word with the 
     * following: first letter, number of distinct characters between first and last character,
     * and last letter. For example, Patterns would become P5s. Words are separated by spaces or
     * non-alphabetic characters and these separators should be maintained in their original
     * form and location in the answer. 
     * 
     * 3rd party applications need to be authenticated before they call the method.
     * Try not to use helper methods for string manipulation, try to write your own algorithms
     * Include documentation on how to call your api
     * Include test cases and the results in your solution 
     * 
     * We are looking for accuracy, efficiency and solution completeness. Please include
     * this problem description in the comment at the top of your solution. 
-->

<html>
<head runat="server">
    <title>Zachary A. Curry</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label
                ID="Label1" 
                runat="server"
                Text="Please enter a sentence in the following textbox to parse:"
                />
        </div>
        <div>
            <asp:TextBox
                ID="tbEnterSentence"
                runat="server"
                TextMode="MultiLine"
                Width="50%"
                />
        </div>
        <div>
            <asp:Button
                ID="Enter"
                runat="server"
                Text="Enter"
                OnClick="Enter_Click"
                />
        </div>
        <br />
        <br />
        <div>
            <asp:TextBox
                ID="tbParsedSentence"
                runat="server"
                TextMode="MultiLine"
                ReadOnly="True"
                Width="50%"
                />
        </div>
    </div>
    </form>
</body>
</html>
