<%@ Page Title="" Language="C#" MasterPageFile="~/masters/site.master" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>An Error has Occurred</h1>

    <p><em>An unexceptional error occurred on our website.</em></p>

    <p>
        <a href="<%=Page.GetRouteUrl("home", new{}) %>">Return to the homepage.</a>
    </p>
</asp:Content>

