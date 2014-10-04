<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Controllers.DinnerFormViewModel>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Host a Dinner
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Host a Dinner</h2>

    <%= Html.ValidationSummary("Please correct the errors and try again.") %>
    <%  Html.RenderPartial("DinnerForm"); %>  

</asp:Content>

