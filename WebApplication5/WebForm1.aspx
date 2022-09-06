<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <div>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.css"
       
        rel="stylesheet" type="text/css" />
</div>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 55px;
        }
        .auto-style3 {
            width: 200px;
        }
        .auto-style4 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="40px" OnTextChanged="DropDownList1_TextChanged" Width="149px">
        </asp:DropDownList>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="50px" Width="149px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="50px" Width="149px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
     
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Search by ID</td>
                <td>
                    <asp:TextBox ID="SearchTxt" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Name</td>
                <td>
                    <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Desgination</td>
                <td>
                    <asp:TextBox ID="DesgiantionTxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td>
                    <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age</td>
                <td>
                    <asp:TextBox ID="Agetxt" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
     
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style4" Height="204px" Width="629px">
        </asp:GridView>
     
    </form>
</body>
</html>
