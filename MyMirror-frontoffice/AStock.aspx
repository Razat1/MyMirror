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

          StockNo: <input type="text" name="StockNo"><br>
         StockDes: <input type="text" name="StockDescription"><br>
          Quantity	: <input type="text" name="Quantity"><br>
         DateAdded: <input type="date" name="DateAdded"><br>
         Price: <input type="text" name="price"><br>
            <br>
         
         Available:<input type="checkbox" name="Available" /><br>
            <br>
         <input type="button" value="OK" id="btnok"><input type="button" value="Cancel">&nbsp;
        </div>
    </form>
</body>

</html>
