<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>assignment#1</title>
    <style>
        center{
  align-content: center;
  margin: auto;
  justify-content: center;
  display: flex;
}
    </style>
</head>
<body>
   <center>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label>
        </div>
        <br />
        <div>
            <h4>Please select a date, it will display on Label1</h4>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </div>

        <div>
            <h4>Please select degree(s) then press the button, the degree(s) will display on Label2</h4>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
               <asp:ListItem>Bachelor</asp:ListItem>
               <asp:ListItem>Masters</asp:ListItem>
            </asp:CheckBoxList>
            
        <br />
             <h4>Please type more than 2 digits and select a operation then press the button, the result will display on Label3</h4>
        <asp:TextBox ID="TextBox1" runat="server" Type="Number"></asp:TextBox> 
        <br />
       
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Half" GroupName="Calculate" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Double" GroupName="Calculate" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Triple" GroupName="Calculate" />
        
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        </div>
    </form>
           <h5> Name : Podjamarn Phonyothee Section: CIT250-ME01 </h5>
    </center>
</body>
</html>
