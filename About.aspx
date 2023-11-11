<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:GridView ID="grdView" runat="server">
    </asp:GridView>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
<div style="max-width: 400px;">
        <h2 class="form-signin-heading">Registration</h2>
        <asp:Label Text="Username" runat="server" AssociatedControlID="txtUsername"/>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username" required="required"/>
        <br/>
        <asp:Label Text="Password" runat="server" AssociatedControlID="txtPassword"/>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Password must contain: Minimum 8 characters at-least 1 Alphabet and 1 Number"
            CssClass="form-control" placeholder="Enter Password" required="required"/>
        <br/>
        <asp:Label Text="Confirm Password" runat="server" AssociatedControlID="txtConfirmPassword"/>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Confirm Password" required="required"/>
        <br/>
        <asp:Label Text="Email" runat="server" AssociatedControlID="txtEmail"/>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" placeholder="Enter Email" required="required" />
        <hr/>
        <asp:Button ID="btnSignup" runat="server" Text="Sign up" CssClass="btn btn-primary" OnClick="btnSignup_Click"/>
    </div>

</asp:Content>

