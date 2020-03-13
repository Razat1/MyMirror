<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formStock" runat="server">
        <div>

            <br>
         StockDes: 
            <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
            <br>
          Quantity	: 
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br>
         DateAdded: 
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br>
         Price: 
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br>
            <br>
         
         Available:<input type="checkbox" name="Available" /><br>
            <br>
            &nbsp;
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" OnClientClick="Submit_Ok" Text="submit" />
        <asp:Button ID="btnCancel" runat="server" Text="cancel" />
    </form>
</body>

</html>
