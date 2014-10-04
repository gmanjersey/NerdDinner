<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Controllers.DinnerFormViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit: <%= Html.Encode(Model.Dinner.Title) %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Dinner</h2>

    <%= Html.ValidationSummary("Please correct the errors and try again.") %>

    <% Html.RenderPartial("DinnerForm"); %>    
    
</asp:Content>

