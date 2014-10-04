<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Dinner:<%= Html.Encode(Model.Title)%>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%=Html.Encode(Model.Title) %>Details</h2>
     <p>
        <strong>When:</strong> 
           <%= Model.EventDate.Value.ToShortDateString() %>
        <strong>@</strong>
          <%=Model.EventDate.Value.ToShortTimeString() %>
     </p>
     <p>
           <strong>Where:</strong>
           <%= Html.Encode(Model.Address) %>
           <%= Html.Encode(Model.Country) %>
     </p>
     <p>
          <strong>Description:</strong>
          <%= Html.Encode(Model.Description) %>
     </p>
       <p>
          <strong>Organizer:</strong>
          <%= Html.Encode(Model.HostedBy) %>
         (<%=Html.Encode(Model.ContactPhone) %>)
      </p>
    <p>
        <%=Html.ActionLink("Edit Dinner", "Edit", new { id=Model.DinnerId }) %> |
        <%=Html.ActionLink("Delete Dinner", "Delete", new {id= Model.DinnerId} ) %>
    </p>
</asp:Content>

