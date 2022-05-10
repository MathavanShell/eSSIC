<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="eSSIC.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grddata" runat="server">
            </asp:GridView>

            <br />
            <asp:Button ID="Btngenerateexcel" runat="server" Text="Generate Excel" OnClick="Btngenerateexcel_Click" />
        </div>
    </form>
</body>
</html>
