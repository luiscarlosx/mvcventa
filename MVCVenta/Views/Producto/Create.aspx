<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCVenta.Models.TB_Producto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Pk_eProducto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Pk_eProducto) %>
                <%: Html.ValidationMessageFor(model => model.Pk_eProducto) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Fk_eDominio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Fk_eDominio) %>
                <%: Html.ValidationMessageFor(model => model.Fk_eDominio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.cDescripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.cDescripcion) %>
                <%: Html.ValidationMessageFor(model => model.cDescripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.dPrecio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.dPrecio) %>
                <%: Html.ValidationMessageFor(model => model.dPrecio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.cEspecificacion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.cEspecificacion) %>
                <%: Html.ValidationMessageFor(model => model.cEspecificacion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.bImagen) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.bImagen) %>
                <%: Html.ValidationMessageFor(model => model.bImagen) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

