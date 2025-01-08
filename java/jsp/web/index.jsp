<%-- 
    Document   : idnex
    Created on : 7 de jan. de 2025, 11:48:41
    Author     : josem
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SessionApp</title>
        <%@include file="WEB-INF/jspf/html-head-libs.jspf" %>
    </head>
    <body>
        <%@include file="WEB-INF/jspf/navbar.jspf" %>
        <% if (userName != null) {%>
            <div class="m-2">
                <h2>Página inicial</h2>
                <div>Conteúdo da página</div>
            </div>
        <% }%>
        <%@include file="WEB-INF/jspf/html-body-libs.jspf" %>
    </body>
</html>
