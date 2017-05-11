<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Authentication.aspx.cs" Inherits="Authentication" %>

<!DOCTYPE html>

<html >
<head runat="server">
    <title>ZCurry Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            Enter Credentials
        </h3>
    </div>
    <div>
        <asp:Label
            ID="UserName"
            runat="server"
            Text="UserName:"
            />
        <asp:TextBox
            ID="tbUserName"
            runat="server"
            />
    </div>
    <br />
    <br />
    <br />
    <div>
        <asp:Label
            ID="Password"
            runat="server"
            Text="Password:"
            />
        <asp:TextBox
            ID="tbPassword"
            runat="server"
            TextMode="Password"
            />
    </div>
    <br />
    <br />
    <br />
    <div>
        <asp:Button
            ID="Enter"
            runat="server"
            Text="Enter"
            OnClick="Enter_Click"
            />
    </div>
    </form>
</body>
</html>
