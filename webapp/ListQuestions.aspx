<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListQuestions.aspx.cs" Inherits="ListQuestions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
          <div>
          
              <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
              </asp:Timer>
              Ellapsed Seconds :
              <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
          
          </div>
           <hr />
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View3" runat="server">
                    <table cellpadding="3" cellspacing="4" class="style1">
                        <tr>
                            <td>
                                MCQ<br />
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <table cellpadding="3" cellspacing="4" class="style1">
                        <tr>
                            <td>
                                Blanks<br />
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View1" runat="server">
                    <table cellpadding="3" cellspacing="4" class="style1">
                        <tr>
                            <td>
                                Bool<br />
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>

             <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Next" />
        </ContentTemplate>
    </asp:UpdatePanel>
   
    </form>
</body>
</html>
