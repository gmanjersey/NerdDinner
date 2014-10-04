<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<NerdDinner.Models.Dinner>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UpComing Dinners
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>UpComing Dinners</h2>
    <ul>
     <% foreach (var dinner in Model){%>
       <li>
         <%= Html.ActionLink(dinner.Title, "Details", new {Id=dinner.DinnerId})%>    
         on
         <%= Html.Encode(dinner.EventDate.Value.ToShortDateString()) %>
         @
         <%= Html.Encode(dinner.EventDate.Value.ToShortTimeString()) %>
       </li>
     <%}%>
    </ul>
</asp:Content>

