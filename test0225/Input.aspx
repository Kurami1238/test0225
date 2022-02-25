<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="test0225.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        *{
            background-color:black;
            color:azure;
            font-family:Consolas;
            font-size: 22pt;
        }
        .p{
             float:left;
             margin: 10px;
             width:200px;
             height:200px;
        }
        .b{
            width: 900px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="ltltitle" runat="server">乘法對照表產生器</asp:Literal><br />
            基數&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="txtBaseNumber" runat="server"></asp:TextBox><br />
            係數&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="txtCoefficientNumber" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSend" runat="server" Text="產生" onclick="btnSend_Click" /><br />
            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
            
            <div class="b"><asp:Panel ID="panel1" runat="server"></asp:Panel></div>
            
        </div>
    </form>
</body>
</html>
